using AutoMapper;
using BLL.Dto;
using Domain.Card;

namespace BLL.Map
{
    public class CardMapperProfile : Profile
    {
        public CardMapperProfile()
        {
            CreateMap<CardDto, Card>();

            CreateMap<Card, CardDto>();
        }
    }
}
