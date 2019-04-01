using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class SalvarController : Controller
    {
        // GET: Salvar
        public ActionResult Index(string dados)
        {
            ViewBag.Dados = dados;
            return View("Formulario");
        }
    }
}