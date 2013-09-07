using System;
using System.ComponentModel;

namespace TISelvagem.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        [DisplayName("Mâe")]
        public string Mae { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
