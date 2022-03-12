namespace MutationTest.Domain.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; } 
    }
}