using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Domain.Modules
{
    public static class ColaboradorModule
    {
        public static IServiceCollection AddColaboradorModuleDependencyInjection(this IServiceCollection services)
        {
            return services;
        }
    }
}
