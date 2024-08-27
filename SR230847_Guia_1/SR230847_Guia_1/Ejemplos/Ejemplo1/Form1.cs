using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private static int conta = 0;  //Se le hace la declaracion de la variable estatica lo que ya estara disponible para toda instancia del Form1.
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // COMENTARIO
            //int conta;
            string mensa = "Aun no ha presionado botón Contar";
            label1.Text = mensa;
           
        }

        private void btnContar_Click(object sender, EventArgs e)
        {

            //int conta = 0;
            //Acumulacion, total veces que presiona botón
            conta = conta + 1;
            //conta += 1 ; //En forma de operador abreviado
            string mensa = "Presiono botón contar, un total de "+
            Convert.ToString(conta) + " veces";
            label1.Text = mensa;


        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            
            conta = 0;
            string mensa = "Presiono botón contar, un total de "+
            Convert.ToString(conta)+" veces";
          
            label1.Text= mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close(); //finaliza la aplicacion.
        }
    }
}
