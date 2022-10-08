using System;
using Bookstore.Common.Dto;

namespace Bookstore.BusinessLogic.Services
{
    public interface IWalletService
    {
        List<CreditCardDto> Get();
        bool Add(CardDto cardDto);
        bool Delete(int Id);
    }
}

