using System;
using AutoMapper;
using Bookstore.Common.Dto;
using Bookstore.Model;
using Bookstore.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.BusinessLogic.Services
{
    public class BasketService: IBasketService
    {
        private readonly BookstoreContext _context;
        private readonly IMapper _mapper;

        public BasketService(BookstoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Add(int bookId)
        {
            var basket = new Basket { BookId = bookId };

            _context.Basket.Add(basket);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var basket = _context.Basket.FirstOrDefault(b => b.Id == id)!;

            _context.Basket.Remove(basket);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public List<BasketDto> Get()
        {
            var basket = _context.Basket
                .Include(b=>b.Book)
                    .ThenInclude(b=>b.Author)
                .Include(b => b.Book)
                    .ThenInclude(b => b.CostBook)
                .AsNoTracking()
                .ToList();

            var basketDto = _mapper.Map<List<BasketDto>>(basket);

            return basketDto;
        }
    }
}

