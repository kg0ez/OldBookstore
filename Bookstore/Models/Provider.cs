﻿using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}