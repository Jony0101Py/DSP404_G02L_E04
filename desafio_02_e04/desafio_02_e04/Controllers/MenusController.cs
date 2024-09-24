using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using desafio_02_e04;
using desafio_02_e04.Models;

namespace desafio_02_e04.Controllers
{
    public class MenusController : Controller
    {
        private db_temper_trapEntities db = new db_temper_trapEntities();

        // Vista principal del menú para clientes
        public ActionResult Index()
        {
            // Obtener todos los platos del menú desde la base de datos
            var menu = db.Menus.ToList();

            // Mapear los datos de Menus a MenuViewModel
            var menuViewModels = menu.Select(m => new MenuViewModel
            {
                MenuId = m.MenuId,
                NombrePlato = m.NombrePlato,
                Precio = m.Precio,
                Descripcion = m.Descripcion
            }).ToList();

            // Pasar la lista de MenuViewModel a la vista
            return View(menuViewModels);
        }

        // Acción para mostrar el carrito de compras
        public ActionResult Carrito()
        {
            // Obtener el carrito de la sesión
            var carrito = Session["Carrito"] as List<CarritoItem> ?? new List<CarritoItem>();

            // Pasar el carrito a la vista
            return View(carrito);
        }

        // Acción para agregar un ítem al carrito
        [HttpPost]
        public ActionResult AddToCart(int menuId, int quantity)
        {
            // Obtener el carrito de la sesión, si no existe, se crea uno nuevo
            var carrito = Session["Carrito"] as List<CarritoItem> ?? new List<CarritoItem>();

            // Verificar si el ítem ya está en el carrito
            var itemExistente = carrito.FirstOrDefault(i => i.MenuId == menuId);

            if (itemExistente != null)
            {
                // Si el ítem ya está en el carrito, aumentar la cantidad
                itemExistente.Cantidad += quantity;
            }
            else
            {
                // Si no está, buscar el plato en la base de datos
                var plato = db.Menus.Find(menuId);

                if (plato != null)
                {
                    // Añadir un nuevo ítem al carrito
                    carrito.Add(new CarritoItem
                    {
                        MenuId = plato.MenuId,
                        NombrePlato = plato.NombrePlato,
                        Precio = plato.Precio,
                        Cantidad = quantity
                    });
                }
                else
                {
                    // Si el plato no se encuentra, podrías agregar una lógica de manejo de errores aquí
                    TempData["Error"] = "Plato no encontrado.";
                }
            }

            // Guardar el carrito actualizado en la sesión
            Session["Carrito"] = carrito;

            // Redirigir al carrito
            return RedirectToAction("Carrito");
        }

        // Acción para eliminar un ítem del carrito
        [HttpPost]
        public ActionResult RemoveFromCart(int menuId)
        {
            // Obtener el carrito de la sesión
            var carrito = Session["Carrito"] as List<CarritoItem>;

            if (carrito != null)
            {
                // Buscar el ítem a eliminar
                var item = carrito.FirstOrDefault(i => i.MenuId == menuId);

                if (item != null)
                {
                    // Eliminar el ítem del carrito
                    carrito.Remove(item);

                    // Actualizar el carrito en la sesión
                    Session["Carrito"] = carrito;
                }
            }

            // Redirigir de nuevo al carrito
            return RedirectToAction("Carrito");
        }



    }
}
