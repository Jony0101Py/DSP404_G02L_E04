using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioG2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }
        int indice1, indice2;

        private void cboDivisaIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice1 = Convert.ToInt32(cboDivisaIni.SelectedIndex);
        }

        private void cboDivisaFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice2 = Convert.ToInt32(cboDivisaFin.SelectedIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIngreso.Clear();
            lblResPantalla.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int indice1 = Convert.ToInt32(cboDivisaIni.SelectedIndex);
            int indice2 = Convert.ToInt32(cboDivisaFin.SelectedIndex);
            //Variables
            double num = Convert.ToDouble(txtIngreso.Text), conversion = 0;
            //Proceso

            //Dolares
            if (indice1 == 0 && indice2 == 0)
            {
                lblResPantalla.Text = num.ToString();
            }
            if (indice1 == 0 && indice2 == 1)
            {
                conversion = num * 0.91;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 0 && indice2 == 2)
            {
                conversion = num * 145.33;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 0 && indice2 == 3)
            {
                conversion = num * 0.79;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 0 && indice2 == 4)
            {
                conversion = num * 0.88;
                lblResPantalla.Text = conversion.ToString();
            }

            //Euros
            if (indice1 == 1 && indice2 == 0)
            {
                conversion = num * 0.91;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 1 && indice2 == 1)
            {
                lblResPantalla.Text = num.ToString();
            }
            if (indice1 == 1 && indice2 == 2)
            {
                conversion = num * 158.90;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 1 && indice2 == 3)
            {
                conversion = num * 0.86;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 1 && indice2 == 4)
            {
                conversion = num * 0.96;
                lblResPantalla.Text = conversion.ToString();
            }

            //Yen Japonés
            if (indice1 == 2 && indice2 == 0)
            {
                conversion = num * 0.0069;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 2 && indice2 == 1)
            {
                conversion = num * 0.0063;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 2 && indice2 == 2)
            {
                lblResPantalla.Text = num.ToString();
            }
            if (indice1 == 2 && indice2 == 3)
            {
                conversion = num * 0.0054;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 2 && indice2 == 4)
            {
                conversion = num * 0.0060;
                lblResPantalla.Text = conversion.ToString();
            }

            //Libra Esterlina
            if (indice1 == 3 && indice2 == 0)
            {
                conversion = num * 1.27;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 3 && indice2 == 1)
            {
                conversion = num * 1.17;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 3 && indice2 == 2)
            {
                conversion = num * 185.15;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 3 && indice2 == 3)
            {
                lblResPantalla.Text = num.ToString();
            }
            if (indice1 == 3 && indice2 == 4)
            {
                conversion = num * 1.12;
                lblResPantalla.Text = conversion.ToString();
            }

            //Franco Suizo
            if (indice1 == 4 && indice2 == 0)
            {
                conversion = num * 1.14;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 4 && indice2 == 1)
            {
                conversion = num * 1.04;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 4 && indice2 == 2)
            {
                conversion = num * 165.76;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 4 && indice2 == 3)
            {
                conversion = num * 0.90;
                lblResPantalla.Text = conversion.ToString();
            }
            if (indice1 == 4 && indice2 == 4)
            {
                lblResPantalla.Text = num.ToString();
            }
        }

    }
}
