using System;
using Bookstore.Common.Enums;
using Bookstore.Common.Serv;
using System.Text.Json;
using Bookstore.Serv.Services;

namespace Bookstore.Serv.Handler
{
    public static class HandlerType
    {
        public static string SearchType(
            ServerQuery query,
            IMethodService methodService)
        {

            if (query.Type == QueryType.Book)
            {
                var nameMethod = JsonSerializer.Deserialize<QueryBookType>(query.TypeAction);
                return methodService.Book(nameMethod, query.Object);
            }
            else if (query.Type == QueryType.CreditCard)
            {
                var nameMethod = JsonSerializer.Deserialize<QueryCreditCardType>(query.TypeAction);
                return methodService.Card(nameMethod, query.Object);
            }
            else if (query.Type == QueryType.Basket)
            {
                var nameMethod = JsonSerializer.Deserialize<QueryBasketType>(query.TypeAction);
                return methodService.Basket(nameMethod, query.Object);
            }

            throw new Exception("Type wasn`t found");
        }
    }
}

