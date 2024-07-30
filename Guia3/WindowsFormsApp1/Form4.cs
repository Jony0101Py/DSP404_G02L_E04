using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListaDeNombres : Form


    {
        public ListaDeNombres()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstNombres.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedItem != null)
            {
                lstNombres.Items.Remove(lstNombres.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre para borrar.");
            }
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedItem != null && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                int selectedIndex = lstNombres.SelectedIndex;
                lstNombres.Items[selectedIndex] = txtName.Text;
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre y/o ingrese un nuevo nombre.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
