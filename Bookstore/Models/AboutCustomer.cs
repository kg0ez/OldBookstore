using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class AboutCustomer
    {
        public int CustomerId { get; set; }
        public int? NumberPurchases { get; set; }
        public int? Discount { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
