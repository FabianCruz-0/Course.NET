using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PrimerRazorPage.Controllers
{
    public class primerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult segundaAccion()
        {
            List<string> peliculas = new List<string>()
            {
                "V de Venganza", "El jajas", "Lobezno"
            };
            return View(peliculas);
        }






        public string Bienvenida()
        {
            return "Esta es la accion de bienvenida";
        }
    }
}