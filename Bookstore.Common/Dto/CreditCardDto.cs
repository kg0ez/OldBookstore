using System;
namespace Bookstore.Common.Dto
{
    public class CreditCardDto
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public string? ValidThru { get; set; }
        public string? CvvCvc { get; set; }
    }
}

