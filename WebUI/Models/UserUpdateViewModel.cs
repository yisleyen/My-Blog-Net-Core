using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserUpdateViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Ad - Soyad")]
        [Required(ErrorMessage = "Ad - Soyad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "E-Posta Adresi")]
        [Required(ErrorMessage = "E-posta adresi giriniz")]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
