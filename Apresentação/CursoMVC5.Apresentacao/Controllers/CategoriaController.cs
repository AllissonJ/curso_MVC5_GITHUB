using CursoMVC5.Persistencia;
using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC5.Apresentacao.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var ListaCategorias = new List<Categoria>();
            using (var ctx = new Contexto())
            {
                ListaCategorias = ctx.Categorias.ToList();
            }

            return View(ListaCategorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {

            if (ModelState.IsValid)

            {
                using (var ctx = new Contexto())
                {
                    ctx.Categorias.Add(categoria);
                    ctx.SaveChanges();
                }

                return View("Detail", categoria);
            }
            else
            {
                return View("Create");
            }

        }

    }
}