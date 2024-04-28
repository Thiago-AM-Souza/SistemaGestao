using Unidades.Application.Queries.ViewModels;

namespace Unidades.Application.Queries
{
    public interface IUnidadeQueries
    {
        Task<IEnumerable<UnidadeViewModel>> ObterTodasUnidades();
    }
}