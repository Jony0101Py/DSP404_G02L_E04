using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
{
    public partial class Form1 : Form
    {
        List<clsMamifero> mamiferos;

        OpenFileDialog cuadroselecciones = new OpenFileDialog();

        void PrepararNuevoMamifero()
        {
            txtNomCien.Clear();
            txtNomCom.Clear();
            picMamifero.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            cboFamilia.SelectedIndex = 0;
            cboHabitat.SelectedIndex = 0;
            dtpFechaRes.Value = DateTime.Now;
            cboDesEmb.SelectedIndex = 0;
            nudCantMamas.Value = 0;

            txtNomCom.Focus();
        }

        public void Mostrar_Mamiferos()
        {
            int c = 0;

            dataGridView1.Columns[6].HeaderText = "Desarrollo Embrionario";
            dataGridView1.Columns[7].HeaderText = "Cantidad de Mamas";

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(mamiferos.Count);

            for (int i = 0; i < mamiferos.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = mamiferos[c].nombreComun;
                dataGridView1.Rows[i].Cells[1].Value = mamiferos[c].nombreCient;
                dataGridView1.Rows[i].Cells[2].Value = mamiferos[c].nFamilia;
                dataGridView1.Rows[i].Cells[3].Value = mamiferos[c].nHabitat;
                dataGridView1.Rows[i].Cells[4].Value = mamiferos[c].fecha_res;
                dataGridView1.Rows[i].Cells[5].Value = Image.FromFile(mamiferos[c].urlFoto);
                dataGridView1.Rows[i].Cells[6].Value = mamiferos[c].desarrollo_embrionario;
                dataGridView1.Rows[i].Cells[7].Value = mamiferos[c].cantidad_mamas;
                c++;
            }


        }
        public Form1()
        {
            InitializeComponent();

            mamiferos = new List<clsMamifero>();
            cuadroselecciones.Filter = "Imagenes de Tipo JPG | *.jpg";
            PrepararNuevoMamifero();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cuadroselecciones.ShowDialog() == DialogResult.OK)
            {
                picMamifero.ImageLocation = cuadroselecciones.FileName;
            }
        }

        private void btnAgreMamifero_Click(object sender, EventArgs e)
        {
            clsMamifero Mamifero = new clsMamifero();

            Mamifero.nombreComun = txtNomCom.Text;
            Mamifero.nombreCient = txtNomCien.Text;
            Mamifero.nFamilia = Convert.ToString(cboFamilia.SelectedItem);
            Mamifero.nHabitat = Convert.ToString(cboHabitat.SelectedItem);
            Mamifero.asig_fechres(dtpFechaRes.Value);
            Mamifero.urlFoto = picMamifero.ImageLocation;
            Mamifero.desarrollo_embrionario = Convert.ToString(cboDesEmb.SelectedItem);
            Mamifero.cantidad_mamas = Convert.ToInt32(nudCantMamas.Value);

            mamiferos.Add(Mamifero);

            PrepararNuevoMamifero();
        }

        private void btnMosMami_Click(object sender, EventArgs e)
        {
            Mostrar_Mamiferos();
        }
    }
}
