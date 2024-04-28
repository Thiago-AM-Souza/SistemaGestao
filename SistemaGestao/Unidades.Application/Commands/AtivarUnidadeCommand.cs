using BuildingBlocks.Core.Handler;

namespace Unidades.Application.Commands
{
    public class AtivarUnidadeCommand : Command
    {
        public Guid Id { get; private set; }

        public AtivarUnidadeCommand(Guid id)
        {
            Id = id;
        }
    }
}
