using desafio_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desafio_03.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly TurnoverContext _context;

        public UsuarioController(TurnoverContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(string nombre, string contraseña)
        {          
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Nombre == nombre && u.Contraseña == contraseña);

            if (usuario != null)
            {            
                HttpContext.Session.SetInt32("UsuarioId", usuario.UsuarioId);
                HttpContext.Session.SetString("Nombre", usuario.Nombre);
                HttpContext.Session.SetString("Rol", usuario.Rol);

                // Redirigir según el rol del usuario
                if (usuario.Rol == "Administrador")
                {
                    return RedirectToAction("AdminPage", "Home"); // Redirigir a la página del administrador
                }
                else
                {
                    return RedirectToAction("ClientePage", "Home"); // Redirigir a la página del cliente
                }
            }
        
            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View();
        }

        // registro
        public IActionResult Registro()
        {
            return View();
        }
   
        [HttpPost]
        public IActionResult Registro(Usuario nuevoUsuario)
        {           
            if (_context.Usuarios.Any(u => u.Nombre == nuevoUsuario.Nombre))
            {
                ViewBag.Error = "El nombre de usuario ya está en uso.";
                return View();
            }

            // Asignar rol cliente predeterminado si no se ha proporcionado
            if (string.IsNullOrEmpty(nuevoUsuario.Rol))
            {
                nuevoUsuario.Rol = "Cliente"; 
            }
       
            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();
          
            HttpContext.Session.SetInt32("UsuarioId", nuevoUsuario.UsuarioId);
            HttpContext.Session.SetString("Nombre", nuevoUsuario.Nombre);
            HttpContext.Session.SetString("Rol", nuevoUsuario.Rol); 

            // Redirigir al usuario a la página correspondiente según su rol
            if (nuevoUsuario.Rol == "Administrador")
            {
                return RedirectToAction("AdminPage", "Home");
            }
            else
            {
                return RedirectToAction("ClientePage", "Home");
            }
        }

        // Acción para cerrar sesión
        public IActionResult Logout()
        {         
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
