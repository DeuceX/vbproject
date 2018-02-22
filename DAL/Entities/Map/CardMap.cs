using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Entities.Map
{
    class CardMap
    {
        public CardMap(EntityTypeBuilder<Card> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Description).IsRequired();
        }

    }
}
