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

        public Form3()
        {
            InitializeComponent();
        }

        private string noms, ape1, ape2;
        private double CUM;
        private int UV;

        //valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            ape1 = txtApe1.Text;
            ape1 = ape1.Trim();
            if (ape1.Length == 0)
            {
                MessageBox.Show("Ingrese su primer apellido :D", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ape2 = txtApe2.Text;
            ape2 = ape2.Trim();
            if (ape2.Length == 0)
            {
                MessageBox.Show("Ingrese su segundo apellido :P", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            noms = txtNom.Text;
            noms = noms.Trim();
            if (noms.Length == 0)
            {
                MessageBox.Show("Indique su nombre", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNom.Focus();
                return;

            }
            CUM = Convert.ToDouble(txtCum.Text);
            //Cuando se digita la nota que tiene el usuario lo valida si es correcto

            txtCum.Text = txtCum.Text.Trim();
            
            EvaluarCUM();
        

        }



        //evalua el cum
        private void EvaluarCUM()
        {
            //una vez recibidos los nombres del estudiante, asi como su CUM se detemina las UV' solicitadas
            string nombrecompleto;
            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCum.Focus();
            }
            else
            {
                //Usa estructura switch
                switch (Convert.ToInt32(CUM))
                {
                    case 10:
                        UV = 32;
                        break;
                    case 9:
                        UV = 32;
                        break;
                    case 8:
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
                txtResul.Text = nombrecompleto + " Puede cursar " + UV  + " UV";

            }
        }
        
        }
    }

