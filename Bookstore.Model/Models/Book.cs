using System;
namespace Bookstore.Model.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Img { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string Genre { get; set; } = null!;

        public int AboutBookId { get; set; }
        public AboutBook AboutBook { get; set; }

        public int CostBookId { get; set; }
        public CostBook CostBook { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int ProviderId { get; set; }
        public Provider Provider { get; set; } = null!;

        public int PublishingOfficeId { get; set; }
        public PublishingOffice PublishingOffice { get; set; } = null!;

        //public ICollection<Order> Orders { get; set; }
    }
}

