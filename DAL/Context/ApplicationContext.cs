using Domain.Card;
using DAL.Map;
using Domain.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationContext : IdentityDbContext<Customer>
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<CardSet> CardSets { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CardMap().MapEntity(modelBuilder.Entity<Card>());
            new CardSetMap().MapEntity(modelBuilder.Entity<CardSet>());
            new CustomerMap().MapEntity(modelBuilder.Entity<Customer>());
        }
    }

}
