using System;
namespace Bookstore.Common.Dto
{
    public class ProviderDto
    {
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;

        //public ICollection<BookDto> Books { get; set; }
    }
}

