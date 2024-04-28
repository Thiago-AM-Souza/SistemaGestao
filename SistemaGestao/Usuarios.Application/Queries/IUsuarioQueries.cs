using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Application.Queries.ViewModels;

namespace Usuarios.Application.Queries
{
    public interface IUsuarioQueries
    {
        Task<IEnumerable<UsuarioViewModel>> ObterTodosUsuarios(bool? desativado);
    }
}
