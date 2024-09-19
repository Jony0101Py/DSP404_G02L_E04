using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC231259_Discusión_de_resultados
{
    public partial class Form2 : Form
    {

        private int[,] matriz;

        public Form2()
        {
            InitializeComponent();
        }

        // Método para generar la matriz 5x5 con números aleatorios entre los límites 
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random rand = new Random();
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(limiteInferior, limiteSuperior + 1); // Genera ls números aleatorios entre el rango o límite mejor dicho
                }
            }

            return matriz;
        }



        // Método para mostrar la matriz en el DataGridView
        private void MostrarMatriz(int[,] matriz)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                string[] fila = new string[5];
                for (int j = 0; j < 5; j++)
                {
                    fila[j] = matriz[i, j].ToString();
                }
                dataGridView1.Rows.Add(fila);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int limiteInferior = int.Parse(txtLimiteInferior.Text);
            int limiteSuperior = int.Parse(txtLimiteSuperior.Text);
            matriz = GenerarMatriz(limiteInferior, limiteSuperior);
            MostrarMatriz(matriz);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
