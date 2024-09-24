using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desafio_02_e04.Models
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }
        public string NombrePlato { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}