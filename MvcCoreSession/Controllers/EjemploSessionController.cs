using Microsoft.AspNetCore.Mvc;

namespace MvcCoreSession.Controllers
{
    public class EjemploSessionController : Controller
    {
        int numero = 1;

        public IActionResult Index()
        {
            ViewData["NUMERO"] = "Valor del número: " + this.numero;
            return View();
        }

        public IActionResult SessionSimple(string accion)
        {
            this.numero += 1;
            ViewData["NUMERO"] = "Valor del número: " + this.numero;
            //if (accion.ToLower() == "almacenar")
            //{

            //}else if (accion.ToLower() == "mostrar")
            //{

            //}
            return View();
        }
    }
}
