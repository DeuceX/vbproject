using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Map
{
    class CardSetMap
    {
        public CardSetMap(EntityTypeBuilder<CardSet> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Price).IsRequired();
        }
    }
}
