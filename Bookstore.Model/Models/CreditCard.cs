using System;
namespace Bookstore.Model.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        public string? Number { get; set; }
        public string? ValidThru { get; set; }
        public string? CvvCvc { get; set; }
    }
}

