using System;
using Bookstore.Models.Interface;

namespace Bookstore.Models.HelperClasses
{
	public class Operation:IDataOperation
	{
        BookstoreContext _db;

        public Operation(BookstoreContext context)
		{
            _db = context;
		}

        public void AddCreditCard(CreditCard card)
        {
            _db.CreditCards.Add(card);
            _db.SaveChanges();
        }
        public void AddItemBusket(Nullable<int> id)
        {
            if (id.HasValue)
            {
                Basket basket = new Basket() { BookId = id.Value };
                _db.Basket.Add(basket);
                _db.SaveChanges();
            }
        }
        public bool DeleteCard(CreditCard? card)
        {
            if (card != null)
            {
                _db.CreditCards.Remove(card);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteItemBusket(Nullable<int> id)
        {
            if (id.HasValue)
            {
                Basket? basket = _db.Basket.FirstOrDefault(x => x.Id == id);
                if (basket != null)
                {
                    _db.Basket.Remove(basket);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}

