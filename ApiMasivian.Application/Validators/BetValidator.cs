using ApiMasivian.Bussiness.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMasivian.Application.Validators
{
    public class BetValidator : AbstractValidator<BetRequest>
	{
		public BetValidator()
		{
			RuleFor(x => x.idRoulette).NotEmpty().NotNull().WithMessage("Roulette is required.");
			RuleFor(x => x.money).InclusiveBetween(1, 10000);
		}
	}
}
