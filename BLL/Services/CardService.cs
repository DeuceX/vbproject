using System.Collections.Generic;
using System.Linq;
using BLL.Dto;
using BLL.Services.Interfaces;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Card;

namespace BLL.Services
{
    public class CardService : ICardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(CardDto card)
        {
            var newCategory = AutoMapper.Mapper.Map<CardDto, Card>(card);
            _unitOfWork.CardRepository.Insert(newCategory);
            _unitOfWork.Commit();
        }

        public CardDto GetById(int id)
        {
            var card = _unitOfWork.CardRepository.GetById(id);
            return AutoMapper.Mapper.Map<Card, CardDto>(card);
        }

        public IEnumerable<CardDto> GetAll()
        {
            var cards = _unitOfWork.CardRepository.GetAll();
            return AutoMapper.Mapper.Map<IEnumerable<Card>, List<CardDto>>(cards);
        }


        public void Delete(int id)
        {
            //cardRepository.Delete(GetById(id));
        }

        public void Update(Card card)
        {
            //cardRepository.Update(card);
        }
    }
}
