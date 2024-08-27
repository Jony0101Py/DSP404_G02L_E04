namespace Parte_2_Uso_De_Matriz_De_3x3
{
    public partial class Form1 : Form
    {
        //Declara la matriz global
        string[,] matriz = new string[3, 3];
        //Variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        public static bool IsNumeric(string valor)
        {
            //Determinar si el parametro valor puede convertirse a numero entero.
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se validan los datos 
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion solo numero
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    else
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMostrar_Click(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Recorrer la matriz para limpiar cada posición de ella
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = ""; // Limpia cada posición
                }
            }

            // Inicializar las variables filas y columnas a cero
            fila1 = 0;
            fila2 = 0;
            fila3 = 0;
            colum1 = 0;
            colum2 = 0;
            colum3 = 0;

            // Limpiar la grilla (DataGridView)
            dgdatos.Rows.Clear();
            dgdatos.Columns.Clear();

            // Mensaje opcional para confirmar que se ha realizado la limpieza
            MessageBox.Show("Matriz, variables y grilla limpiadas correctamente.", "Limpieza Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int sumaEdades = 0;
            int contadorEdades = 0;

            // Recorrer la columna de edades (columna 2 en este caso)
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(matriz[i, colum3])) // Verifica si la celda no está vacía
                {
                    int edad;
                    if (int.TryParse(matriz[i, colum3], out edad)) // Intenta convertir el valor a un número entero
                    {
                        sumaEdades += edad; // Suma la edad
                        contadorEdades++; // Incrementa el contador de edades
                    }
                }
            }

            // Calcular el promedio
            double promedio = (contadorEdades > 0) ? (double)sumaEdades / contadorEdades : 0;

            // Mostrar el promedio en un MessageBox
            MessageBox.Show($"El promedio de las edades es: {promedio:F2}", "Promedio de Edades", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

                
        

