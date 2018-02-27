using System.Collections.Generic;
using BLL.Dto;
using Domain.Card;

namespace BLL.Services.Interfaces
{
    public interface ICardService
    {
        IEnumerable<CardDto> GetAll();
        CardDto GetById(int id);
        void Delete(int id);
        void Update(Card card);
        void Add(CardDto card);
    }
}
