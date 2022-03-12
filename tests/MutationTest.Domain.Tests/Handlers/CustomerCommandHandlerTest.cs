using System;
using System.Threading.Tasks;
using MutationTest.Domain.Commands.CreateCommands;
using MutationTest.Domain.Commands.Handlers;
using MutationTest.Domain.Tests.Mocks.Repositories;
using Xunit;

namespace MutationTest.Domain.Tests.Handlers;

public class CustomerCommandHandlerTest
{
    private CustomerRepositoryFake repository;
    private CustomerCommandHandler handler;
    private CustomerCreateCommand customerCreateCommand;

    public CustomerCommandHandlerTest()
    {
        repository = new CustomerRepositoryFake();
        handler = new CustomerCommandHandler(repository);
        customerCreateCommand = new CustomerCreateCommand
        {
            Name = "Vitor Moschetta",
            BirthDate = new DateTime(1989, 5, 28),
            DocumentNumber = "99999999999999",
            DocumentType = "CPF"
        };
    }


    [Fact]
    public async Task CustomerCreateCommand_Is_Success()
    {
        // arrange
        var customer = customerCreateCommand;

        // act
        var response = await handler.Handle(customer);

        // assert
        Assert.True(response.Success, response.Message);
    }


    [Fact]
    public async Task CustomerCreateCommand_Empty_Is_Invalid()
    {
        // arrange
        var customer = new CustomerCreateCommand();

        // act
        var response = await handler.Handle(customer);

        // assert
        Assert.False(response.Success, response.Message);
    }


    [Fact]
    public async Task CustomerCreateCommand_Name_is_less_than_five_characters()
    {
        // arrange
        var repository = new CustomerRepositoryFake();

        var handler = new CustomerCommandHandler(repository);

        var customer = customerCreateCommand;
        customer.Name = "Bob"; // Name less thanb five characters

        // act
        var response = await handler.Handle(customer);

        // assert
        Assert.False(response.Success, response.Message);
    }
}
