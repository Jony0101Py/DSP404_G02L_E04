using System;
using System.Collections.Generic;

namespace desafio_03.Models
{
    public partial class Seccione
    {
        public Seccione()
        {
            Entrada = new HashSet<Entrada>();
        }

        public int SeccionId { get; set; }
        public int ConciertoId { get; set; }
        public string NombreSeccion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }

        public virtual Concierto Concierto { get; set; } = null!;
        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}
