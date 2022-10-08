using System;
using System.Text.Json;
using Bookstore.Common.Dto;
using Bookstore.Common.Enums;
using Bookstore.Common.Serv;

namespace Bookstore.Serv.Services
{
    public class MethodService: IMethodService
    {
        private readonly IBookJsonService _bookJsonService;
        private readonly ICreditCardJsonService _creditCardJsonService;
        private readonly IBasketJsonService _basketJsonService;

        public MethodService(
            IBookJsonService bookJsonService,
            ICreditCardJsonService creditCardJsonService,
            IBasketJsonService basketJsonService)
        {
            _bookJsonService = bookJsonService;
            _creditCardJsonService = creditCardJsonService;
            _basketJsonService = basketJsonService;
        }

        public string Basket(QueryBasketType query, string obj)
        {
            if (query == QueryBasketType.Get)
            {
                return _basketJsonService.Get();
            }
            else if (query == QueryBasketType.Add)
            {
                var bookId = JsonSerializer.Deserialize<int>(obj);
                return _basketJsonService.Add(bookId);
            }
            else if (query == QueryBasketType.Delete)
            {
                var id = JsonSerializer.Deserialize<int>(obj);
                return _basketJsonService.Delete(id);
            }
            throw new Exception("--");
        }

        public string Book(QueryBookType query, string obj)
        {
            if (query == QueryBookType.GetBooks)
            {
                return _bookJsonService.Get();
            }
            throw new Exception("--");
        }
        public string Card(QueryCreditCardType query, string obj)
        {
            if (query == QueryCreditCardType.Get)
            {
                return _creditCardJsonService.Get();
            }
            else if (query == QueryCreditCardType.Add)
            {
                var card = JsonSerializer.Deserialize<CardDto>(obj);
                return _creditCardJsonService.Add(card);
            }
            else if (query == QueryCreditCardType.Delete)
            {
                var id = JsonSerializer.Deserialize<int>(obj);
                return _creditCardJsonService.Delete(id);
            }
            throw new Exception("--");
        }
    }
}

