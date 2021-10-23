using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel boş geçilemez");
            RuleFor(x => x.ThumbnailImage).NotEmpty().WithMessage("Küçük görsel boş geçilemez");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori boş geçilemez");

            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık minimum 10 karakter olmalıdır.");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Başlık maksimum 150 karakter olmalıdır.");

            RuleFor(x => x.Content).MinimumLength(100).WithMessage("İçerik minimum 100 karakter olmalıdır.");
        }
    }
}
