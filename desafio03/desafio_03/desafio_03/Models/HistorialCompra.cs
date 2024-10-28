using System;
using System.Collections.Generic;

namespace desafio_03.Models
{
    public partial class HistorialCompra
    {
        public int HistorialId { get; set; }
        public int UsuarioId { get; set; }
        public int EntradaId { get; set; }
        public DateTime FechaCompra { get; set; }

        public virtual Entrada Entrada { get; set; } = null!;
        public virtual Usuario Usuario { get; set; } = null!;
    }
}
