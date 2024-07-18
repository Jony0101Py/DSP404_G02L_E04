using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioG2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variables
            int serie, num, num0 = 0, num1 = 1;
            //Proceso
            lsbSerieFibonacci.Items.Add(num0);
            lsbSerieFibonacci.Items.Add(num1);
            num = Convert.ToInt32(txtIngreso.Text);
            for (int i = 2; i <= num; i++)
            {
                serie = num0 + num1;
                lsbSerieFibonacci.Items.Add(serie);
                num0 = num1;
                num1 = serie;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lsbSerieFibonacci.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
