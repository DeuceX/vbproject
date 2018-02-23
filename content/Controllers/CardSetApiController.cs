using System.Collections.Generic;
using BLL.Services.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CardSetController : Controller
    {
        private ICardSetService cardSetService;

        public CardSetController(ICardSetService csService)
        {
            cardSetService = csService;
        }

        [HttpGet("[action]")]
        public IEnumerable<CardSet> GetAll()
        {
            return cardSetService.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public CardSet Get(int id)
        {
            return cardSetService.GetById(id);
        }
    }
}
