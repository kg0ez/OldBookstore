using System;
namespace Bookstore.Model.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

