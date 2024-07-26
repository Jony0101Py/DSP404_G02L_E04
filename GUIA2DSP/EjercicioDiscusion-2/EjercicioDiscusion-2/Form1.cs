using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDiscusion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double num3 = double.Parse(txtNum3.Text);
            double num4 = double.Parse(txtNum4.Text);

            // Crear un array con los números
            double[] numeros = { num1, num2, num3, num4 };

            // Calcular el promedio
            double promedio = CalcularPromedio(numeros);

            // Calcular la desviación típica
            double desviacionTipica = CalcularDesviacionTipica(numeros, promedio);

            // Mostrar los resultados en los Labels
            lblPromedio.Text = $"Promedio: {promedio}";
            lblDesviacionTipica.Text = $"Desviación Típica: {desviacionTipica}";

            // Agregar la entrada a la tabla de pruebas extras
            dataGridView1.Rows.Add(num1, num2, num3, num4);
        }

        private double CalcularPromedio(double[] numeros)
        {
            double suma = 0;
            foreach (double num in numeros)
            {
                suma += num;
            }
            return suma / numeros.Length;
        }

        private double CalcularDesviacionTipica(double[] numeros, double promedio)
        {
            double sumaDesviaciones = 0;
            foreach (double num in numeros)
            {
                sumaDesviaciones += Math.Pow(num - promedio, 2);
            }
            return Math.Sqrt(sumaDesviaciones / numeros.Length);
        }

    }


}
