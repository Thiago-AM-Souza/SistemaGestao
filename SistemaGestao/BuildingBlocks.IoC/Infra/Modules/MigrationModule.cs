using BuildingBlocks.Migrations;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Infra.Modules
{
    public static class MigrationModule
    {
        public static IServiceCollection AddMigrationModuleDependecyInjection(this IServiceCollection services)
        {
            services.AddScoped<IMigrationProvider, MigrationProvider>();

            return services;
        }
    }
}
