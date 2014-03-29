using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TISelvagem.Aplicacao;
using TISelvagem.Dominio;

namespace TISelvagem.UI.Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoAplicacao appAluno;

        public AlunoController()
        {
            appAluno = AlunoAplicacaoConstrutor.AlunoAplicacaoADO();
        }

        public ActionResult Index()
        {
            var listaDeAlunos = appAluno.ListarTodos();
            return View(listaDeAlunos);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Editar(string id)
        {
            var aluno = appAluno.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                appAluno.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);  
        }

        public ActionResult Detalhes(string id)
        {
            var aluno = appAluno.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        public ActionResult Excluir(string id)
        {
            var aluno = appAluno.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            var aluno = appAluno.ListarPorId(id);
            appAluno.Excluir(aluno);
            return RedirectToAction("Index");
        }
    }
}
