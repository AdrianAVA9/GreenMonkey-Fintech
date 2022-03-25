using FluentValidation;
using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Validators
{
    public class TransactionValidator : AbstractValidator<TransactionDto>
    {
        public TransactionValidator()
        {
            RuleFor(x => x.Amount)
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.Type)
                .NotEmpty()
                .Must(x => x == "credito" || x == "debito")
                .WithMessage("Invalid type");

            RuleFor(x => x.UBAN)
               .NotEmpty()
               .Length(14, 14);
        }
    }
}