using BuildingBlocks.IoC;

namespace WebApp.Gestao.Api.Config
{
    public static class DependecyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjectionService(this IServiceCollection services)
        {
            services.AddGestaoDependencyInjection();

            return services;
        }
    }
}
