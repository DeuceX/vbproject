using System.Collections.Generic;

namespace DAL.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Type { get; set; }
    }
}
