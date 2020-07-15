using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpty.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Texto()
        {
            return Content("Curso Nery Controlador Curso !");
        }

        public ActionResult Excluir(int id)
        {
            return Content("Excluir cliente id :" + id);
        }


        
    }
}