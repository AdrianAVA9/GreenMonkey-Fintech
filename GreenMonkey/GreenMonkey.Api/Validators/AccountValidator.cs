using FluentValidation;
using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Validators
{
    public class AccountValidator : AbstractValidator<AccountDto>
    {
        public AccountValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .Length(1, 50);

            RuleFor(x => x.Status)
                .NotEmpty()
                .Length(1, 10);

            RuleFor(x => x.CustomerId)
               .NotEmpty()
               .Length(9, 14);

            RuleFor(x => x.CoinCode)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}