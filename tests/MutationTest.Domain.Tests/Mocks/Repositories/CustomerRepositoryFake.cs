using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MutationTest.Domain.Contracts.Repositories;
using MutationTest.Domain.Models;

namespace MutationTest.Domain.Tests.Mocks.Repositories
{
    public class CustomerRepositoryFake : ICustomerRepository
    {
        private readonly IList<Customer> _source;

        public CustomerRepositoryFake()
        {
            _source = new List<Customer>();
        }


        public Task Add(Customer item)
        {
            _source.Add(item);
            return Task.CompletedTask;
        }


        public Task Update(Customer item)
        {
            var customer = _source.FirstOrDefault(x => x.Id == item.Id);

            if (customer != null)
            {
                _source.Remove(item);
                _source.Add(customer);
            }

            return Task.CompletedTask;
        }


        public Task Delete(Customer item)
        {
            var customer = _source.FirstOrDefault(x => x.Id == item.Id);

            if (customer != null)
            {
                _source.Remove(customer);
            }

            return Task.CompletedTask;
        }


        public Task Delete(Guid id)
        {
            var customer = _source.FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                _source.Remove(customer);
            }

            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await Task.FromResult(_source);
        }

        public async Task<Customer?> Get(Guid id)
        {
            return await Task.FromResult(_source.FirstOrDefault(x => x.Id == id));
        }
    }
}