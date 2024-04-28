using BuildingBlocks.IoC.Application.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Application
{
    public static class DomainDependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddColaboradorModuleDependencyInjection()
                    .AddUnidadeModuleDependencyInjection()
                    .AddUsuarioModuleDependencyInjection();

            return services;
        }
    }
}
