using Domain.Card;

namespace BLL.Dto
{
    public class CardDto
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
