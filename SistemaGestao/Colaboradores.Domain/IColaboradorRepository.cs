using BuildingBlocks.Core.Data;

namespace Colaboradores.Domain
{
    public interface IColaboradorRepository : IRepository<Colaborador>
    {
        #region Colaborador
        Task CadastrarColaborador(Colaborador colaborador);
        void AtualizarColaborador(Colaborador colaborador);
        Task<IEnumerable<Colaborador>> ObterColaboradores();
        Task<Colaborador> ObterColaboradorPorId(Guid id);
        void RemoverColaborador(Colaborador colaborador);
        #endregion

        #region Usuario
        Task<Usuario> ObterUsuarioPorId(Guid usuarioId);
        #endregion

        #region Unidade
        Task<Unidade> ObterUnidadePorId(Guid unidadeId);
        #endregion
    }
}
