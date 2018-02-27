using System.Collections.Generic;
using Domain.Card;

namespace BLL.Services.Interfaces
{
    public interface ICardSetService
    {
        IEnumerable<CardSet> GetAll();
        CardSet GetById(int id);
        void Delete(int id);
        void Update(CardSet card);
    }
}
