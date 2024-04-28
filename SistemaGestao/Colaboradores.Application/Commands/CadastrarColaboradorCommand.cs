using BuildingBlocks.Core.Handler;

namespace Colaboradores.Application.Commands
{
    public class CadastrarColaboradorCommand : Command
    {
        public string Nome { get; private set; }
        public Guid UnidadeId { get; private set; }
        public Guid UsuarioId { get; private set; }

        public CadastrarColaboradorCommand(string nome,
                                           Guid unidadeId,
                                           Guid usuarioId)
        {
            Nome = nome;
            UnidadeId = unidadeId;
            UsuarioId = usuarioId;
        }
    }
}
