namespace Parte_1_Arreglo_Unidimensional
{
    public partial class Form1 : Form
    {
        public static int[] matriz = new int[5];
        int i=0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (i <= 5)
            {
                //Se agrega los numeros en cada posicion del arreglo
                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstdesorden.Items.Add(matriz[i]); //Agregamos los numeros a las listas
                i += 1;
                txtNum.Clear();
                txtNum.Select();
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int j, k, count;
            double valor;
            int Tam = 5;
            //---ordenamos el arreglo por el metodo de la burbuja
            for (j = 0; j < Tam; j++)
            {
                for (k = 0; k < (Tam - 1); k++)
                {
                    if (matriz[k] > matriz[k + 1])
                    {
                        valor = matriz[k];
                        matriz[k] = matriz[k + 1];
                        matriz[k + 1] = Convert.ToInt16(valor);}
                    }

                }
                //Se recorre el arreglo e ingresamos los valores a la lista
                lstOrdenada.Items.Clear();
                for (count = 0; count < Tam; count++)
                {
                    lstOrdenada.Items.Add(matriz[count]);
                }
            }
        }
    }

    
        
    

