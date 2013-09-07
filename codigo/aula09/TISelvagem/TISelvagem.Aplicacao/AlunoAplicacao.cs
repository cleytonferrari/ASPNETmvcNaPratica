using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TISelvagem.Dominio;
using TiSelvagem.Repositorio;

namespace TISelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private readonly AlunoRepositorioADO repositorio;

        public AlunoAplicacao()
        {
            repositorio = new AlunoRepositorioADO();
        }

        public void Salvar(Aluno aluno)
        {
            repositorio.Salvar(aluno);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

        public List<Aluno> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Aluno ListarPorId(int id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
