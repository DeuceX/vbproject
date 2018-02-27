using System.Collections.Generic;
using Domain.Card;

namespace DAL.Repositories.Interfaces
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetAll();
        Card GetById(int id);
        void Delete(Card card);
        void Update(Card card);
        void Insert(Card card);
    }
}
