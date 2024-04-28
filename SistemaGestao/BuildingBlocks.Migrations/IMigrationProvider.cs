namespace BuildingBlocks.Migrations
{
    public interface IMigrationProvider
    {
        string GetConnectionString();
    }
}