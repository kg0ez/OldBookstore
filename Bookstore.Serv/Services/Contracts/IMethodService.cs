using System;
using Bookstore.Common.Enums;

namespace Bookstore.Serv.Services
{
    public interface IMethodService
    {
        string Book(QueryBookType query, string obj);
        string Card(QueryCreditCardType query, string obj);
        string Basket(QueryBasketType query, string obj);
    }
}

