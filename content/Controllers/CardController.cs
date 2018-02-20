using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private List<Card> cards = new List<Card>
        {
            new Card("Name 1", "Description 1", 1),
            new Card("Name 2", "Description 2", 2, "https://vignette4.wikia.nocookie.net/force-of-will-tcg/images/1/10/Illusory_Projection.png/revision/latest?cb=20161021211403"),
            new Card("Name 3", "Description 3", 3, "https://orig00.deviantart.net/f930/f/2013/212/f/1/toon_sand_stone_yugioh_card_by_tim1995-d6fz6d3.jpg"),
            new Card("Name 4", "Description 4", 4, "http://d12h0em1d7ppg.cloudfront.net/content/fcards/1487150281.jpg")
        };

        [HttpGet("[action]")]
        public IEnumerable<Card> GetAll()
        {
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
                int id, string imageUrl = "http://www.mypokecard.com/my/galery/EU0MG9rpCngP.jpg")
            {
                Name = name;
                Description = description;
                ImageUrl = imageUrl;
                Id = id;
            }

            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
            public int Id { get; set; }
        }
    }
}
