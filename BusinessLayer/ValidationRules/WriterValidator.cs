using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad-Soyad alanı boş bırakılamaz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi alanı boş bırakılamaz!!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz!!");
            RuleFor(x => x.WriterName).MinimumLength(5).WithMessage("Ad-Soyad alanı en az 5 karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad-Soyad alanı 50 karakteri geçemez.");
        }
    }
}
