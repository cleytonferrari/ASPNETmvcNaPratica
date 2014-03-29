using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "Preencha a observação")]
        public string Observacao { get; set; }

        [Range(18, 50, ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage = "Informe uma idade")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O Login deve ser preenchido")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Este nome de login já existe")]
        public string Login { get; set; }

        [Remote("ValidarCpf", "Pessoa", AdditionalFields = "Id", ErrorMessage = "Este CPF não é valido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnota   tions.Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}