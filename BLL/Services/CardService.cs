using System.Collections.Generic;
using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CardService : ICardService
    {
        private IUnitOfWork Database { get; set; }

        public CardService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CardDTO> GetAll()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Card, CardDTO>());
            return Mapper.Map<IEnumerable<Card>, List<CardDTO>>(Database.Cards.GetAll());
        }

        public CardDTO GetById(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Card, CardDTO>());
            return Mapper.Map<Card, CardDTO>(Database.Cards.Get(id));
        }

        public void Delete(int id)
        {
            Database.Cards.Delete(id);
        }

        public void Update(Card card)
        {
            Database.Cards.Update(card);
        }
    }
}
