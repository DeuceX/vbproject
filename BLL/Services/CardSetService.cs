using System.Collections.Generic;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Card;

namespace BLL.Services
{
    public class CardSetService : ICardSetService
    {
        private ICardSetRepository cardSetRepository;

        public CardSetService(ICardSetRepository csRepository)
        {
            cardSetRepository = csRepository;
        }

        public IEnumerable<CardSet> GetAll()
        {
            return null;
            //return cardSetRepository.GetAll();
        }

        public CardSet GetById(int id)
        {
            return null;
            //return cardSetRepository.GetAll().FirstOrDefault(cs => cs.Id == id);
        }

        public void Delete(int id)
        {
            //cardSetRepository.Delete(GetById(id));
        }

        public void Update(CardSet card)
        {
            //cardSetRepository.Update(card);
        }
    }
}
