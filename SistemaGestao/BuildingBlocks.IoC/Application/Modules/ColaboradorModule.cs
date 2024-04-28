using Colaboradores.Application.Commands;
using Colaboradores.Application.Commands.Handler;
using Colaboradores.Application.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.IoC.Application.Modules
{
    public static class ColaboradorModule
    {
        public static IServiceCollection AddColaboradorModuleDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CadastrarColaboradorCommand, bool>, ColaboradorCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarColaboradorCommand, bool>, ColaboradorCommandHandler>();
            services.AddScoped<IRequestHandler<RemoverColaboradorCommand, bool>, ColaboradorCommandHandler>();

            services.AddScoped<IColaboradorQueries, ColaboradorQueries>();

            return services;
        }
    }
}
