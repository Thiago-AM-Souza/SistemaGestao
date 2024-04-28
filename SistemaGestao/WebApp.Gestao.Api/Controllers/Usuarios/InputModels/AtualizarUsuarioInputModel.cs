namespace WebApp.Gestao.Api.Controllers.Usuarios.InputModels
{
    public class AtualizarUsuarioInputModel
    {
        public Guid Id { get; private set; }
        public string Senha { get; set; }
    }
}
