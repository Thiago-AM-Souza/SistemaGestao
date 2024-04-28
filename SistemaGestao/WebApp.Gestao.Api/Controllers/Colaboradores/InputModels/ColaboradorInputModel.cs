namespace WebApp.Gestao.Api.Controllers.Colaboradores.InputModels
{
    public class ColaboradorInputModel
    {
        public string Nome { get; set; }
        public Guid UnidadeId { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
