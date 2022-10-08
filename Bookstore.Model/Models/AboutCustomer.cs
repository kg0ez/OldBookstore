using System;
namespace Bookstore.Model.Models
{
    public class AboutCustomer
    {
        public int Id { get; set; }
        public int? NumberPurchases { get; set; }
        public int? Discount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

