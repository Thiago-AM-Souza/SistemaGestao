using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Usuarios.Application.Commands;
using Usuarios.Application.Commands.Handler;
using Usuarios.Application.Queries;

namespace BuildingBlocks.IoC.Application.Modules
{
    public static class UsuarioModule
    {
        public static IServiceCollection AddUsuarioModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<AtivarUsuarioCommand, bool>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarUsuarioCommand, bool>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<CadastrarUsuarioCommand, bool>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<DesativarUsuarioCommand, bool>, UsuarioCommandHandler>();
            
            services.AddScoped<IUsuarioQueries, UsuarioQueries>();

            return services;
        }
    }
}
