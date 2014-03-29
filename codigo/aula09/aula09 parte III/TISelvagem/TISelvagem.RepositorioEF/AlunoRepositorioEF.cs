using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TISelvagem.Dominio;
using TISelvagem.Dominio.contrato;

namespace TISelvagem.RepositorioEF
{
    public class AlunoRepositorioEF: IRepositorio<Aluno>
    {

        private readonly Contexto contexto;

        public AlunoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Aluno entidade)
        {
            if (entidade.Id > 0)
            {
                var alunoAlterar = contexto.Alunos.First(x => x.Id == entidade.Id);
                alunoAlterar.Nome = entidade.Nome;
                alunoAlterar.Mae = entidade.Mae;
                alunoAlterar.DataNascimento = entidade.DataNascimento;
            }
            else
            {
                contexto.Alunos.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Aluno entidade)
        {
            var alunoExcluir = contexto.Alunos.First(x => x.Id == entidade.Id);
            contexto.Set<Aluno>().Remove(alunoExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return contexto.Alunos;
        }

        public Aluno ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Alunos.First(x => x.Id == idInt);
        }
    }
}
