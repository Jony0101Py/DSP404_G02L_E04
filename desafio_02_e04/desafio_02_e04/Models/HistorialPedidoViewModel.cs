using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desafio_02_e04.Models
{
    public class HistorialPedidoViewModel
    {
        public int PedidoId { get; set; }
        public string ClienteNombre { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; }
        public string ComentarioEmpleado { get; set; }
        public List<DetallePedidoViewModel> Detalles { get; set; }
    }
}