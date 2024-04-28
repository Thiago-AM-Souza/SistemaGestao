using BuildingBlocks.Core.Handler;

namespace Usuarios.Application.Commands
{
    public class AtualizarUsuarioCommand : Command
    {
        public Guid Id { get; private set; }
        public string Senha { get; private set; }

        public AtualizarUsuarioCommand(Guid id, string senha)
        {
            Id = id;
            Senha = senha;
        }
    }
}
