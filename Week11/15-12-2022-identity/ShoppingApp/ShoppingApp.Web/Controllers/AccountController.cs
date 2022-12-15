using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginDto { ReturnUrl=returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı.");
                    return View(loginDto);
                }
                //Bu noktada email onayı yapılıp yapılmadığını kontrol edeceğiz.
                //Eğer email onaylı ise login yaptıracağız, değil ise hatırlatacağız.
                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Kullanıcı adı ya da parola hatalı.");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] //İlgili cookie'nin sadece ait olduğu tarayıcı tarafından gönderilmesi halinde geçerli olmasını sağlar.
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email,
                };
                var result = await _userManager.CreateAsync(user, registerDto.Password);
                if (result.Succeeded)
                {
                    //Generate Token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = tokenCode
                    });
                    //Mailin gönderilme, onaylanma vs
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                        $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız</p>" +
                        $"<a href='http://localhost:5178{url}'></a>");
                    ViewBag.Message("Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.");
                    return RedirectToAction("Login", "Account"); //Başka bir controller'daki action'a yollamak için 2. parametreye controller ismi vererek yollayabiliyoruz.
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz.");
            return View(registerDto);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null) //userId veya token null ise
            {
                ViewBag.Message("Geçersiz token ya da user bilgisi.");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    ViewBag.Message("Hesabınız başarıyla onaylandı.");
                    return View();
                }
            }
            ViewBag.Message("Bir sorun oluştu ve hesabınız onaylanmadı. Tekrar deneyiniz");
            return View();
        }
    }
}
