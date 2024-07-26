using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables 
            int numero;
            double suma, resta, mult, div;
            //Entrada de datos 
            numero = Convert.ToInt32(txtnumero.Text);
            //Proceso
            //Dejamos en blanco el comboBox
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();

            //Creamos nuestro bucle para poder mostrar la tabla del 1 al 

            for (int i = 1; i <= 12; i = i + 1)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;

                //Agregar los resultados a los comboBox 
                cbosuma.Items.Add(numero + "+" + i + "=" + suma);
                cboresta.Items.Add(numero + "-" + i + "=" + resta);
                cbomult.Items.Add(numero + "*" + i + "=" + mult);
                cbodiv.Items.Add(numero + "/" + i + "=" + div);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();
        }
    }
}
