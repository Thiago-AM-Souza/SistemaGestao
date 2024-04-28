using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Unidades.Application.Commands;
using Unidades.Application.Commands.Handler;
using Unidades.Application.Queries;

namespace BuildingBlocks.IoC.Application.Modules
{
    public static class UnidadeModule
    {
        public static IServiceCollection AddUnidadeModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<AtivarUnidadeCommand, bool>, UnidadeCommandHandler>();
            services.AddScoped<IRequestHandler<DesativarUnidadeCommand, bool>, UnidadeCommandHandler>();            
            services.AddScoped<IRequestHandler<CadastrarUnidadeCommand, bool>, UnidadeCommandHandler>();

            services.AddScoped<IUnidadeQueries, UnidadeQueries>();

            return services;
        }
    }
}
