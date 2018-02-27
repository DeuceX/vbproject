using System.Collections.Generic;
using BLL.Dto;
using Microsoft.AspNetCore.Mvc;
using BLL.Services.Interfaces;

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
        public IEnumerable<CardDto> GetAll()
        {
            return cardService.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public CardDto Get(int id)
        {
            return cardService.GetById(id);
        }
    }
}
