using Newtonsoft.Json;

namespace Domain.Card
{
    [JsonObject(IsReference = true)]
    public class Card
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public virtual CardSet CardSet { get; set; }
    }
}
