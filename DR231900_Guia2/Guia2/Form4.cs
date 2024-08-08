using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int first = 1;
            int second = 2;

            List<int> ulamSequence = new List<int> { first, second };

            int nextNumber = second + 1;

            while (ulamSequence.Count < 20)
            {
                int count = 0;

                for (int i = 0; i < ulamSequence.Count - 1; i++)
                {
                    for (int j = i + 1; j < ulamSequence.Count; j++)
                    {
                        if (ulamSequence[i] + ulamSequence[j] == nextNumber)
                        {
                            count++;
                            if (count > 1) break;
                        }
                    }
                    if (count > 1) break;
                }


                if (count == 1)
                {
                    ulamSequence.Add(nextNumber);
                }

                nextNumber++;
            }

            // Imprimimos la sucesión de Ulam calculada
            Console.WriteLine("La sucesión de Ulam calculada es:");
            foreach (int number in ulamSequence)
            {
                Console.Write(number + " ");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
            lstLista.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

        

    


