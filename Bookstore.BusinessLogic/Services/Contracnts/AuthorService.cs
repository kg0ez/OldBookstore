using System;
using AutoMapper;
using Bookstore.Common.Dto;
using Bookstore.Model;

namespace Bookstore.BusinessLogic.Services
{
    public class AuthorService: IAuthorService
    {
        private readonly BookstoreContext _context;
        private readonly IMapper _mapper;

        public AuthorService(BookstoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AuthorDto Get(int id)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Id == id)!;

            var authorDto = _mapper.Map<AuthorDto>(author);

            return authorDto;
        }
    }
}

