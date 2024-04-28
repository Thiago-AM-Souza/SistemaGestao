using BuildingBlocks.Migrations;
using Colaboradores.Data;
using Microsoft.EntityFrameworkCore;
using Unidades.Data;
using Usuarios.Data;

namespace WebApp.Gestao.Api.Config
{
    public static class EFCoreExtension
    {
        public static IServiceCollection AddEFCoreService(this IServiceCollection services)
        {
            services.AddDbContext<MigrationContext>();

            services.AddScoped<IMigrationProvider, MigrationProvider>();

            services.AddScoped(provider =>
            {
                var migrationProvider = provider.GetService<IMigrationProvider>();

                var options = new DbContextOptionsBuilder<MigrationContext>();

                var connString = migrationProvider.GetConnectionString();

                options.UseNpgsql(connString);

                return new MigrationContext(options.Options);
            });

            services.AddScoped((provider) =>
            {
                var migrationProvider = provider.GetService<IMigrationProvider>();

                var connString = migrationProvider.GetConnectionString();

                var options = new DbContextOptionsBuilder<ColaboradorContext>();

                options.UseNpgsql(connString);

                return new ColaboradorContext(options);
            });

            services.AddScoped(provider =>
            {
                var migrationProvider = provider.GetService<IMigrationProvider>();

                var connString = migrationProvider.GetConnectionString();

                var options = new DbContextOptionsBuilder<UnidadeContext>();

                options.UseNpgsql(connString);

                return new UnidadeContext(options);
            });

            services.AddScoped(provider =>
            {
                var migrationProvider = provider.GetService<IMigrationProvider>();

                var connString = migrationProvider.GetConnectionString();

                var options = new DbContextOptionsBuilder<UsuarioContext>();

                options.UseNpgsql(connString);

                return new UsuarioContext(options);
            });

            return services;
        }
    }
}
