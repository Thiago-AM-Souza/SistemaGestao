using BuildingBlocks.IoC.Infra.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Infra
{
    public static class InfraDependencyInjection
    {
        public static IServiceCollection AddInfraDependencyInjection(this IServiceCollection services)
        {
            services.AddColaboradorModuleDependencyInjection()
                    .AddUnidadeModuleDependencyInjection()
                    .AddUsuarioModuleDependencyInjection()
                    .AddMigrationModuleDependecyInjection();

            return services;
        }
    }
}
