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
    public partial class Form3 : Form
    {

        // Declaración de variables privadas
        private string noms, ape1, ape2;
        private double CUM;
        private int UV;


        public Form3()
        {
            InitializeComponent();
        }

        // Método para validar si un valor es numérico
        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }


        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            // Realizar las respectivas validaciones
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtApe1.Text) ||
                string.IsNullOrWhiteSpace(txtApe2.Text) ||
                string.IsNullOrWhiteSpace(txtCUM.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(txtCUM.Text))
            {
                MessageBox.Show("El valor de CUM debe ser numérico.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
                return;
            }

            // Asignar valores ingresados a las variables
            noms = txtNom.Text;
            ape1 = txtApe1.Text;
            ape2 = txtApe2.Text;

            CUM = Convert.ToDouble(txtCUM.Text);

            // Llamar a EvaluarCUM para calcular las UV
            EvaluarCUM();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de despedida antes de cerrar la aplicación
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Cerrar aplicación",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("¡Hasta luego! Gracias por usar la aplicación.", "Despedida",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Close(); 
            }
        }

        private void EvaluarCUM()
        {
            string nombrecompleto = $"{noms} {ape1} {ape2}";
            nombrecompleto = nombrecompleto.ToUpper();

            if (CUM < 0 || CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                // Usar estructura switch para determinar las UV según el rango de CUM
                switch ((int)CUM)
                {
                    case 8:
                    case 9:
                    case 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }

                txtResul.Text = $"{nombrecompleto} puede cursar {UV} UV";
            }
        }
    }
}
    

