using System.Collections.Generic;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Services.Interfaces
{
    public interface ICardService
    {
        IEnumerable<CardDTO> GetAll();
        CardDTO GetById(int id);
        void Delete(int id);
        void Update(Card card);
    }
}
