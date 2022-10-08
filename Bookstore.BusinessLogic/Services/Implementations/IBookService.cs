using System;
using Bookstore.Common.Dto;

namespace Bookstore.BusinessLogic.Services
{
    public interface IBookService
    {
        void Sync();
        List<BookDto> Get();
    }
}

