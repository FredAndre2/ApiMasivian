using ApiMasivian.Bussiness.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.Application.Validators
{
    public class BetToSaveValidator : AbstractValidator<BetToSave>
    {
        public BetToSaveValidator()
        {
            RuleFor(x => x.idRoulette).NotEmpty().NotNull().WithMessage("Roulette is required.");
            RuleFor(x => x.idUser).NotEmpty().NotNull().WithMessage("User is required.");
            RuleFor(x => x.money).InclusiveBetween(1, 10000);
        }
    }
}
