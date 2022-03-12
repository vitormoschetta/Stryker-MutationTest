using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutationTest.Domain.Commands.UpdateCommands
{
    public class CustomerUpdateCommand
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; }
    }
}