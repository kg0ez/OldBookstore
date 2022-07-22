using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class CostBook
    {
        public int BookId { get; set; }
        public int Price { get; set; }
        public int? CostDelivery { get; set; }
        public string? TimeDelivery { get; set; }

        public virtual Book? Book { get; set; }
    }
}
