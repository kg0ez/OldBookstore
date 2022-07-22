using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Book
    {
        public Book()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Img { get; set; } = null!;
        public int DescriptionId { get; set; }
        public int LanguageId { get; set; }
        public int AuthorId { get; set; }
        public int ProviderId { get; set; }
        public int PublishingOfficeId { get; set; }

        public virtual Author Author { get; set; } = null!;
        public virtual DescriptionBook Description { get; set; } = null!;
        public virtual Language Language { get; set; } = null!;
        public virtual Provider Provider { get; set; } = null!;
        public virtual Publisher PublishingOffice { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
