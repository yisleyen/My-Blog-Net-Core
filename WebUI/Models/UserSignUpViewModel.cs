using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Ad - Soyad")]
        [Required(ErrorMessage = "Ad - Soyad giriniz")]
        public string NormalizedUserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Girmiş olduğunuz şifreler aynı olmalıdır")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "E-Posta Adresi")]
        [Required(ErrorMessage = "E-posta adresi giriniz")]
        public string Email { get; set; }
    }
}
