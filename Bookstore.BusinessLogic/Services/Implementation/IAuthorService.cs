using System;
using Bookstore.Common.Dto;

namespace Bookstore.BusinessLogic.Services
{
    public interface IAuthorService
    {
        AuthorDto Get(int id);
    }
}

