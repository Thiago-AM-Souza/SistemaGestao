using BuildingBlocks.Core.DomainObjects;

namespace Usuarios.Domain
{
    public class Usuario : Entity, IAggregateRoot
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Desativado { get; private set; }

        protected Usuario() { }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public void Atualizar(string senha)
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
