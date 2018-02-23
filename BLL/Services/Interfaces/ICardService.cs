using System.Collections.Generic;
using DAL.Entities;

namespace BLL.Services.Interfaces
{
    public interface ICardService
    {
        IEnumerable<Card> GetAll();
        Card GetById(int id);
        void Delete(int id);
        void Update(Card card);
    }
}
