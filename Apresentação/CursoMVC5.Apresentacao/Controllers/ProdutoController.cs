using CursoMVC5.Persistencia;
using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC5.Apresentacao.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Categoria> ListarCategorias()
        {
         
            List<Categoria> categorias = null;
            using (var ctx = new Contexto())
            {
                categorias = ctx.Categorias.ToList();

            }
            return categorias;
        }

        public ActionResult Index()
        {
            List<Produto> produtos = null;
         
            using (var ctx = new Contexto())
            {
                produtos = ctx.Produtos.ToList();             

            }         
            return View(produtos);

        }

        public ActionResult Create()
        {

            ViewBag.Categorias = ListarCategorias();
            return View();

        }


        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)

            {
                using (var ctx = new Contexto())
                {
                    ctx.Produtos.Add(produto);
                    ctx.SaveChanges();
                }
                    
             return View("Detail",produto);
            }
            else
            {
                ViewBag.Categorias = ListarCategorias();
                return View("Create");
            }
        }
    }    
  
}