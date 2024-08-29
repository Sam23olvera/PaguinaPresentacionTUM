using Microsoft.AspNetCore.Mvc;
using PaguinaPresentacion.Models;
using System.Diagnostics;

namespace PaguinaPresentacion.Controllers
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
        public IActionResult Contacto() 
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Nosotros() 
        {
            return View();
        }
        public IActionResult Servicios() 
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
