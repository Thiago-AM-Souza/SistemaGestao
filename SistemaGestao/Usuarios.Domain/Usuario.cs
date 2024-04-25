using BuildingBlocks.Core.DomainObjects;

namespace Usuarios.Domain
{
    public class Usuario : Entity
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
