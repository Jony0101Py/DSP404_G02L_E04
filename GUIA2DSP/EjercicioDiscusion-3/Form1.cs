using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioG2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int pos = 0, neg = 0, ceros = 0, numNeg = 0, cantNums = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Variables
            double promNeg, porPos, porNeg, porCero;
            int cantPos, mayorNeg = 0, num;

            //Proceso
            num = Convert.ToInt32(txtNumero.Text);

            if (num >= -40 && num <= 45)
            {
                if (num < 0 && num < mayorNeg)
                {
                    //Mayor Negativo
                    lblError.Visible = false;
                    neg++;
                    mayorNeg = num;
                    txtMayorNeg.Text = mayorNeg.ToString();
                    //Promedio de Negativo
                    numNeg = numNeg + num;
                    promNeg = numNeg / neg;
                    txtPromNeg.Text = promNeg.ToString();

                }
                
                if (num > 0)
                {
                    //Cantidad de Positivos
                    lblError.Visible = false;
                    pos++;
                    txtNPositivos.Text = pos.ToString();
                }
                if (num == 0)
                {
                    ceros++;    
                }
                cantNums++;
                porCero = (ceros*100)/cantNums;
                porPos = (pos*100)/cantNums;
                porNeg = (neg*100)/cantNums;    
                txtPorCero.Text = porCero.ToString();   
                txtPorPos.Text = porPos.ToString(); 
                txtPorNeg.Text = porNeg.ToString(); 
            }
            else
            {
                lblError.Text = "Por favor ingrese un número dentro del rango (45 a -40)";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
