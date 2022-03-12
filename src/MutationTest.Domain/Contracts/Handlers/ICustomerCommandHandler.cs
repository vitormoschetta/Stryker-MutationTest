using MutationTest.Domain.Commands.CreateCommands;
using MutationTest.Domain.Commands.DeleteCommands;
using MutationTest.Domain.Commands.UpdateCommands;
using MutationTest.Domain.Dtos;

namespace MutationTest.Domain.Contracts.Handlers
{
    public interface ICustomerCommandHandler
    {
        Task<GenericResponse> Handle(CustomerCreateCommand command);
        Task<GenericResponse> Handle(CustomerUpdateCommand command);
        Task<GenericResponse> Handle(CustomerDeleteCommand command);
        void Handle();
    }
}