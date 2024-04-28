namespace Unidades.Application.Queries.ViewModels
{
    public class UnidadeViewModel
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public bool Desativado { get; set; }
        public List<ColaboradorViewModel> Colaboradores { get; set; } = new();

        public class ColaboradorViewModel
        {
            public string Nome { get; set; }
        }

        public UnidadeViewModel(string codigo,
                                string nome,
                                bool desativado,
                                List<ColaboradorViewModel> colaboradores)
        {
            Codigo = codigo;
            Nome = nome;
            Desativado = desativado;
            Colaboradores = colaboradores;
        }
    }
}
