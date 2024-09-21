using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC231259_ejercicio1.Models
{
    public class categorias
    {
        public List<SelectListItem> Categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}