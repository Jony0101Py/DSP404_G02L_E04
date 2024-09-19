using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC231259_ejercicio4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
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

        private int calculo_servicio()// Función no recibe parámetros pero devuelve un valor
        {
            int acum = 0;
            /* Usar CheckBox sin tanto if. Para ello se recorre la colección ControlCollection de la
            propiedad Controls,
            después se verifica si el control es un CheckBox y de serlo, verificar su valor.
            Cuando damos click en el boton calcular se invoca esta función y se recorren todos los controles
            del formulario,y si un control es un CheckBox, entonces se verifica su valor y si es verdadero
            acumulamos el valor del servicio*/
            foreach (Control contr in this.groupBox2.Controls)
            {
                CheckBox checkbox = contr as CheckBox;
                if (checkbox.Checked)
                    acum += 20;
            }// fin de primer if dentro de foreach
            return acum;
        }

    }
}
