using Autofac;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Web.Modules
{
    public class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(CreateDbContextOptions).As<DbContextOptions<ApplicationContext>>();
        }

        private static DbContextOptions<ApplicationContext> CreateDbContextOptions(IComponentContext context)
        {
            var configuration = context.Resolve<IConfiguration>();
            string connectionString = configuration["ConnectionStrings:LocalDb"];

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);

            using (var dbContext = new ApplicationContext(dbContextOptionsBuilder.Options))
            {
                dbContext.Database.EnsureCreated();
            }

            return dbContextOptionsBuilder.Options;
        }

    }
}
