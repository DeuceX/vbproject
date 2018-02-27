using Autofac;
using DAL.Context;
using DAL.Repositories;
using DAL.Repositories.Interfaces;

namespace Web.Modules
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ApplicationContext>()
                .As<ApplicationContext>()
                .InstancePerLifetimeScope();


            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().PropertiesAutowired();
            builder.RegisterType<CardRepository>().As<ICardRepository>();
            builder.RegisterType<CardSetRepository>().As<ICardSetRepository>();
        }
    }
}
