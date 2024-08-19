using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:DR231900_Guia3/Guia3/WindowsFormsApp1/Program.cs
namespace WindowsFormsApp1
========
namespace Ejemplo1
>>>>>>>> SC231259_guia_1:Practica1DSP/ejercicios/Ejemplo1/Ejemplo1/Program.cs
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListaDeNombres());
        }
    }
}
