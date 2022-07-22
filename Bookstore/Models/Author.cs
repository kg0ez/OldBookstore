using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
