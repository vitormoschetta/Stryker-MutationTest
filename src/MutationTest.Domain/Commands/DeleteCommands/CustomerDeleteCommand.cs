using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutationTest.Domain.Commands.DeleteCommands
{
    public class CustomerDeleteCommand
    {
        public Guid Id { get; set; }
    }
}