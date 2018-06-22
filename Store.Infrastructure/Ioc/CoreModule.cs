using Autofac;
using Store.Data.Repositories;
using Store.Data.Repositories.Interfaces;

namespace Store.Infrastructure.Ioc
{
    /// <summary>
    /// IOC Module for the project.
    /// </summary>
    public class CoreModule
    {
        /// <summary>
        /// Registers types with the IOC Container.
        /// </summary>
        /// <param name="builder"></param>
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<RestaurantRepository>().As<IRestaurantRepository>(); 
        }
    }
}
