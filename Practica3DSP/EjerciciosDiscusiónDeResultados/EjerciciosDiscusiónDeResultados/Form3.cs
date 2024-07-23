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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonGenerateGrades_Click(object sender, EventArgs e)
        {
            int[,] grades = GenerateGrades();
            double[] averages = CalculateAverages(grades);
            DisplayGrades(dataGridViewGrades, grades, averages);
        }

        private int[,] GenerateGrades()
        {
            Random random = new Random();
            int[,] grades = new int[6, 5];
            for (int i = 0; i < 6; i++)
            {
                int numberOfSubjects = random.Next(2, 6); // Al menos 2 asignaturas y máximo 5
                for (int j = 0; j < numberOfSubjects; j++)
                {
                    grades[i, j] = random.Next(0, 101); // Genera notas entre 0 y 100
                }
                for (int j = numberOfSubjects; j < 5; j++)
                {
                    grades[i, j] = -1; // Indica que no cursa esta asignatura
                }
            }
            return grades;
        }

        private double[] CalculateAverages(int[,] grades)
        {
            double[] averages = new double[6];
            for (int i = 0; i < 6; i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (grades[i, j] != -1)
                    {
                        sum += grades[i, j];
                        count++;
                    }
                }
                averages[i] = (double)sum / count;
            }
            return averages;
        }

        private void DisplayGrades(DataGridView dataGridView, int[,] grades, double[] averages)
        {
            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "Alumno";
            dataGridView.Columns[1].Name = "Asignatura 1";
            dataGridView.Columns[2].Name = "Asignatura 2";
            dataGridView.Columns[3].Name = "Asignatura 3";
            dataGridView.Columns[4].Name = "Asignatura 4";
            dataGridView.Columns[5].Name = "Asignatura 5";
            dataGridView.Columns[6].Name = "Media";

            dataGridView.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                string[] row = new string[7];
                row[0] = "Alumno " + (i + 1);
                for (int j = 1; j <= 5; j++)
                {
                    if (grades[i, j - 1] != -1)
                    {
                        row[j] = grades[i, j - 1].ToString();
                    }
                    else
                    {
                        row[j] = "N/A";
                    }
                }
                row[6] = averages[i].ToString("F2");
                dataGridView.Rows.Add(row);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
