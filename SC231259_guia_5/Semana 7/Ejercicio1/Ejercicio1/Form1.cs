﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsPlanilla planillaEPSON = new clsPlanilla();


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                dtpFechaNac.MinDate = fecha.AddYears(-70);
                dtpFechaNac.MaxDate = fecha.AddYears(15);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnNuevo.Enabled = false;
                btnAceptar.Enabled = false;
                btnGenerarPlanilla.Enabled = false;
                btnNuevo.Focus();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpleado trabajador = new clsEmpleado();
                trabajador.DefinirDatosPersonales(txtNombres.Text, txtApellidos.Text, dtpFechaNac.Value);

                if(trabajador.datospersonales_aceptados)
                {
                    if(!(Int32.Parse(txtSueldoIni.Text) >= 0))
                    {
                        MessageBox.Show("ERROR, Sueldo inicial no valido");
                        txtSueldoIni.Focus();
                        return;
                    }
                    if (nudRenta.Value <= 0.0m)
                    {
                        MessageBox.Show("ERROR, revise tasa renta");
                        nudRenta.Focus();
                        return;
                    }
                    if (nudISSS.Value <= 0.0m)
                    {
                        MessageBox.Show("ERROR, revise tasa ISSS");
                        nudISSS.Focus();
                        return;
                    }

                    trabajador.DefinirDatosLaborales(dtpFechaContrato.Value, Convert.ToDecimal(txtSueldoIni.Text));

                    if(trabajador.datoslaborales_completos)
                    {
                        trabajador.AsignarDescuentos(Convert.ToDecimal(nudISSS.Text), Convert.ToDecimal(nudRenta.Text));
                        planillaEPSON.RecibirEmpleado(trabajador);

                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;

                        btnNuevo.Enabled = true;
                        btnAceptar.Enabled = false;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        txtNombres.Focus();
                    }
                }
                else
                {
                    txtNombres.Focus();
                }
            }
            catch (Exception f) {
                MessageBox.Show(f.Message);
            }
        }

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGenerarPlanilla.Enabled = true;
            planillaEPSON.AbrirPlanilla(DateTime.Now, "Epson Internacional");
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            planillaEPSON.GenerarListado(ref dataGridView1);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldoIni.Clear();
            nudISSS.Value = 0;
            nudRenta.Value = 0;
            dtpFechaContrato.Value = DateTime.Now;
            dtpFechaNac.Value = DateTime.Now;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnNuevo.Enabled = false;
            btnAceptar.Enabled = true;
            txtNombres.Focus();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudISSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
