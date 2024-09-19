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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private Boolean validar(string nombre, string pwd)
        {
            string clave = nombre;
            string pasword = "usuario";
            DialogResult respuesta; // variable para capturar el dato que me devuelve el MessageBox.show
          if (nombre == clave && pwd == pasword)
            {
               respuesta = MessageBox.Show("Bienvenido" + " " + nombre, "Acceso",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    /* Para llamar a otro formulario(Form5),se debe primero instancia al
                   nuevo formulario,o es decir creamos el objeto
                    * para nuestro caso formulario2 y luego accesamos al método show, para
                   mostrar el Form5*/
                    Form2 formulario2 = new Form2();//instanciando al Form
                    formulario2.Show(); // Mostramos el Form2
                    return true;
                }
            }//Fin de if
            else
            {
                MessageBox.Show("Contraseña incorrecta","Acceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }// Fin de Función

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar(txtusuario.Text, txtpwd.Text))
            {
                // Se llama la función validar declarada.
                this.Hide();
            }// ocultamos el Form4
        }
    }
}
