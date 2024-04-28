using BuildingBlocks.IoC.Application;
using BuildingBlocks.IoC.Domain;
using BuildingBlocks.IoC.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddGestaoDependencyInjection(this IServiceCollection services)
        {
            services.AddInfraDependencyInjection()
                    .AddDomainDependencyInjection()
                    .AddApplicationDependencyInjection();

            return services;
        }
    }
}
