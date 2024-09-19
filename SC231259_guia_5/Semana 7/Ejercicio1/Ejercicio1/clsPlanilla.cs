using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    class clsPlanilla
    {
        private int Estado;
        private String Empresa;
        private DateTime FechaPlanilla;

        private Dictionary<int, clsEmpleado> ListaEmpleados = new Dictionary<int, clsEmpleado>();
        private int TotalEmpleados;

        public clsPlanilla()
        {
            Estado = 1;
            Empresa = "";
            FechaPlanilla = DateTime.Now;
            TotalEmpleados = 0;
        }

        public void AbrirPlanilla(DateTime fechaInicio, string nombreEmpresa = "(Sin Nombre)")
        {
            nombreEmpresa = nombreEmpresa.Trim();
            switch (Estado)
            {
                case 1:
                    FechaPlanilla = fechaInicio;
                    if (nombreEmpresa.Length > 0)
                    {
                        Empresa = nombreEmpresa;
                    }
                    Estado = 2;
                    MessageBox.Show("Planilla Abierta, inicie registro empleados", "Planilla de " + Empresa + ",APERTURA: " + FechaPlanilla.ToString());
                    break;
                case 2:
                    MessageBox.Show("Planilla ya esta abierta desde el:" + FechaPlanilla.ToString(), "Planilla de " + Empresa);
                    break;
                case 3:
                    MessageBox.Show("Planilla creada el" + FechaPlanilla.ToString() + " ya se cerro", "Planilla de" + Empresa);
                    break;
            }
        }

        public void RecibirEmpleado(clsEmpleado nuevoEmpleado)
        {
            if (Estado == 2)
            {
                if (nuevoEmpleado.datospersonales_aceptados == false)
                {
                    MessageBox.Show("Error, datos personales estan incompletos", "Control planilla");
                    return;
                }
                if (nuevoEmpleado.datospersonales_aceptados == false)
                {
                    MessageBox.Show("Error, datos laborales estan incompletos", "Control planilla");
                    return;
                }
                TotalEmpleados += 1;
                ListaEmpleados.Add(TotalEmpleados, nuevoEmpleado);
            }
            else
            {
                MessageBox.Show("Planilla aun no esta abierta", "Planilla de" + Empresa);
                return;
            }

        }

        public void GenerarListado(ref DataGridView cuadro)
        {
            int i = 1;
            string sb = "0";
            string sf = "0";

            switch(Estado)
            {
                case 1:
                    MessageBox.Show("Planilla aun no ha sido abierta", "Planilla" + Empresa);
                    return;
                case 2:
                    if (TotalEmpleados == 0)
                    {
                        MessageBox.Show("Planilla no tiene aun empleados registrados", "Planilla de " + Empresa);
                        return;
                    }
                    Estado = 3;
                    MessageBox.Show("Planilla cerrada con " + TotalEmpleados + " empleados", "Planilla de " + Empresa);
                    MessageBox.Show("Planilla abierta el " + FechaPlanilla.ToString() + " se muestra ahora!!", "Planilla de " + Empresa);
                    break;
                
            }
            //Finaliza planilla activa y la genera en un datagrid
            cuadro.Rows.Clear();
            cuadro.Columns.Clear();
            cuadro.Columns.Add("id", "num");
            cuadro.Columns.Add("nom", "nombre completo");
            cuadro.Columns.Add("sb", "sueldo base");
            cuadro.Columns.Add("sf", "sueldo neto final");
            //Alternar colores de datagridview
            cuadro.RowsDefaultCellStyle.BackColor = Color.Bisque;
            cuadro.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            foreach (var result in ListaEmpleados)
            {
                cuadro.Rows.Add();
                cuadro.Rows[i - 1].Cells[0].Value = result.Key;
                cuadro.Rows[i - 1].Cells[1].Value = result.Value.NombreCompleto;
                result.Value.VerSueldos(ref sb, ref sf);
                cuadro.Rows[i - 1].Cells[2].Value = sb;
                cuadro.Rows[i - 1].Cells[3].Value = sf;
            }
            MessageBox.Show("Planilla de pago final completa generada en pantalla!!");
        }

        public string TotaldeEmpleado
        {
            get
            {
                return TotalEmpleados.ToString();
            }
        }
    }
}
