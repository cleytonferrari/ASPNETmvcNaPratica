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
        private Contexto contexto;

        private void Inserir(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " INSERT INTO ALUNO (Nome, Mae, DataNascimento) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}') ",
                aluno.Nome, aluno.Mae, aluno.DataNascimento
                );
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " UPDATE ALUNO SET ";
            strQuery += string.Format(" Nome = '{0}', ", aluno.Nome);
            strQuery += string.Format(" Mae = '{0}', ", aluno.Mae);
            strQuery += string.Format(" DataNascimento = '{0}' ", aluno.DataNascimento);
            strQuery += string.Format(" WHERE AlunoId = {0} ", aluno.Id);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.Id > 0)
                Alterar(aluno);
            else
                Inserir(aluno);
        }

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" DELETE FROM ALUNO WHERE AlunoId = {0}", id);
                contexto.ExecutaComando(strQuery);
            }
        }

        public List<Aluno> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = " SELECT * FROM ALUNO ";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        public Aluno ListarPorId(int id)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" SELECT * FROM ALUNO WHERE AlunoId = {0} ", id);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader).FirstOrDefault();
            }
        }

        private List<Aluno> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var alunos = new List<Aluno>();
            while (reader.Read())
            {
                var temObjeto = new Aluno()
                                    {
                                        Id = int.Parse(reader["AlunoId"].ToString()),
                                        Nome = reader["Nome"].ToString(),
                                        Mae = reader["Mae"].ToString(),
                                        DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                                    };
                alunos.Add(temObjeto);
            }
            reader.Close();
            return alunos;
        }
    }
}
