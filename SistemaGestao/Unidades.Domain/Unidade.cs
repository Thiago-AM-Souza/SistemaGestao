namespace Unidades.Domain
{
    public class Unidade
    {        
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public bool Desativado { get; private set; }

        private List<Colaborador> _colaboradores;
        public IReadOnlyList<Colaborador> Colaboradores => _colaboradores;

        public Unidade(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            _colaboradores = new List<Colaborador>();
        }

        public void AtivarUnidade()
        {
            Desativado = false;
        }

        public void DesativarUnidade()
        {
            Desativado = true;
        }

        public void AdicionarColaborador(Colaborador colaborador)
        {
            if (!_colaboradores.Contains(colaborador))
                _colaboradores.Add(colaborador);
        }
    }
}
