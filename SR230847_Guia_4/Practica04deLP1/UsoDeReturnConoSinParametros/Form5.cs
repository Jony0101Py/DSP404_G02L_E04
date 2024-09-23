using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoDeReturnConoSinParametros
{
  
    public partial class Form5 : Form
    {

        const float Pago_turista = 50, Pago_Delegado = 70;
        float interes = 0.18f;


        private float calculo_hospedaje(int dias) // Función recibe un paramétro y retorna un valor.
        {
            float calculo = 0f;
            if (radioButton1.Checked)
            {
                calculo = Convert.ToInt32(txtdias.Text) * Pago_turista;
            }
            else
            {
                calculo = Convert.ToInt32(txtdias.Text) * Pago_Delegado;
            }

            return calculo;
        }
        private int calculo_servicio()// Función no recibe parámetros pero devuelve un valor
        {
            int acum = 0;
            foreach (Control contr in this.groupBox2.Controls)
            {
                CheckBox checkbox = contr as CheckBox;
                if (checkbox.Checked)
                    acum += 20;
            }// fin de primer if dentro de foreach
            return acum;
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();

            txtmontoh.Enabled = false;
            txtmontos.Enabled = false;
            txtmontot.Enabled = false;
            txtinteres.Enabled = false;
            nUDpagar.Enabled = false;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        private bool ValidarCheckBox()
        {
            foreach (Control contr in this.groupBox2.Controls)
            {
                CheckBox checkbox = contr as CheckBox;
                if (checkbox != null && checkbox.Checked)
                {
                    return true; // Si al menos un CheckBox está marcado, retorna true
                }
            }
            return false; // Si ninguno está marcado, retorna false
        }
        private bool ValidarTextos()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                txtnombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtdias.Text) || !int.TryParse(txtdias.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un número válido de días.");
                txtdias.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hacer la validacion de los textbox
            if (!ValidarTextos()) return;

            //Se hace la validacion al menos un Checkbox este seleccionado
            if(!ValidarCheckBox())
            {
                MessageBox.Show("Debe seleccionar al menos un servicio.");
                return;
            }

            float montoh = 0f;
            int montos = 0;
            decimal total = 0;
            montoh = calculo_hospedaje(Convert.ToInt32(txtdias.Text));
            txtmontoh.Text = Convert.ToString(montoh);
            montos = calculo_servicio();
            txtmontos.Text = Convert.ToString(montos);
            txtmontot.Text = Convert.ToString(montoh + montos);
            txtinteres.Text = ((float.Parse(txtmontot.Text) * interes)).ToString();

            total = Convert.ToDecimal(txtmontot.Text) + Convert.ToDecimal(txtinteres.Text);
            nUDpagar.Maximum = 2 * total;
            nUDpagar.Value = total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtnombre.Focus();
            txtdias.Text = " ";
            txtmontoh.Text = "";
            txtmontos.Text = "";
            txtmontot.Text = "";
            txtinteres.Text = "";
            nUDpagar.Value = 0;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Hace que previene que cualquier otro caracter se pueda ingresar.
            }
                    { 
            }
        }
    }
}
