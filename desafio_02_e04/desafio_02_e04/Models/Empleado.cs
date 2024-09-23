using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desafio_02_e04.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Password { get; set; }
        public string Usuario { get; set; }  // Agregado para autenticación
    }
}