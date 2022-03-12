using FluentValidation.Results;
using MutationTest.Domain.Validations;

namespace MutationTest.Domain.Commands.CreateCommands
{
    public class CustomerCreateCommand
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; }

        public ValidationResult Validate()
        {
            return new CustomerCreateCommandValidator().Validate(this);
        }
    }
}