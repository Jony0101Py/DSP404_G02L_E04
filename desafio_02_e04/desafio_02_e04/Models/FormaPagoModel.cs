using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace desafio_02_e04.Models
{
    public class FormaPagoModel
    {
        public int FormaPagoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Metodo { get; set; }  // Ejemplo: 'Tarjeta', 'Efectivo'

        [Required]
        public int PedidoId { get; set; }
    }
}
