using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad - Soyad boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad - Soyad minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("Ad - Soyad maksimum 100 karakter olmalıdır.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("E-posta adresi formatını kontrol ediniz.");
            RuleFor(x => x.Password).Matches(@"[a-z]+").WithMessage("Şifreniz küçük harf içermelidir.");
            RuleFor(x => x.Password).Matches(@"[0-9]+").WithMessage("Şifreniz büyük harf içermelidir.");
            RuleFor(x => x.Password).Matches(@"[A-Z]+").WithMessage("Şifreniz rakamkds harf içermelidir.");
        }
    }
}
