using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Map
{
    public class CardMap
    {
        public CardMap(EntityTypeBuilder<Card> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.CardSetId).IsRequired();
            entityBuilder.Property(t => t.Name).IsRequired();
        }
    }
}
