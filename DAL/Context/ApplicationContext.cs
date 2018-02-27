using Domain.Card;
using DAL.Map;
using Domain.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<CardSet> CardSets { get; set; }
        public DbSet<User> TUsers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CardMap().MapEntity(modelBuilder.Entity<Card>());
            new CardSetMap().MapEntity(modelBuilder.Entity<CardSet>());
        }

    }

}
