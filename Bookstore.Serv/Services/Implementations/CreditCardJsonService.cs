using System;
using System.Text.Json;
using Bookstore.BusinessLogic.Services;
using Bookstore.Common.Dto;

namespace Bookstore.Serv.Services
{
    public class CreditCardJsonService : ICreditCardJsonService
    {
        private readonly IWalletService _walletService;

        public CreditCardJsonService(IWalletService walletService)
        {
            _walletService = walletService;
        }

        public string Add(CardDto cardDto)
        {
            var answer = _walletService.Add(cardDto);

            var response = JsonSerializer.Serialize<bool>(answer);

            return response;
        }
        public string Delete(int id)
        {
            var answer = _walletService.Delete(id);

            var response = JsonSerializer.Serialize<bool>(answer);

            return response;
        }

        public string Get()
        {
            var cards = _walletService.Get();

            var response = JsonSerializer.Serialize<List<CreditCardDto>>(cards);

            return response;
        }
    }
}

