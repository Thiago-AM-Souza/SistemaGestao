namespace BuildingBlocks.Core.Handler
{
    public interface IMediatorHandler
    {
        Task<bool> SendCommand<T>(T command) where T : Command;
    }
}
