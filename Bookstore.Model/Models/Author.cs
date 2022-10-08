using System;
namespace Bookstore.Model.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Patronymic { get; set; } = null!;

        public ICollection<Book> Books { get; set; }
    }
}

