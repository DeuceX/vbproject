using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CardService : ICardService
    {
        private IRepository<Card> cardRepository;

        public CardService(IRepository<Card> cardRepository)
        {
            this.cardRepository = cardRepository;
        }

        public IEnumerable<DAL.Entities.Card> GetAll()
        {
            /*Mapper.Initialize(cfg => cfg.CreateMap<Card, CardDTO>());
            return Mapper.Map<IEnumerable<Card>, List<CardDTO>>(cardRepository.GetAll());*/
            return cardRepository.GetAll();
        }

        public CardDTO GetById(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Card, CardDTO>());
            return Mapper.Map<Card, CardDTO>(cardRepository.GetAll().FirstOrDefault(c => c.Id == id));
        }

        public void Delete(int id)
        {
            cardRepository.Delete(cardRepository.GetAll().FirstOrDefault(c => c.Id == id));
        }

        public void Update(Card card)
        {
            cardRepository.Update(card);
        }
    }
}
