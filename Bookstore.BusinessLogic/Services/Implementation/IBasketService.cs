using System;
using Bookstore.Common.Dto;

namespace Bookstore.BusinessLogic.Services
{
    public interface IBasketService
    {
        List<BasketDto> Get();
        bool Add(int bookId);
        bool Delete(int id);
    }
}

