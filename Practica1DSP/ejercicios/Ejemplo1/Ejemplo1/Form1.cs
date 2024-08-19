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
        // Declarar variables globales
        private string mensa;
        private int conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento que se ejecuta al iniciar ejecución de Form1
            mensa = "Aún no ha presionado botón Contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            // Acumulador, Total veces que presiona botón
            conta += 1; // En forma de operador abreviado
            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            // Restaura conteo clic realizado a button1
            conta = 0;
            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            // Finaliza aplicación
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede quedar vacío o puedes eliminarlo si no es necesario.
        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  
        }

        private void btnAbrirForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
    }

