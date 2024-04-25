using BuildingBlocks.Core.DomainObjects;

namespace Unidades.Domain
{
    public class Colaborador : Entity
    {
        public string Nome { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid UnidadeId { get; set; }

        // public Usuario Usuario { get; set; }
        public Unidade Unidade { get; set; }
    }
}