using System;
namespace Bookstore.Model.Models
{
    public class AboutBook
    {
        public int Id { get; set; }
        public string Cover { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Weight { get; set; }
        public int AgeLimit { get; set; }
        public int PublicationYear { get; set; }

        public Book Book { get; set; }
    }
}

