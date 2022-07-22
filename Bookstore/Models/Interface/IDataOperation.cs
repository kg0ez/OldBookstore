using System;
namespace Bookstore.Models.Interface
{
	public interface IDataOperation
	{
        bool DeleteCard(CreditCard? card);
        void AddCreditCard(CreditCard card);
        void AddItemBusket(Nullable<int> id);
        bool DeleteItemBusket(Nullable<int> id);
    }
}

