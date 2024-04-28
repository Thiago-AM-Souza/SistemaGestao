using BuildingBlocks.Core.Data;
using Microsoft.EntityFrameworkCore;
using Usuarios.Domain;

namespace Usuarios.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;
        public ISaveChanges SaveChanges => _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios(bool? desativado)
        {
            return await _context.Usuarios
                                 .Where(x => x.Desativado == desativado)
                                 .ToListAsync();
        }

        public async Task<Usuario> ObterUsuarioPorId(Guid id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
