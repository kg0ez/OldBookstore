using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class AddressСustomer
    {
        public int CustomerId { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Home { get; set; }
        public string? Apartment { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
