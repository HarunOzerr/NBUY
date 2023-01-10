using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using Microsoft.AspNetCore.Identity;

namespace OzelDersler.Web.Models
{
    public class RegisterDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string LastName { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string UserName { get; set; }

        [DisplayName("Eposta")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Parola Tekrar")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola ile {0} aynı olmalıdır.")]
        public string RePassword { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
