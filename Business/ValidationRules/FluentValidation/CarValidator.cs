using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı 0'dan büyük olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(4).WithMessage("Araç açıklaması en az 4 karakter uzunluğunda olmalıdır.");
        }
    }
}
