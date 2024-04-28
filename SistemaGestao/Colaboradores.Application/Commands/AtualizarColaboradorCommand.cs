using BuildingBlocks.Core.Handler;

namespace Colaboradores.Application.Commands
{
    public class AtualizarColaboradorCommand : Command
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Guid UnidadeId { get; private set; }

        public AtualizarColaboradorCommand(Guid id,
                                           string nome,
                                           Guid unidadeId)
        {
            Id = id;
            Nome = nome;
            UnidadeId = unidadeId;
        }
    }
}
