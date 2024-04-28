using BuildingBlocks.Core.DomainObjects;

namespace BuildingBlocks.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        ISaveChanges SaveChanges { get; }
    }

    //public interface IRepository : IDisposable
    //{
    //    ISaveChanges SaveChanges { get; }
    //}
}
