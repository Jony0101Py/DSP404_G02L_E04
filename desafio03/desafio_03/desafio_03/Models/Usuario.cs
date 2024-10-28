using System;
using System.Collections.Generic;

namespace desafio_03.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Entrada = new HashSet<Entrada>();
            HistorialCompras = new HashSet<HistorialCompra>();
        }

        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Rol { get; set; } 

        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<HistorialCompra> HistorialCompras { get; set; }
    }
}
