using System;
namespace Bookstore.Common.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Img { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string Genre { get; set; } = null!;

        public AboutBookDto AboutBook { get; set; }

        public CostBookDto CostBook { get; set; }

        public int AuthorId { get; set; }
        public AuthorDto Author { get; set; } = null!;

        public int ProviderId { get; set; }
        public ProviderDto Provider { get; set; } = null!;

        public int PublishingOfficeId { get; set; }
        public PublishingOfficeDto PublishingOffice { get; set; }

    }
}

