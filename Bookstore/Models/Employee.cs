using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string Position { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
