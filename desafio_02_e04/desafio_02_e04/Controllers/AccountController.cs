// - comentado por: sc231259

using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using desafio_02_e04.Models;

namespace desafio_02_e04.Controllers
{
    public class AccountController : Controller
    {
        private db_temper_trapEntities db = new db_temper_trapEntities(); // Contexto de datos generado por EF (entity framework)

        // Vista de Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVIewModel model)
        {
            // Verificar si el modelo es válido
            if (ModelState.IsValid)
            {
                // Lógica para autenticar al usuario
                var cliente = db.Clientes.SingleOrDefault(c => c.Usuario == model.Usuario && c.Password == model.Password);
                var empleado = db.Empleados.SingleOrDefault(e => e.Usuario == model.Usuario && e.Password == model.Password);

                if (cliente != null)
                {
                    // Autenticar cliente
                    FormsAuthentication.SetAuthCookie(model.Usuario, false);
                    return RedirectToAction("Index", "Menus"); // Redirige a la vista del menú para clientes
                }
                if (empleado != null)
                {
                    // Autenticar empleado
                    FormsAuthentication.SetAuthCookie(model.Usuario, false);
                    return RedirectToAction("Index", "Pedidos"); // Redirige a la vista de pedidos para empleados
                }

                // Si no se encontró el usuario, agrega un mensaje de error
                ViewBag.ErrorMessage = "Usuario o contraseña inválidos.";
            }

            // Si llegamos aquí, hubo un error; devuelve la vista con el modelo
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
