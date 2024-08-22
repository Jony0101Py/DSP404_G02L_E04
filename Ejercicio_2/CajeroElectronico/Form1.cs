using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroElectronico
{
    public partial class Form1 : Form
    {
        //Estructurando los datos para almacenar las cuentas y saldos 
        Dictionary<int, decimal> cuentas = new Dictionary<int, decimal>
        {
            { 10000001, 400m },
            { 10000002, 200m },
            { 10000004, 500m }

        };

        public Form1()
        {
            InitializeComponent();
        }


        // Metodo para mostrar el menu Principal
        private void MostrarMenuPrincipal()
        {
            btnConsultaSaldo.Visible = true;
            btnRetiroFondos.Visible = true;
            btnConsignaciones.Visible = true;
            btnTransferencias.Visible = true;
            btnSalir.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numeroCuenta;
            if (int.TryParse(txtNumeroCuenta.Text, out numeroCuenta))
            {
                if (cuentas.ContainsKey(numeroCuenta))
                {
                    lblMensaje.Text = $"Bienvenido, cuenta {numeroCuenta}";
                    MostrarMenuPrincipal();
                }
                else
                {
                    lblMensaje.Text = "Numero de cuenta no valido.";
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, Ingresa un numero de cuenta valido.";
            }
        }
    

        private void btnConsultaSaldo_Click(object sender, EventArgs e)
        {
            int numeroCuenta = int.Parse(txtNumeroCuenta.Text);
            lblMensaje.Text = $"El saldo actual de la cuenta {numeroCuenta} es de ${cuentas[numeroCuenta]:F2}";
        }

        private void btnRetiroFondos_Click(object sender, EventArgs e)
        {
            int numeroCuenta = int.Parse(txtNumeroCuenta.Text);
            decimal montoRetiro = decimal.Parse(txtMonto.Text);

            if (cuentas[numeroCuenta] >= montoRetiro)
            {
                cuentas[numeroCuenta] -= montoRetiro;
                lblMensaje.Text = $"el retiro de ${montoRetiro:F2} fue exitoso. El saldo actual de la cuenta {numeroCuenta} es de ${cuentas[numeroCuenta]:F2}";
            }
            else
            {
                lblMensaje.Text = "Fondos insuficientes.";
            }
        }

        private void btnConsignaciones_Click(object sender, EventArgs e)
        {
            int numeroCuenta = int.Parse(txtNumeroCuenta.Text);
            decimal montoConsignacion = decimal.Parse(txtMonto.Text);

            cuentas[numeroCuenta] += montoConsignacion;
            lblMensaje.Text = $"la consignacion de ${montoConsignacion:F2} fue exitosa. El saldo de la cuenta {numeroCuenta} es de ${cuentas[numeroCuenta]:F2}";
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            int numeroCuentaOrigen = int.Parse(txtNumeroCuenta.Text);
            int numeroCuentaDestino = int.Parse(txtCuentaDestino.Text);
            decimal montoTransferencia = decimal.Parse(txtMonto.Text);

            if (cuentas.ContainsKey(numeroCuentaDestino) && cuentas[numeroCuentaOrigen] >= montoTransferencia)
            {
                cuentas[numeroCuentaOrigen] -= montoTransferencia;
                cuentas[numeroCuentaDestino] += montoTransferencia;
                lblMensaje.Text = $"La Transferencia de ${montoTransferencia:F2} fue exitosa. El saldo actual de la cuenta{numeroCuentaOrigen} es de ${cuentas[numeroCuentaOrigen]:F2}";
            }
            else
            {
                lblMensaje.Text = "Fondos insuficientes o cuenta de destino no valida.";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
