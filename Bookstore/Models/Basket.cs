using System;
namespace Bookstore.Models
{
	public class Basket
	{
		public int Id { get; set; }
		public int BookId { get; set; }

		public virtual Book? Book { get; set; }
	}
}

