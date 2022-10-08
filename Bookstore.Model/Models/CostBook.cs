using System;
namespace Bookstore.Model.Models
{
    public class CostBook
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal CostDelivery { get; set; }
        public string TimeDelivery { get; set; } = null!;

        //public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

