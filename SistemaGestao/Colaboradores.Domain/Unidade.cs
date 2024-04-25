using BuildingBlocks.Core.DomainObjects;

namespace Colaboradores.Domain
{
    public class Unidade : Entity
    {
        public string Nome { get; private set; }
        public bool Desativado { get; private set; }
        public List<Colaborador> Colaboradores { get; private set; }

        protected Unidade() 
        {
            Colaboradores = new List<Colaborador>();
        }

        public Unidade(string nome)
        {
            Nome = nome;
            Colaboradores = new List<Colaborador>();
        }
    }
}
