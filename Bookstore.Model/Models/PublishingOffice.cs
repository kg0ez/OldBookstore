using System;
namespace Bookstore.Model.Models
{
    public class PublishingOffice
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;

        public ICollection<Book> Books { get; set; }
    }
}

