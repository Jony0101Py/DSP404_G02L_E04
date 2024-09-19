using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsCuenta nuevoRegistro = new clsCuenta();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                clsCuenta cuenta = new clsCuenta();
                cuenta.ingresarCuenta(Convert.ToInt32(txtDUI.Text), Convert.ToInt32(nudNCuenta.Value), nudSaldo.Value, nudInteres.Value);

                if (cuenta.DatosCorrectosCuenta)
                {
                    if (txtDUI.TextLength < 9)
                    {
                        MessageBox.Show("Ingrese un número de DUI correcto");
                        txtDUI.Focus();
                        return;
                    }
                    if (txtDUI.TextLength > 9)
                    {
                        MessageBox.Show("Ingrese un número de DUI correcto");
                        txtDUI.Focus();
                        return;
                    }
                    if (nudSaldo.Value == 0)
                    {
                        MessageBox.Show("Ingresa un saldo correcto");
                        nudSaldo.Focus();
                        return;
                    }
                    if (nudInteres.Value < 10)
                    {
                        MessageBox.Show("Interés no válido");
                        nudInteres.Focus();
                        return;
                    }
                    if (nudInteres.Value > 22.3m)
                    {
                        MessageBox.Show("Interés no válido");
                        nudInteres.Focus();
                        return;
                    }
                    nudNCuenta.Minimum += 1;
                    nuevoRegistro.RecibirCuenta(cuenta);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            nuevoRegistro.GenerarTabla(ref dataGridView1);
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            nuevoRegistro.actualizarSaldo();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            nuevoRegistro.Ingesar(Convert.ToInt32(nudIngC.Value), nudCantidad.Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            nuevoRegistro.Retirar(Convert.ToInt32(nudIngC.Value), nudCantidad.Value);
        }
    }
}
