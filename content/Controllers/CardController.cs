using System.Collections.Generic;
using System.Linq;
using BLL.Dto;
using Microsoft.AspNetCore.Mvc;
using BLL.Services.Interfaces;
using DAL.Entities;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private ICardService cardService;

        public CardController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Card> GetAll()
        {
            return cardService.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public Card Get(int id)
        {
            return cardService.GetById(id);
        }
    }
}
