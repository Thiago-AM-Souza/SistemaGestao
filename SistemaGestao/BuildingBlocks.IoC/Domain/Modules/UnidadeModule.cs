using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Domain.Modules
{
    public static class UnidadeModule
    {
        public static IServiceCollection AddUnidadeModuleDependencyInjection(this IServiceCollection services)
        {
            return services;
        }
    }
}
