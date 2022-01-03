using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Bırakılamaz");
            RuleFor(x => x.BlogContect).NotEmpty().WithMessage("Blog İçeriği Boş Bırakılamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görseli Boş Bırakılamaz");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Blog Başlığı 100 Karakterden Fazla Olamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığı 5 Karakterden Az Olamaz");
        }
    }
}
