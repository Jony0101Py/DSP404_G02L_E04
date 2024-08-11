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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                listBoxNames.Items.Add(textBoxName.Text);
                textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null)
            {
                listBoxNames.Items.Remove(listBoxNames.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para eliminar.");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null && !string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                int selectedIndex = listBoxNames.SelectedIndex;
                listBoxNames.Items[selectedIndex] = textBoxName.Text;
                textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione un nombre y asegúrese de que el campo de texto no esté vacío.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
