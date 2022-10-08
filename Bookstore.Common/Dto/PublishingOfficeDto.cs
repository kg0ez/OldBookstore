using System;
namespace Bookstore.Common.Dto
{
    public class PublishingOfficeDto
    {
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;

        //public ICollection<BookDto> Books { get; set; }
    }
}

