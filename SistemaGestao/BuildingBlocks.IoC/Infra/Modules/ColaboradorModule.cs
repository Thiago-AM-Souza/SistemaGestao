using Colaboradores.Data.Repository;
using Colaboradores.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Infra.Modules
{
    public static class ColaboradorModule
    {
        public static IServiceCollection AddColaboradorModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();

            return services;
        }
    }
}
