using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SCAF_3b.Models;

namespace SCAF_3b.Controllers
{
    public class HomeController : Controller
    {

        // pagina principal en index
        public IActionResult Index()
        {
            return View();
        }

        // pagina de padres 
        public IActionResult Padres()
        {
            return View();
        }

        //retornar pagina de alumnos
        public IActionResult Alumnos()
        {
            return View();
        }

        // retornar pagina de eventos
        public IActionResult Eventos()
        {
            return View();
        }

        // pagina de asistencias
        public IActionResult Asistencias()
        {
            return View();
        }

        // pagina no necesaria
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
