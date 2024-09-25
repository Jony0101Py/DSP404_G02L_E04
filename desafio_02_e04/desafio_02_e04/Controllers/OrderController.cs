//- comentado por: sc231259

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using desafio_02_e04.Models;

namespace desafio_02_e04.Controllers
{
    public class OrderController : Controller
    {
        private db_temper_trapEntities db = new db_temper_trapEntities();  // Conexión a la base de datos

        // Acción para mostrar la página de Checkout
        public ActionResult Checkout()
        {
            var carrito = Session["Carrito"] as List<CarritoItem>;

            if (carrito == null || carrito.Count == 0)
            {
                return RedirectToAction("Index", "Menus");  // Redirigir si el carrito está vacío
            }

            ViewBag.FormasPago = new SelectList(new List<string> { "Tarjeta", "Efectivo" });
            return View(carrito);
        }

        // Acción para procesar el pedido y forma de pago
        [HttpPost]
        public ActionResult ProcessCheckout(string metodoPago)
        {
            var carrito = Session["Carrito"] as List<CarritoItem>;
            if (carrito == null || carrito.Count == 0)
            {
                return RedirectToAction("Index", "Menus");
            }

            // Obtener el ID del cliente desde la sesión o base de datos
            int clienteId = 1;  // Suponiendo que el cliente esté logueado y su ID es 1

            // Crear un nuevo pedido
            var pedido = new Pedidos
            {
                ClienteId = clienteId,
                Estado = "Aceptado",  
                FechaPedido = DateTime.Now,
                Comentario = "Pedido realizado con éxito"
            };

            // Guardar el pedido en la base de datos
            db.Pedidos.Add(pedido);
            db.SaveChanges();

            // Registrar la forma de pago
            var formaPago = new FormasPago
            {
                Metodo = metodoPago,
                PedidoId = pedido.PedidoId
            };

            db.FormasPago.Add(formaPago);
            db.SaveChanges();

            // Guardar los detalles del pedido
            foreach (var item in carrito)
            {
                var detallePedido = new DetallesPedidos
                {
                    PedidoId = pedido.PedidoId,
                    MenuId = item.MenuId,
                    Cantidad = item.Cantidad,
                    Precio = item.Precio
                };

                db.DetallesPedidos.Add(detallePedido);
            }

            db.SaveChanges();

            // Vaciar el carrito después de la compra
            Session["Carrito"] = null;

            return RedirectToAction("Confirmacion");
        }

        // Acción para mostrar la página de éxito del pedido
        public ActionResult Confirmacion()
        {

            // Obtener el último pedido y su forma de pago
            var ultimoPedido = db.Pedidos.OrderByDescending(p => p.PedidoId).FirstOrDefault();
            if (ultimoPedido != null)
            {
                var formaPago = db.FormasPago.FirstOrDefault(fp => fp.PedidoId == ultimoPedido.PedidoId);
                ViewBag.MetodoPago = formaPago?.Metodo;

                // Calcular el total del pedido
                var total = db.DetallesPedidos
                    .Where(dp => dp.PedidoId == ultimoPedido.PedidoId)
                    .Sum(dp => dp.Cantidad * dp.Precio);
                ViewBag.Total = total.ToString("C");

                // Obtener el nombre del cliente
                var cliente = db.Clientes.FirstOrDefault(c => c.ClienteId == ultimoPedido.ClienteId);
                ViewBag.NombreCliente = cliente?.Nombre;
            }

            return View();
        }
    }
}
