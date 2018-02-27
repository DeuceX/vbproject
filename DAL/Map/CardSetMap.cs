using DAL.Map.Interfaces;
using Domain.Card;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Map
{
    public class CardSetMap : IMapping<CardSet>
    {
        public void MapEntity(EntityTypeBuilder<CardSet> builder)
        {
            builder.ToTable("CardSet", "dbo");

            builder.HasKey(cs => cs.Id);
        }
    }
}
