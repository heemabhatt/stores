using Autofac;
using Store.Data.Repositories.Interfaces;
using Store.Data.Repositories;
using Store.Data.Contexts;
using Store.Data.Contexts.Interfaces;

namespace Store.Infrastructure.Ioc
{
    /// <summary>
    /// IOC Module for the project.
    /// </summary>
    public class DataModule
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<StoreContext>().As<IStoreContext>();
            builder.RegisterType<RestaurantRepository>().As<IRestaurantRepository>();
        }
    }
}
