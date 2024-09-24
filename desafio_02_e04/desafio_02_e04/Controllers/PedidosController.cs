using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using desafio_02_e04.Models;

namespace desafio_02_e04.Controllers
{
    public class PedidosController : Controller
    {
        private db_temper_trapEntities db = new db_temper_trapEntities(); // Contexto de datos generado por EF

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

        [HttpPost]
        public ActionResult ActualizarEstado(int pedidoId, string estado, string comentario)
        {
            var pedido = db.Pedidos.SingleOrDefault(p => p.PedidoId == pedidoId);

            if (pedido != null)
            {
                pedido.Estado = estado;
                pedido.Comentario = comentario;

                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }




    }
}
