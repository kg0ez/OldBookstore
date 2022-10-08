using System;
using AutoMapper;
using Bookstore.Common.Dto;
using Bookstore.Model.Models;

namespace Bookstore.BusinessLogic.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutBook, AboutBookDto>().ReverseMap();
            CreateMap<CostBook, CostBookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Provider, ProviderDto>();
            CreateMap<PublishingOffice, PublishingOfficeDto>();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<CreditCard, CreditCardDto>().ReverseMap();
            CreateMap<CreditCard, CardDto>().ReverseMap();
            CreateMap<Basket, BasketDto>().ReverseMap();
        }
    }
}

