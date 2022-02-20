using FluentValidation;
using GreenMonkey.Dtos;
using System;
using System.Threading.Tasks;

namespace GreenMonkey.Api.Validators
{
    public class SuscriptorValidator : AbstractValidator<SuscriptorDto>
    {
        public SuscriptorValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty()
                .Length(4, 4);

            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.Owner)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.Description)
                .NotEmpty()
                .Length(1, 250);

            RuleFor(x => x.BaseUrl)
                .NotEmpty()
                .Must(baseUrl => Uri.TryCreate(baseUrl, UriKind.Absolute, out _))
                .WithMessage("Invalid url");
        }
    }
}
