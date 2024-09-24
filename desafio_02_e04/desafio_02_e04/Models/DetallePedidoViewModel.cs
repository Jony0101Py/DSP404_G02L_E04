using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desafio_02_e04.Models
{
    public class DetallePedidoViewModel
    {
        public string NombrePlato { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}