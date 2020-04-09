using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int resultado = Calculadora.Sumar("10", "1000");

            ViewBag.resultado = resultado;
            return View();
        }

        public ActionResult Duplicar(int id)
        {
            int duplicado = id * 2;

            ViewBag.input1 = id;
            ViewBag.resultado = duplicado;
            return View();
        }
    }
}