using FluentValidation;
using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .Length(9, 15);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.Nickname)
                .NotEmpty()
                .Length(1, 30);

            RuleFor(x => x.Status)
                .NotEmpty()
                .Length(1, 15);

            RuleFor(x => x.Birthdate)
                .NotNull()
                .Must(x => DateTime.Now.AddYears(-18).Date >= x.Date)
                .WithMessage("Must be 18 years of age");
        }
    }
}