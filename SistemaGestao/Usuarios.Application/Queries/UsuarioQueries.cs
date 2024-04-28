using Usuarios.Application.Queries.ViewModels;
using Usuarios.Domain;

namespace Usuarios.Application.Queries
{
    public class UsuarioQueries : IUsuarioQueries
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueries(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<UsuarioViewModel>> ObterTodosUsuarios(bool? desativado)
        {
            var usuarios = await _usuarioRepository.ObterTodosUsuarios(desativado);

            var usuariosView = usuarios
                                .Select(x =>
                                    new UsuarioViewModel(x.Login,
                                                         x.Desativado));

            return usuariosView;
        }
    }
}
