using System;
namespace Bookstore.Model.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string? Phone { get; set; }

        //public ICollection<Order> Orders { get; set; }

        //public int AboutCustomerId { get; set; }
        public AboutCustomer AboutCustomer { get; set; }

        //public int AddressСustomerId { get; set; }
        public AddressСustomer AddressСustomer { get; set; }

        //public int CreditCardId { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}

