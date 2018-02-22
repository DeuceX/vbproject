using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DAL.Entities;

namespace DAL.EF
{
    public class CardSetContext : DbContext
    {
        public DbSet<CardSet> CardSets { get; set; }

        static CardSetContext()
        {
            Database.SetInitializer<CardSetContext>(new StoreDbInitializer());
        }
        public CardSetContext(string connectionString)
            : base(connectionString)
        {
        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<CardSetContext>
        {
            protected override void Seed(CardSetContext db)
            {
                db.CardSets.Add(new CardSet { Id = 1, Name = "Card Set 1", Price = 100 });
                db.CardSets.Add(new CardSet { Id = 2, Name = "Card Set 2", Price = 250 });
                db.SaveChanges();
            }
        }
    }
}
