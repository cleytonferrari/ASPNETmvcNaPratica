using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploValidacao.Models;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            //exemplo para teste da validação do CPF 
            //ele manda o ID ou não!
            //so para teste, se o id for diferente de zero, o CPF é valido, casao contrario não é!
            pessoa.Id = 0;

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            /*if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome","O campo nome é obrigatório");
            }
            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("","As senhas não conferem");
            }*/

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
                {
                    "Cleyton",
                    "Anderson",
                    "Renata"
                };
            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValidarCpf(string cpf, int Id)
        {
            //aqui vai ficar sua regra de negocio
            //fiz uma validação simples, se tiver ID é valido, se não tiver não é!

            var retorno = (Id > 0);

            return Json(retorno, JsonRequestBehavior.AllowGet);
        }

    }
}
