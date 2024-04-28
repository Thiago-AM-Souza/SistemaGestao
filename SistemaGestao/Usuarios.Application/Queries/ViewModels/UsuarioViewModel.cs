using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Application.Queries.ViewModels
{
    public class UsuarioViewModel
    {        
        public string Login { get; private set; }
        public bool Status { get; private set; }
        public UsuarioViewModel(string login, bool status)
        {
            Login = login;
            Status = status;
        }

    }
}
