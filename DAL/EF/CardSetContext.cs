using Microsoft.EntityFrameworkCore;
using DAL.Entities;

namespace DAL.EF
{
    public class CardSetContext : DbContext
    {
        public DbSet<CardSet> CardSets { get; set; }

        static CardSetContext()
        {
        }
        public CardSetContext(string connectionString)
            : base()
        {
        }

        public class StoreDbInitializer
        {
            protected void Seed(CardSetContext db)
            {
                db.CardSets.Add(new CardSet { Id = 1, Name = "Card Set 1", Price = 100 });
                db.CardSets.Add(new CardSet { Id = 2, Name = "Card Set 2", Price = 250 });
                db.SaveChanges();
            }
        }
    }
}
