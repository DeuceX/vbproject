using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BLL.Services.Interfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private ICardService cardService;

        private List<Card> cards = new List<Card>
        {
            new Card("Name 1", "Description 1", 1, false, ""),
            new Card("Name 2", "Description 2", 2, true, "That was awesome!", "https://vignette4.wikia.nocookie.net/force-of-will-tcg/images/1/10/Illusory_Projection.png/revision/latest?cb=20161021211403"),
            new Card("Name 3", "Description 3", 3, true, "Cool!!!", "https://orig00.deviantart.net/f930/f/2013/212/f/1/toon_sand_stone_yugioh_card_by_tim1995-d6fz6d3.jpg"),
            new Card("Name 4", "Description 4", 4, false, "", "http://d12h0em1d7ppg.cloudfront.net/content/fcards/1487150281.jpg")
        };

        public CardController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Card> GetAll()
        {
            var testCards = cardService.GetAll();
            return cards;
        }

        [HttpGet("[action]/{id}")]
        public Card Get(int id)
        {
            return cards.FirstOrDefault(c => c.Id == id);
        }

        public class Card
        {
            public Card() { }

            public Card(string name, string description,
                int id, bool isCompleted, string comment,
                string imageUrl = "http://www.mypokecard.com/my/galery/EU0MG9rpCngP.jpg")
            {
                Name = name;
                Description = description;
                ImageUrl = imageUrl;
                Id = id;
                IsCompleted = isCompleted;
                Comment = comment;
            }

            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
            public int Id { get; set; }
            public bool IsCompleted { get; set; }
            public string Comment { get; set; }
        }
    }
}
