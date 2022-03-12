using MutationTest.Domain.Commands.CreateCommands;
using MutationTest.Domain.Commands.DeleteCommands;
using MutationTest.Domain.Commands.UpdateCommands;
using MutationTest.Domain.Contracts.Handlers;
using MutationTest.Domain.Contracts.Repositories;
using MutationTest.Domain.Dtos;
using MutationTest.Domain.Enums;
using MutationTest.Domain.Models;

namespace MutationTest.Domain.Commands.Handlers
{
    public class CustomerCommandHandler : ICustomerCommandHandler
    {
        private ICustomerRepository _repository;

        public CustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<GenericResponse> Handle(CustomerCreateCommand command)
        {
            if (command is null)
            {
                return new GenericResponse("Invalid Customer", EOutputType.InvalidInput);
            }

            var validationCommand = command.Validate();

            if (!validationCommand.IsValid)
            {
                var notification = string.Join("; ", validationCommand.Errors);
                return new GenericResponse(notification, EOutputType.BusinessValidation);
            }

            var customer = new Customer()
            {
                Name = command.Name,
                BirthDate = command.BirthDate,
                DocumentNumber = command.DocumentNumber,
                DocumentType = command.DocumentType
            };

            await _repository.Add(customer);

            return new GenericResponse();
        }

        public Task<GenericResponse> Handle(CustomerUpdateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse> Handle(CustomerDeleteCommand command)
        {
            throw new NotImplementedException();
        }

        public void Handle()
        {
            // Todo: como testar um metodo que não retorna valor?
            throw new NotImplementedException();
        }
    }
}