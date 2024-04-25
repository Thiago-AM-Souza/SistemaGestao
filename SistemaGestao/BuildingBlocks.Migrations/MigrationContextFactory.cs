using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BuildingBlocks.Migrations
{
    public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationContext>
    {
        public MigrationContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(@"appsettings.json");

            var configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<MigrationContext>();

            var connectionString = configuration.GetConnectionString("DbConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new MigrationContext(optionsBuilder.Options);
        }
    }
}
