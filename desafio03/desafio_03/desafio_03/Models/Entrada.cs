using System;
using System.Collections.Generic;

namespace desafio_03.Models
{
    public partial class Entrada
    {
        public Entrada()
        {
            HistorialCompras = new HashSet<HistorialCompra>();
        }

        public int EntradaId { get; set; }
        public int UsuarioId { get; set; }
        public int SeccionId { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public virtual Seccione Seccion { get; set; } = null!;
        public virtual Usuario Usuario { get; set; } = null!;
        public virtual ICollection<HistorialCompra> HistorialCompras { get; set; }
    }
}
