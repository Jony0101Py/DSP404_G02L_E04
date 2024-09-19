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
    public partial class Form1 : Form
    {

        private int[] lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void CrearListaVacia()
        {
            lista = new int[0]; // Crea el vector vacío
            MostrarLista();
        }

        // Método para insertar un elemento en la lista
        private void InsertarElemento(int nuevoElemento)
        {
            int[] nuevaLista = new int[lista.Length + 1];
            lista.CopyTo(nuevaLista, 0);
            nuevaLista[lista.Length] = nuevoElemento; // Agrega al final del nuevo vector
            lista = nuevaLista;
            MostrarLista();
        }


        // Método para remover el primer elemento
        private void RemoverElemento()
        {
            if (lista.Length > 0)
            {
                int[] nuevaLista = new int[lista.Length - 1];
                Array.Copy(lista, 1, nuevaLista, 0, lista.Length - 1); // Copia los elementos excepto el primero
                lista = nuevaLista;
            }
            MostrarLista();
        }

        // Método para mostrar los elementos en el ListBox
        private void MostrarLista()
        {
            listBox1.Items.Clear(); // Limpia el ListBox
            foreach (var item in lista)
            {
                listBox1.Items.Add(item); // Añade cada elemento del array al ListBox
            }
        }

        private void btnCrear_Click_Click(object sender, EventArgs e)
        {
            CrearListaVacia();
        }

        private void btnInsertar_Click_Click(object sender, EventArgs e)
        {
            int nuevoElemento = int.Parse(txtElemento.Text); // Convierte el texto a entero
            InsertarElemento(nuevoElemento);
        }

        private void btnRemover_Click_Click(object sender, EventArgs e)
        {
            RemoverElemento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            this.Hide();               
            form2.ShowDialog();         
            this.Show();
        }
    }
}
