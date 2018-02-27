using Newtonsoft.Json;

namespace Domain.Card
{
    [JsonObject(IsReference = true)]
    public class CardSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
