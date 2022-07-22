using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class DescriptionBook
    {
        public DescriptionBook()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string? Genre { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
