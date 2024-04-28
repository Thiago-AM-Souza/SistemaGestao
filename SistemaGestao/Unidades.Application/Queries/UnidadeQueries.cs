using Unidades.Application.Queries.ViewModels;
using Unidades.Domain;

namespace Unidades.Application.Queries
{
    public class UnidadeQueries : IUnidadeQueries
    {
        private readonly IUnidadeRepository _unidadeRepository;

        public UnidadeQueries(IUnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }

        public async Task<IEnumerable<UnidadeViewModel>> ObterTodasUnidades()
        {
            var unidades = await _unidadeRepository.ObterUnidades();

            var unidadesView = unidades.Select(x =>
                                            new UnidadeViewModel(
                                                x.Codigo,
                                                x.Nome,
                                                x.Desativado,
                                                x.Colaboradores.Select(c =>
                                                new UnidadeViewModel.ColaboradorViewModel
                                                {
                                                    Nome = c.Nome
                                                })
                                                .ToList()));

            return unidadesView;
        }
    }
}
