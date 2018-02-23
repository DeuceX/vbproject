using System.Collections.Generic;
using System.Linq;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace BLL.Services
{
    public class CardSetService : ICardSetService
    {
        private IRepository<CardSet> cardSetRepository;

        public CardSetService(IRepository<CardSet> csRepository)
        {
            cardSetRepository = csRepository;
        }

        public IEnumerable<CardSet> GetAll()
        {
            return cardSetRepository.GetAll();
        }

        public CardSet GetById(int id)
        {
            return cardSetRepository.GetAll().FirstOrDefault(cs => cs.Id == id);
        }

        public void Delete(int id)
        {
            cardSetRepository.Delete(GetById(id));
        }

        public void Update(CardSet card)
        {
            cardSetRepository.Update(card);
        }
    }
}
