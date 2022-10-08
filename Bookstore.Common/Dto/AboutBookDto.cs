using System;
namespace Bookstore.Common.Dto
{
    public class AboutBookDto
    {
        public string Cover { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Weight { get; set; }
        public int AgeLimit { get; set; }
        public int PublicationYear { get; set; }

        //public int BookId { get; set; }
        //public BookDto Book { get; set; }
    }
}

