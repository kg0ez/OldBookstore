using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class AboutBook
    {
        public int BookId { get; set; }
        public string Cover { get; set; } = null!;
        public string? Description { get; set; }
        public int? Weight { get; set; }
        public int? AgeLimit { get; set; }
        public int? PublicationYear { get; set; }

        public virtual Book? Book { get; set; }
    }
}
