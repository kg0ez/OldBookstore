using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public partial class CreditCard
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? Number { get; set; }
        public string? ValidThru { get; set; }
        public string? CvvCvc { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
