using Microsoft.Extensions.DependencyInjection;
using Usuarios.Data.Repositories;
using Usuarios.Domain;

namespace BuildingBlocks.IoC.Infra.Modules
{
    public static class UsuarioModule
    {
        public static IServiceCollection AddUsuarioModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
