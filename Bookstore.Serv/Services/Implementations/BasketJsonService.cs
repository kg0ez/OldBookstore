using System;
using System.Text.Json;
using Bookstore.BusinessLogic.Services;
using Bookstore.Common.Dto;

namespace Bookstore.Serv.Services
{
    public class BasketJsonService: IBasketJsonService
    {
        private readonly IBasketService _basketService;

        public BasketJsonService(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public string Add(int bookId)
        {
            var answer = _basketService.Add(bookId);

            var response = JsonSerializer.Serialize<bool>(answer);

            return response;
        }

        public string Delete(int id)
        {
            var answer = _basketService.Delete(id);

            var response = JsonSerializer.Serialize<bool>(answer);

            return response;
        }

        public string Get()
        {
            var books = _basketService.Get();

            var response = JsonSerializer.Serialize<List<BasketDto>>(books);

            return response;
        }
    }
}

