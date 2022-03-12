using FluentValidation;
using MutationTest.Domain.Commands.CreateCommands;

namespace MutationTest.Domain.Validations
{
    public class CustomerCreateCommandValidator : AbstractValidator<CustomerCreateCommand>
    {
        public CustomerCreateCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5);
            RuleFor(x => x.BirthDate).Must(x => x != DateTime.MinValue);
            RuleFor(x => x.DocumentNumber).NotEmpty();
            RuleFor(x => x.DocumentType).NotEmpty();
        }
    }
}