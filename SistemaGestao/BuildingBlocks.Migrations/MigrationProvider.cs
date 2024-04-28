using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BuildingBlocks.Migrations
{
    public class MigrationProvider : IMigrationProvider
    {
        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(@"appsettings.json");

            var teste = Directory.GetCurrentDirectory();

            var configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("DbConnection");

            return connectionString;
        }
    }
}
