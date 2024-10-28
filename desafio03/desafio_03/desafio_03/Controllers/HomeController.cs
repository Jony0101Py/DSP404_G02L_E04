using desafio_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace desafio_03.Controllers
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

        public IActionResult AdminPage()
        {
            
            if (HttpContext.Session.GetString("Rol") != "Administrador")
            {
                return RedirectToAction("Login", "Usuario"); 
            }
            
            var nombreUsuario = HttpContext.Session.GetString("Nombre");

            ViewBag.NombreUsuario = nombreUsuario;

            return View(); //vista para administradores
        }

        public IActionResult ClientePage()
        {
            if (HttpContext.Session.GetString("Rol") != "Cliente")
            {
                return RedirectToAction("Login", "Usuario"); // vista login si no es cliente
            }

            var nombreUsuario = HttpContext.Session.GetString("Nombre");

            ViewBag.NombreUsuario = nombreUsuario;

            return View(); //vista para clientes
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
