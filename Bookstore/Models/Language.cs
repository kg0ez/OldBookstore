using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Language
    {
        public Language()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Language1 { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
