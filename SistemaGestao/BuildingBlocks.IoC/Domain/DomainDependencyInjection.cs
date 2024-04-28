using BuildingBlocks.Core.Handler;
using BuildingBlocks.IoC.Domain.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Domain
{
    public static class DomainDependencyInjection
    {
        public static IServiceCollection AddDomainDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatorDependencyInjection()
                    .AddColaboradorModuleDependencyInjection()
                    .AddUnidadeModuleDependencyInjection()
                    .AddUsuarioModuleDependencyInjection();

            return services;
        }

        public static IServiceCollection AddMediatorDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            return services;
        }
    }
}
