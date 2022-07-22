using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Storage
    {
        public int BookId { get; set; }
        public int Amount { get; set; }

        public virtual Book? Book { get; set; }
    }
}
