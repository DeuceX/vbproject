﻿using Microsoft.EntityFrameworkCore;
using DAL.Entities;

namespace DAL.EF
{
    public class CardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        
        public CardContext(DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public class StoreDbInitializer
        {
            protected void Seed(CardContext db)
            {
                db.Cards.Add(new Card { Id = 1, Name = "Card 1", Description = "Card 1 description "});
                db.Cards.Add(new Card { Id = 2, Name = "Card 2", Description = "Card 2 description " });
                db.Cards.Add(new Card { Id = 3, Name = "Card 3", Description = "Card 3 description " });
                db.Cards.Add(new Card { Id = 4, Name = "Card 4", Description = "Card 4 description " });
                db.Cards.Add(new Card { Id = 5, Name = "Card 5", Description = "Card 5 description " });
                db.SaveChanges();
            }
        }
    }
}
