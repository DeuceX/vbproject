using Autofac;
using BLL.Services;
using BLL.Services.Interfaces;

namespace Web.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CardService>().As<ICardService>();
            builder.RegisterType<CardSetService>().As<ICardSetService>();
        }
    }
}
