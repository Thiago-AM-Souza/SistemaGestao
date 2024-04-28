using BuildingBlocks.Core.Data;
using Colaboradores.Domain;
using Microsoft.EntityFrameworkCore;

namespace Colaboradores.Data.Repository
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly ColaboradorContext _context;
        public ISaveChanges SaveChanges => _context;

        public ColaboradorRepository(ColaboradorContext context)
        {
            _context = context;
        }

        #region Colaborador
        public void AtualizarColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Update(colaborador);
        }

        public async Task CadastrarColaborador(Colaborador colaborador)
        {
            await _context.Colaboradores.AddAsync(colaborador);
        }

        public async Task<IEnumerable<Colaborador>> ObterColaboradores()
        {
            return await _context.Colaboradores
                                    .Include(x => x.Unidade)
                                    .ToListAsync();
        }

        public async Task<Colaborador> ObterColaboradorPorId(Guid id)
        {
            return await _context.Colaboradores
                                    .Include(x => x.Unidade)
                                    .FirstOrDefaultAsync(x => x.Id == id);
        }

        public void RemoverColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Remove(colaborador);
        }

        #endregion

        #region Usuario

        public async Task<Usuario> ObterUsuarioPorId(Guid usuarioId)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == usuarioId);
        }

        #endregion

        #region Unidade
        public async Task<Unidade> ObterUnidadePorId(Guid unidadeId)
        {
            return await _context.Unidades.FirstOrDefaultAsync(x => x.Id == unidadeId);            
        }

        #endregion

        public void Dispose()
        {
            _context?.Dispose();
        }        
    }
}
