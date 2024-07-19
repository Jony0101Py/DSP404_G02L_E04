using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {

        //Declaración de matriz
        string[,] matriz = new string[3, 3];
        //variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion solo numeros
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //posiciones de la columna de la matriz
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            //verificamos el combobox1
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (txtInfo.Text == "")
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        //agregamos el dato en la posicion [fila1,column1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        //pasamos a la siguiente fila de la matriz
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear();//limpiamos el texboxt1
                    }
                    else MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cbtipoinfo.SelectedIndex == 1)
                    if (txtInfo.Text == "")
                        txtInfo.BackColor = Color.Bisque;
                    else
                    if (fila2 < 3)
                    {
                        //Agregamos el dato en la posicion (fila2,colum2) de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        //pasamos a la siguiente fila de la matriz
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas apellidos");
                else
                    MessageBox.Show("Seleccione una opción");

            }
            if (IsNumeric(txtEdad.Text) == true)
                if (fila3 < 3)
                {
                    //Agregamos el dato en la posicion [fila3,colum3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    //pasamos a la siguiente fila de la matriz
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear(); //limpiamos el textbox1
                    countergen += 1;
                }
                else
                    MessageBox.Show("No se pueden agregar mas edades");
            else
                txtEdad.BackColor = Color.Beige;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            //limpiando grilla
            dgdatos.Columns.Clear();
            //creando columnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            //agregando datos a grilla
            //Mostrando nombres
            dgdatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];
            //Mostrando apellidos
            dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];
            //Mostrando edades
            dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = string.Empty;
                }
            }
            // Inicializar variables
            fila1 = fila2 = fila3 = colum1 = colum2 = colum3 = 0;
            // Limpiar grilla
            dgdatos.Rows.Clear();
            MessageBox.Show("Datos limpiados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            int sumaEdades = 0;
            int contadorEdades = 0;
            for (int i = 0; i < 3; i++)
            {
                if (IsNumeric(matriz[i, 2]))
                {
                    sumaEdades += int.Parse(matriz[i, 2]);
                    contadorEdades++;
                }
            }
            if (contadorEdades > 0)
            {
                double promedio = (double)sumaEdades / contadorEdades;
                MessageBox.Show($"El promedio de edades es: {promedio}", "Promedio de Edades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay edades ingresadas para calcular el promedio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool IsNumeric(string valor)
        {
            //Determina si parametro valor puede convertirse a numero entero
            int result;
            return int.TryParse(valor, out result);
        }


        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validación de solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Lbtipo_info_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
