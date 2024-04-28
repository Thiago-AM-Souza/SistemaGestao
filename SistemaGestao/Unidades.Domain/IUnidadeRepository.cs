using BuildingBlocks.Core.Data;

namespace Unidades.Domain
{
    public interface IUnidadeRepository : IRepository<Unidade>
    {
        Task CadastrarUnidade(Unidade unidade);
        void AtualizarUnidade(Unidade unidade);
        Task<IEnumerable<Unidade>> ObterUnidades();
        Task<Unidade> ObterUnidadePorId(Guid id);
        Task<Unidade> ObterUnidadePorCodigo(string codigo);        
    }
}
