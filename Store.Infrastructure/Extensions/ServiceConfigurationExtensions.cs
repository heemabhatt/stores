using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Store.Infrastructure.Ioc;
using System;

namespace Store.Infrastructure.Extensions
{
    public static class ServiceConfigurationExtensions
    {
        /// <summary>
        /// Adds the IOC Container to the specified.
        /// <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"></see>
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceProvider AddIocContainer(this IServiceCollection services)
        {
            var containerBuilder = new IocConfiguration();
            var container = containerBuilder.BuildContainer(services);
            return container.Resolve<IServiceProvider>();
        }
    }
}
