using Microsoft.Extensions.DependencyInjection;
using Unidades.Data.Repository;
using Unidades.Domain;

namespace BuildingBlocks.IoC.Infra.Modules
{
    public static class UnidadeModule
    {
        public static IServiceCollection AddUnidadeModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnidadeRepository, UnidadeRepository>();

            return services;
        }
    }
}
