// - comentado por: sc231259

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace desafio_02_e04.Models
{
    public class CarritoItem
    {
        public int MenuId { get; set; }  // El ID del plato seleccionado
        public string NombrePlato { get; set; }  // Nombre del plato
        public decimal Precio { get; set; }  // Precio del plato
        public int Cantidad { get; set; }  // Cantidad seleccionada

        // Calcula el precio total por ítem (precio * cantidad)
        public decimal Total
        {
            get { return Precio * Cantidad; }
        }
    }
}