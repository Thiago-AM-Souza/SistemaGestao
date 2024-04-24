using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Domain
{
    public class Usuario
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Desativado { get; private set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public void AtualizarUsuario(string senha)
        {
            Senha = senha;
        }

        public void AtivarUsuario()
        {
            Desativado = false;
        }

        public void DesativarUsuario()
        {
            Desativado = true;
        }
    }
}
