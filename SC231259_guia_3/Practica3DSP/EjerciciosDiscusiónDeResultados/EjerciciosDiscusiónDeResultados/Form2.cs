using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosDiscusiónDeResultados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerateMatrix_Click(object sender, EventArgs e)
        {
            int dimension;
            if (int.TryParse(textBoxDimension.Text, out dimension) && dimension > 0)
            {
                int[,] matrix = GenerateMatrix(dimension);
                DisplayMatrix(dataGridViewMatrix, matrix);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dimensión válida.");
            }
        }


        private int[,] GenerateMatrix(int dimension)
        {
            Random random = new Random();
            int[,] matrix = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i, j] = random.Next(100); // Genera números aleatorios entre 0 y 99
                }
            }
            return matrix;
        }

        private void DisplayMatrix(DataGridView dataGridView, int[,] matrix)
        {
            int dimension = matrix.GetLength(0);
            dataGridView.ColumnCount = dimension;
            dataGridView.RowCount = dimension;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    dataGridView[j, i].Value = matrix[i, j];
                }
            }
        }

        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            int dimension = dataGridViewMatrix.ColumnCount;
            int[,] matrix = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i, j] = (int)dataGridViewMatrix[j, i].Value;
                }
            }
            int[,] transpose = TransposeMatrix(matrix);
            DisplayMatrix(dataGridViewTranspose, transpose);
        }

        private int[,] TransposeMatrix(int[,] matrix)
        {
            int dimension = matrix.GetLength(0);
            int[,] transpose = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            return transpose;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
