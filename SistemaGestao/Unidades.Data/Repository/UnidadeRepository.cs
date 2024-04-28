using BuildingBlocks.Core.Data;
using Microsoft.EntityFrameworkCore;
using Unidades.Domain;

namespace Unidades.Data.Repository
{
    public class UnidadeRepository : IUnidadeRepository
    {
        private readonly UnidadeContext _context;
        public ISaveChanges SaveChanges => _context;

        public UnidadeRepository(UnidadeContext context)
        {
            _context = context;
        }

        public void AtualizarUnidade(Unidade unidade)
        {
            _context.Unidades.Update(unidade);
        }

        public async Task CadastrarUnidade(Unidade unidade)
        {
            await _context.Unidades.AddAsync(unidade);
        }        

        public async Task<Unidade> ObterUnidadePorId(Guid id)
        {
            return await _context.Unidades.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Unidade>> ObterUnidades()
        {
            return await _context.Unidades
                                    .Include(x => x.Colaboradores)
                                    .ToListAsync();
        }

        public async Task<Unidade> ObterUnidadePorCodigo(string codigo)
        {
            return await _context
                            .Unidades
                                .FirstOrDefaultAsync(x => x.Codigo == codigo);
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
