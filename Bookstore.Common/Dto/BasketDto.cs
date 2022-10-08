using System;
namespace Bookstore.Common.Dto
{
    public class BasketDto
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public BookDto Book { get; set; }
    }
}

