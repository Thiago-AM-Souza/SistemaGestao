namespace Colaboradores.Application.Queries.ViewModels
{
    public class ColaboradorViewModel
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public UnidadeViewModel Unidade { get; set; }

        public ColaboradorViewModel(string codigo, 
                                    string nome, 
                                    UnidadeViewModel unidade)
        {
            Codigo = codigo;
            Nome = nome;
            Unidade = unidade;
        }

        public class UnidadeViewModel
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public bool Desativado { get; set; }

            public UnidadeViewModel(string codigo, string nome, bool desativado)
            {
                Codigo = codigo;
                Nome = nome;
                Desativado = desativado;
            }
        }


    }
}
