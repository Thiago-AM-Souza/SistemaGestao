using BuildingBlocks.Core.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Application.Commands
{
    public class CadastrarUsuarioCommand : Command
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public CadastrarUsuarioCommand(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}
