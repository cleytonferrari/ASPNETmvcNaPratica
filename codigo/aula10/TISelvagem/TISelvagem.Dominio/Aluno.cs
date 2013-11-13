using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o nome do aluno")]
        public string Nome { get; set; }
        
        [DisplayName("Mâe")]
        [Required(ErrorMessage = "Preencha o nome da mãe do aluno")]
        public string Mae { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Preencha a data de nascimento do aluno")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
    }
}
