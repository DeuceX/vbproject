using DAL.Entities;
using DAL.Entities.Map;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<CardSet> CardSets { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CardMap(modelBuilder.Entity<Card>());
            new CardSetMap(modelBuilder.Entity<CardSet>());
        }

    }

}
