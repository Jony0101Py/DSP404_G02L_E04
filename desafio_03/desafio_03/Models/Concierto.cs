using System;
using System.Collections.Generic;

namespace desafio_03.Models
{
    public partial class Concierto
    {
        public Concierto()
        {
            Secciones = new HashSet<Seccione>();
        }

        public int ConciertoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; } = null!;

        public virtual ICollection<Seccione> Secciones { get; set; }
    }
}
