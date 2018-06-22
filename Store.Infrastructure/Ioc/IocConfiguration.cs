using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Infrastructure.Ioc
{
    /// <summary>
    /// Configuration for the IOC Container
    /// </summary>
    public class IocConfiguration
    {
        private ContainerBuilder _containerBuilder;

        public IocConfiguration()
        {
            _containerBuilder = new ContainerBuilder();
        }

        /// <summary>
        /// Builds the IOC Container.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <returns></returns>
        public IContainer BuildContainer(IServiceCollection serviceCollection)
        {
            RegisterModules();
            _containerBuilder.Populate(serviceCollection);
            return _containerBuilder.Build();
        }

        /// <summary>
        /// Register the IOC Modules.
        /// </summary>
        private void RegisterModules()
        {
            CoreModule.RegisterTypes(_containerBuilder);
            DataModule.RegisterTypes(_containerBuilder);
        }
    }
}
