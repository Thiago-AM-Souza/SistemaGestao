using BuildingBlocks.Core.Handler;

namespace Unidades.Application.Commands
{
    public class DesativarUnidadeCommand : Command
    {
        public Guid Id { get; private set; }

        public DesativarUnidadeCommand(Guid id)
        {
            Id = id;
        }
    }
}
