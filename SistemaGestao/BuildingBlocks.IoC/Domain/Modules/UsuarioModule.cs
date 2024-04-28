using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Domain.Modules
{
    public static class UsuarioModule
    {
        public static IServiceCollection AddUsuarioModuleDependencyInjection(this IServiceCollection services)
        {
            return services;
        }
    }
}
