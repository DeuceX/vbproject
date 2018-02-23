using System.Collections.Generic;
using System.Linq;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services
{
    public class CardService : ICardService
    {
        private IRepository<Card> cardRepository;

        public CardService(IRepository<Card> cardRepository)
        {
            this.cardRepository = cardRepository;
        }

        public IEnumerable<Card> GetAll()
        {
            return cardRepository.GetAll();
        }

        public Card GetById(int id)
        {
            return cardRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public void Delete(int id)
        {
            cardRepository.Delete(GetById(id));
        }

        public void Update(Card card)
        {
            cardRepository.Update(card);
        }
    }
}
