using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboradores.Domain
{
    public class Colaborador
    {
        public string Nome { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid UnidadeId { get; private set; }

        public Usuario Usuario { get; private set; }
        public Unidade Unidade { get; private set; }

        public Colaborador(string nome, Usuario usuario, Unidade unidade)
        {
            Nome = nome;
            Usuario = usuario;
            Unidade = unidade;
            //UsuarioId = usuario.Id;
            //UnidadeId = unidade.Id;
        }
    }
}
