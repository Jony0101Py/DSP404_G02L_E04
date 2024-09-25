// - comentado por: sc231259

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using desafio_02_e04.Models;

namespace desafio_02_e04.Controllers
{
    public class PedidosController : Controller
    {
        private db_temper_trapEntities db = new db_temper_trapEntities(); // Contexto de datos generado por EF (entity framework)

        // Vista de la lista de pedidos
        public ActionResult Index()
        {
            // Obtener todos los pedidos
            var pedidos = db.Pedidos.ToList();

            // Obtener todos los clientes y menús
            var clientes = db.Clientes.ToList();
            var menus = db.Menus.ToList();

            // Construir la lista de pedidos con detalles
            var pedidosViewModel = new List<PedidoViewModel>();

            foreach (var pedido in pedidos)
            {
                var cliente = clientes.SingleOrDefault(c => c.ClienteId == pedido.ClienteId);
                var detalles = db.DetallesPedidos
                    .Where(d => d.PedidoId == pedido.PedidoId)
                    .ToList();

                // Construir la lista de detalles del pedido
                var detallesViewModel = detalles.Select(d => new DetallePedidoViewModel
                {
                    NombrePlato = menus.FirstOrDefault(m => m.MenuId == d.MenuId)?.NombrePlato,
                    Cantidad = d.Cantidad,
                    Precio = d.Precio
                }).ToList();

                pedidosViewModel.Add(new PedidoViewModel
                {
                    PedidoId = pedido.PedidoId,
                    ClienteNombre = cliente?.Nombre,
                    FechaPedido = pedido.FechaPedido,
                    Estado = pedido.Estado,
                    Comentario = pedido.Comentario,
                    Detalles = detallesViewModel
                });
            }

            return View(pedidosViewModel);
        }

        // Acción para actualizar el estado y comentario del pedido
        [HttpPost]
        public ActionResult ActualizarEstado(int pedidoId, string estado, string comentario)
        {
            var pedido = db.Pedidos.SingleOrDefault(p => p.PedidoId == pedidoId);

            if (pedido != null)
            {
                pedido.Estado = estado;
                pedido.Comentario = comentario;

                db.SaveChanges();

                // Enviar mensaje de confirmación usando TempData
                TempData["MensajeConfirmacion"] = "El estado y/o comentario del pedido se han actualizado correctamente.";
            }

            return RedirectToAction("Index");
        }

        // Acción para ver el historial de pedidos
        public ActionResult Historial()
        {
            // Obtener todos los pedidos
            var pedidos = db.Pedidos.ToList();

            // Obtener todos los clientes, empleados y menús
            var clientes = db.Clientes.ToList();
            var empleados = db.Empleados.ToList();
            var menus = db.Menus.ToList();

            // Construir la lista de pedidos con detalles y comentarios de empleados
            var historialViewModel = new List<HistorialPedidoViewModel>();

            foreach (var pedido in pedidos)
            {
                var cliente = clientes.SingleOrDefault(c => c.ClienteId == pedido.ClienteId);
                var empleado = empleados.SingleOrDefault(e => e.EmpleadoId == pedido.EmpleadoId);
                var detalles = db.DetallesPedidos
                    .Where(d => d.PedidoId == pedido.PedidoId)
                    .ToList();

                // Construir la lista de detalles del pedido
                var detallesViewModel = detalles.Select(d => new DetallePedidoViewModel
                {
                    NombrePlato = menus.FirstOrDefault(m => m.MenuId == d.MenuId)?.NombrePlato,
                    Cantidad = d.Cantidad,
                    Precio = d.Precio
                }).ToList();

                historialViewModel.Add(new HistorialPedidoViewModel
                {
                    PedidoId = pedido.PedidoId,
                    ClienteNombre = cliente?.Nombre,
                    FechaPedido = pedido.FechaPedido,
                    Estado = pedido.Estado,
                    ComentarioEmpleado = pedido.Comentario, // Comentario del empleado
                    Detalles = detallesViewModel
                });
            }

            return View(historialViewModel);
        }
    }
}
