using BuildingBlocks.Core.DomainObjects;

namespace Colaboradores.Domain
{
    public class Unidade : Entity
    {
        public string Nome { get; private set; }
        public string Codigo { get; private set; }
        public bool Desativado { get; private set; }
        public List<Colaborador> Colaboradores { get; private set; }

        protected Unidade() 
        {
            Colaboradores = new List<Colaborador>();
        }

        public Unidade(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
            Colaboradores = new List<Colaborador>();
        }
    }
}
