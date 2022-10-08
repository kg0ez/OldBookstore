using System;
using AutoMapper;
using Bookstore.Common.Dto;
using Bookstore.Model;
using Bookstore.Model.Models;

namespace Bookstore.BusinessLogic.Services
{
    public class WalletService : IWalletService
    {
        private readonly BookstoreContext _context;
        private readonly IMapper _mapper;

        public WalletService(BookstoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CreditCardDto> Get()
        {
            var cards = _context.CreditCards.ToList();

            var cardsDto = _mapper.Map<List<CreditCardDto>>(cards);

            return cardsDto;
        }

        public bool Add(CardDto cardDto)
        {
            var card = _mapper.Map<CreditCard>(cardDto);

            _context.CreditCards.Add(card);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var card = _context.CreditCards.FirstOrDefault(cc => cc.Id == id)!;

            _context.CreditCards.Remove(card);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}

