using Classificados.Models;
using Classificados.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classificados.Controllers
{
    public class ClassificadoController : Controller
    {
        public ActionResult Index()
        {
            using (Conexao db = new Conexao())
            {
               var model = db.Classificados.ToList();

                return View(model.Select(m => new ClassificadosViewModel()
                {
                    Id = m.Id,
                    Titulo = m.Titulo,
                    Descricao = m.Descricao,
                    Data = m.Data,
                }));
            }
        }

        public ActionResult Cadastrar() 
        {
            if (TempData["mensagemSucesso"] != null)
            {
                ViewBag.mensagemSucesso = TempData["mensagemSucesso"];
            }
            return View();
        }

        public ActionResult _Create(ClassificadosViewModel dados) 
        {
            Models.Classificados model = new Models.Classificados();
            model.Titulo = dados.Titulo;
            model.Descricao = dados.Descricao;
            model.Data = DateTime.Now.Date;

            using (Conexao db = new Conexao())
            {
                db.Classificados.Add(model);
                db.SaveChanges();
            }
            TempData["mensagemSucesso"] = "Item cadastrado com sucesso";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult _Delete(int id)
        {
            using (Conexao db = new Conexao())
            {
                Models.Classificados model = db.Classificados.First(c => c.Id == id);
                db.Classificados.Remove(model);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}