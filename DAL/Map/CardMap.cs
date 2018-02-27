using DAL.Map.Interfaces;
using Domain.Card;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Map
{
    public class CardMap : IMapping<Card>
    {
        public void MapEntity(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Card", "dbo");

            builder.HasKey(c => c.Id);
        }
    }
}
