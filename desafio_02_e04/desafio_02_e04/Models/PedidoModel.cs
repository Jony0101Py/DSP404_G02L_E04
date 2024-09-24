using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace desafio_02_e04.Models
{
    public class PedidoModel
    {
        public int PedidoId { get; set; }

        [Required]
        public int ClienteId { get; set; }

        public int? EmpleadoId { get; set; }

        [Required]
        public DateTime FechaPedido { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }  // Ejemplo: 'Aceptado', 'En proceso de elaboración', etc.

        [StringLength(255)]
        public string Comentario { get; set; }
    }
}
