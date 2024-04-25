using BuildingBlocks.Core.DomainObjects;

namespace Colaboradores.Domain
{
    public class Usuario : Entity
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Desativado { get; private set; }

        public Usuario(string login,
                       string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}
