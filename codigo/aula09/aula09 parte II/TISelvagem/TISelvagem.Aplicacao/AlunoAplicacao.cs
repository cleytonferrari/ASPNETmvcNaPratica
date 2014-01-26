using System.Collections.Generic;
using TISelvagem.Dominio;
using TISelvagem.Dominio.contrato;

namespace TISelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private readonly IRepositorio<Aluno> repositorio;

        public AlunoAplicacao(IRepositorio<Aluno> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Aluno aluno)
        {
            repositorio.Salvar(aluno);
        }

        public void Excluir(Aluno aluno)
        {
            repositorio.Excluir(aluno);
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Aluno ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
