using BuildingBlocks.Core.Handler;

namespace Usuarios.Application.Commands
{
    public class AtivarUsuarioCommand : Command
    {
        public Guid Id { get; private set; }

        public AtivarUsuarioCommand(Guid id)
        {
            Id = id;
        }
    }
}
