using MediatR;
using Usuarios.Application.Queries.ViewModels;
using Usuarios.Domain;

namespace Usuarios.Application.Commands.Handler
{
    public class UsuarioCommandHandler : IRequestHandler<CadastrarUsuarioCommand, bool>,
                                         IRequestHandler<AtualizarUsuarioCommand, bool>,
                                         IRequestHandler<AtivarUsuarioCommand, bool>,
                                         IRequestHandler<DesativarUsuarioCommand, bool>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<bool> Handle(CadastrarUsuarioCommand command, CancellationToken cancellationToken)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Login) ||
                    string.IsNullOrEmpty(command.Senha)) {
                    return false;
                }

                var usuario = new Usuario(command.Login,
                                          command.Senha);

                await _usuarioRepository.CadastrarUsuario(usuario);

                await _usuarioRepository.SaveChanges.Commit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> Handle(AtualizarUsuarioCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var usuario = await _usuarioRepository.ObterUsuarioPorId(command.Id);

                if (usuario == null || string.IsNullOrEmpty(command.Senha))
                {
                    return false;
                }

                usuario.Atualizar(command.Senha);

                _usuarioRepository.AtualizarUsuario(usuario);

                await _usuarioRepository.SaveChanges.Commit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Handle(AtivarUsuarioCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var usuario = await _usuarioRepository.ObterUsuarioPorId(command.Id);

                if (usuario == null)
                {
                    return false;
                }

                usuario.AtivarUsuario();

                _usuarioRepository.AtualizarUsuario(usuario);

                await _usuarioRepository.SaveChanges.Commit();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Handle(DesativarUsuarioCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var usuario = await _usuarioRepository.ObterUsuarioPorId(command.Id);

                if (usuario == null)
                {
                    return false;
                }

                usuario.DesativarUsuario();

                _usuarioRepository.AtualizarUsuario(usuario);

                await _usuarioRepository.SaveChanges.Commit();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
