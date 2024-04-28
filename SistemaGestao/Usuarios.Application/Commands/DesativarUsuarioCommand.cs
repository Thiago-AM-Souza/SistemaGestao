using BuildingBlocks.Core.Handler;

namespace Usuarios.Application.Commands
{
    public class DesativarUsuarioCommand : Command
    {
        public Guid Id { get; private set; }

        public DesativarUsuarioCommand(Guid id)
        {
            Id = id;
        }
    }
}
