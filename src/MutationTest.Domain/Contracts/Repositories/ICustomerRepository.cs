using MutationTest.Domain.Models;

namespace MutationTest.Domain.Contracts.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(Customer item);
        Task Update(Customer item);
        Task Delete(Customer item);
        Task Delete(Guid id);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer?> Get(Guid id);
    }
}