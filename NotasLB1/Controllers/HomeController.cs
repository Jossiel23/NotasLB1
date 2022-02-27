using Microsoft.AspNetCore.Mvc;
using NotasLB1.Bussines;
using NotasLB1.Models;
using System.Diagnostics;

namespace NotasLB1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Notas(Notas notas)
        {

            Promedio nm = new Promedio();
            String respuestas = nm.NombreCompleto(notas);
            ViewBag.Nombre = respuestas;



            Promedio pr = new Promedio();
            Double respuesta = pr.Promedios(notas);
            ViewBag.Respuestanota = respuesta;


            return View();
        }
    }
}