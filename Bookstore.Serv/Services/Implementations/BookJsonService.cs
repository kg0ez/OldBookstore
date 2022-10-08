using System;
using System.Text.Json;
using Bookstore.BusinessLogic.Services;
using Bookstore.Common.Dto;

namespace Bookstore.Serv.Services
{
    public class BookJsonService: IBookJsonService
    {
        private readonly IBookService _bookService;

        public BookJsonService(IBookService bookService)
        {
            _bookService = bookService;
        }

        public string Get()
        {
            var books = _bookService.Get();

            var response = JsonSerializer.Serialize<List<BookDto>>(books);

            return response;
        }
        
    }
}

