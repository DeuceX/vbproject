using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BLL.Services.Interfaces;
using DAL.Entities;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CardApiController : Controller
    {
        private ICardService cardService;

        public CardApiController(ICardService cardService)
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
