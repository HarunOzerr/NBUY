using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using OzelDersler.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OzelDersler.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto, string registerType)
        {
            if (ModelState.IsValid)
            {
                if (registerType == "teacher")
                {
                    var user = new User
                    {
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                        Teachers = new List<Teacher>
                        {
                            new Teacher
                            {
                                FirstName = registerDto.FirstName,
                                LastName = registerDto.LastName
                            }
                        }.ToList()
                    };
                    await _userManager.CreateAsync(user, registerDto.Password);
                }
            }
            return View(registerDto);
        }
    }
}
