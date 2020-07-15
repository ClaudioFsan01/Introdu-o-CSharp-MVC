using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            // Passando dados de controladores para modelos de exibição utilizando o dicionario ViewData e ViewModel

            ViewData["paragrafo1"] = "Utilizando o dicionario Viewdata";
            ViewData["paragrafo2"] = "Curso AspNet";
            return View();
            //O método do tipo ContentResult  cria um objeto 
        }

        /*
        public ActionResult Index()
        {
            return Content("Hello Word !");
            //O método do tipo ContentResult  cria um objeto 
        }*/

        public String Texto()
        {
            return "Usando texto";
        }

        public void ExecutaTexto()
        {
            Response.Write("Executando um texto !");
        }
    }
}

/* por default a rota utilizada configurada em  RouteConfig é  controller = "Home", action = "Index", id = UrlParameter.Optional
 Para que seja retornado à pagina HTML o texto da ação Texto() é necessario informar o endereço na URL com o nome do controller e a ação 


 O método Index acima usa um modelo de exibição para gerar uma resposta HTML para o navegador. 
 Os métodos do controlador (também conhecidos como métodos de ação), como o método Index acima, 
 geralmente retornam um ActionResult (ou uma classe derivada de ActionResult), não tipos primitivos como cadeia de caracteres.*/
