using BuildingBlocks.Core.Handler;

namespace Unidades.Application.Commands
{
    public class CadastrarUnidadeCommand : Command
    {
        public string Codigo { get; private set; }
        public string Nome { get; private set; }

        public CadastrarUnidadeCommand(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
