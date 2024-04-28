using BuildingBlocks.Core.Data;

namespace Usuarios.Domain
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task CadastrarUsuario(Usuario usuario);
        Task<IEnumerable<Usuario>> ObterTodosUsuarios(bool? desativado);
        Task<Usuario> ObterUsuarioPorId(Guid id);
        void AtualizarUsuario(Usuario usuario);
    }
}
