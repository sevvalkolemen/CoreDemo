using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapalım.");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girşi yapınız.");
        }
    }
}
