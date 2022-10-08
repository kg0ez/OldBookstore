using System;
namespace Bookstore.Model.Models
{
    public class AddressСustomer
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Home { get; set; }
        public string? Apartment { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

