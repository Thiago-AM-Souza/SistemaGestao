using Colaboradores.Application.Queries.ViewModels;
using Colaboradores.Data.Repository;
using Colaboradores.Domain;

namespace Colaboradores.Application.Queries
{
    public class ColaboradorQueries : IColaboradorQueries
    {
        private readonly ColaboradorRepository _colaboradorRepository;

        public ColaboradorQueries(ColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public async Task<IEnumerable<ColaboradorViewModel>> ObterTodosColaboradores()
        {
            var colaboradores = await _colaboradorRepository.ObterColaboradores();

            var colabView = colaboradores.Select(x => 
                                            new ColaboradorViewModel(
                                                x.Id.ToString(),
                                                x.Nome,
                                                new ColaboradorViewModel.UnidadeViewModel(
                                                    x.Unidade.Codigo,
                                                    x.Unidade.Nome,
                                                    x.Unidade.Desativado)));

            return colabView;
        }
    }
}
