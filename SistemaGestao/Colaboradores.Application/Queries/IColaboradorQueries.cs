using Colaboradores.Application.Queries.ViewModels;
using Colaboradores.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboradores.Application.Queries
{
    public interface IColaboradorQueries
    {
        Task<IEnumerable<ColaboradorViewModel>> ObterTodosColaboradores();
    }
}
