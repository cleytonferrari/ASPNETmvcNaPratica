using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TISelvagem.Aplicacao;
using TISelvagem.Dominio;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            var appAluno = new AlunoAplicacao();

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome da mãe do aluno: ");
            string mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            string data = Console.ReadLine();

            var aluno1 = new Aluno
                            {
                                Nome = nome,
                                Mae = mae,
                                DataNascimento = DateTime.Parse(data)
                            };

            appAluno.Salvar(aluno1);

            var dados = appAluno.ListarTodos();

            foreach (var aluno in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, DataNascimento:{3}", aluno.Id, aluno.Nome, aluno.Mae, aluno.DataNascimento);
            }
        }
    }
}
