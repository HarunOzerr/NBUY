using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class LoginDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="{0} boş bırakalmamalı.")]
        public string UserName { get; set; }

        [DisplayName("Email Adresi")]
        [Required(ErrorMessage = "{0} boş bırakılmamalı.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} boş bırakalmamalı.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
