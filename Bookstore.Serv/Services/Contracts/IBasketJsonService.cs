using System;
namespace Bookstore.Serv.Services
{
    public interface IBasketJsonService
    {
        string Get();
        string Add(int bookId);
        string Delete(int id);
    }
}

