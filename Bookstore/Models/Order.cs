using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public int EmployeeId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
    }
}
