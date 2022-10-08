using System;
using Bookstore.Common.Dto;

namespace Bookstore.Serv.Services
{
    public interface ICreditCardJsonService
    {
        string Get();
        string Add(CardDto cardDto);
        string Delete(int id);
    }
}

