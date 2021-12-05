using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("İçerik boş geçilemez");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Başlık minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Başlık maksimum 50 karakter olmalıdır.");

            RuleFor(x => x.Description).MinimumLength(100).WithMessage("İçerik minimum 100 karakter olmalıdır.");
        }
    }
}
