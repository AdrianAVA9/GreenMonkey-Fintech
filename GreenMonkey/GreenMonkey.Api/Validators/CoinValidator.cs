using FluentValidation;
using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Validators
{
    public class CoinValidator : AbstractValidator<CoinDto>
    {
        public CoinValidator()
        {
            RuleFor(x => x.FintechCode)
               .NotEmpty()
               .Length(4, 4);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 50);
        }
    }
}