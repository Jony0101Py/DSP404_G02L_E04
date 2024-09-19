using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6Ejercicio1
{
    public partial class Form1 : Form
    {
        List<clsDoctor> doctores;
        List<clsVendedor> venderores;

        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        private void llenarcombobox()
        {
            int c;
            for (c = 1; c <= 31; c++)
            {
                cmbDia.Items.Add(c);
                cmbDia.Text = DateTime.Now.Day.ToString();
            }
            for(c = 1; c <= 12; c++)
            {
                cmbMes.Items.Add(c);
                cmbMes.Text = DateTime.Now.Month.ToString();
            }
            for (c = 1950; c <= DateTime.Now.Year; c++)
            {
                cmbAnno.Items.Add(c);
                cmbAnno.Text = DateTime.Now.Year.ToString();
            }
        }

        void PrepararNuevoDoctor()
        {
            txtNomDoc.Clear();
            picFotoDoc.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAnno.SelectedIndex = 0;
            nudSueldo.Value = 1.00M;
            mtbCodDoctor.Clear();
            txtNomDoc.Focus();
        }

        void PrepararNuevoVendedor()
        {
            txtNomVen.Clear();
            picFotoVen.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            dtpFechaNac.Value = DateTime.Now;
            dtpFechaC.Value = DateTime.Now;
            txtNomVen.Focus();
        }

        public void MostrarLista_Doctores()
        {
            int cm = 0;

            dataGridView1.Columns[4].HeaderText = "Código";
            dataGridView1.Rows.Clear();

            for (int j = 0; j < doctores.Count; j++)
            {
                dataGridView1.Rows.Add();
            }
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = doctores[cm].nombreempleado;
                fila.Cells[2].Value = Image.FromFile(doctores[cm].URLfoto);
                fila.Cells[3].Value = doctores[cm].fecha_nacimiento;
                fila.Cells[4].Value = doctores[cm].codigodoctor;
                cm++;
            }
        }

        public void MostrarLista_Vendedores()
        {
            int cm = 0;

            dataGridView1.Columns[4].HeaderText = "Fecha Contrato";
            dataGridView1.Rows.Clear();

            for (int j = 0; j < doctores.Count; j++)
            {
                dataGridView1.Rows.Add();
            }
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = venderores[cm].nombreempleado;
                fila.Cells[2].Value = Image.FromFile(venderores[cm].URLfoto);
                fila.Cells[3].Value = venderores[cm].fecha_nacimiento;
                fila.Cells[4].Value = venderores[cm].FechaContrato;
                cm++;
            }
        }

        public Form1() //constructor de clase Form1
        {
            InitializeComponent();
            llenarcombobox();
            doctores = new List<clsDoctor>();
            venderores = new List<clsVendedor>();

            cuadroseleccion.Filter = "Imagenes de tipo JPG | *.jpg";

            PrepararNuevoDoctor();
            PrepararNuevoVendedor();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoDoc.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = new clsDoctor();

            Doctor.nombreempleado = txtNomDoc.Text;
            Doctor.asignarfechanac(cmbAnno.Text, cmbMes.Text, cmbDia.Text);
            Doctor.sueldobase = Convert.ToSingle(nudSueldo.Value);
            Doctor.codigodoctor = mtbCodDoctor.Text;

            Doctor.URLfoto = picFotoDoc.ImageLocation;

            if (Doctor.Datossoncorrectos())
            {
                doctores.Add(Doctor);
                MessageBox.Show("Doctor " + Doctor.nombreempleado + " se ha agregado a la lista","Excelente!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                PrepararNuevoDoctor();
            }
            else
            {
                MessageBox.Show("Datos Incompletos");
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            if(cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoVen.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            clsVendedor Vendedor = new clsVendedor();

            Vendedor.nombreempleado = txtNomVen.Text;
            Vendedor.sueldobase = 2000;
            Vendedor.asignarfechanac(dtpFechaNac.Value);
            Vendedor.FechaContrato = dtpFechaC.Value;

            Vendedor.URLfoto = picFotoVen.ImageLocation;

            venderores.Add(Vendedor);
            PrepararNuevoVendedor();
        }

        private void rbDoctores_CheckedChanged(object sender, EventArgs e)
        {
            MostrarLista_Doctores();
        }

        private void rbVendedores_CheckedChanged(object sender, EventArgs e)
        {
            MostrarLista_Vendedores();
        }
    }
}
