using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    internal class clsCuenta
    {
        private int DUI;
        private decimal saldoActu;
        private decimal interesAnual;
        private DateTime fCuenta;
        private int nNum;
        private Boolean DatosCuenta;
        private Boolean DatosCompletos;
        private int n;
        private string numCuenta;

        Dictionary<int, clsCuenta> Cuentas = new Dictionary<int, clsCuenta>();
        public clsCuenta()
        {
            interesAnual = 10;
            n = 0;
            saldoActu = 0;
            DUI = 000000000;
            fCuenta = DateTime.Now;
            nNum = 1000000;
        }
        public string NumeroCuenta
        {
            get
            {
                if(fCuenta.Day < 10)
                {
                    numCuenta = "0"  + fCuenta.Day.ToString() + fCuenta.Month.ToString() + fCuenta.Year.ToString() + "-" + nNum;
                }
                if (fCuenta.Month < 10)
                {
                    numCuenta = fCuenta.Day.ToString() + "0" + fCuenta.Month.ToString() + fCuenta.Year.ToString() + "-" + nNum;
                }
                return numCuenta;
            }
        }
        public int NumeroDUI
        {
            get
            {
                return DUI;
            }
        }
        public decimal SaldoActual
        {
            get
            {
                return saldoActu;
            }
        }
        public decimal InteresAnual
        {
            get
            {
                return interesAnual;
            }
        }

        public Boolean DatosCompletados
        {
            get
            {
                return DatosCompletos;
            }
        }
        public Boolean DatosCorrectosCuenta
        {
            get
            {
                return DatosCuenta;
            }
        }

        public void ingresarCuenta(int ndui, int cuentaN, decimal saldo, decimal interesA)
        {
            DatosCuenta = false;
            //DUI
            if (ndui.ToString().Length == 0)
            {
                MessageBox.Show("Ingresa el número de dui");
                return;
            }
            else if (ndui.ToString().Length < 9)
            {
                MessageBox.Show("Ingresa el número de dui correcto");
                return;
            }
            else if (ndui.ToString().Length > 9)
            {
                MessageBox.Show("Ingresa el número de dui correto");
                return;
            }

            DUI = ndui;

            //Numero de Cuenta
            nNum = cuentaN;

            //Saldo de Cuenta
            if (saldo == 0)
            {
                MessageBox.Show("Ingresa una cantidad");
                return;
            }
            else if (saldo < 0)
            {
                MessageBox.Show("Ingresa una cantidad correcta");
                return;
            }
            else
            {
                saldoActu = saldo;
            }

            //Interes de la Cuenta
            if (interesA < 10 && interesA > 22.3m)
            {
                MessageBox.Show("Interes no válido (10%-22.3%)");
                return;
            }
            else
            {
                interesAnual = interesA;
            }
            
            DatosCuenta = true;
            n++;
        }

        public void RecibirCuenta(clsCuenta nuevaCuenta)
        {
            if (nuevaCuenta.DatosCorrectosCuenta == false)
            {
                MessageBox.Show("Datos de Cuenta Incompletos");
                return;
            }

            Cuentas.Add(n, nuevaCuenta);
            n++;
        }

        public void GenerarTabla(ref DataGridView tabla)
        {
            if (Cuentas.Count == 0)
            {
                MessageBox.Show("No se ha ingresado ninguna cuenta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tabla.Columns.Clear();
            tabla.ColumnCount = 4;
            tabla.Columns[0].Name = "Número de Cuenta";
            tabla.Columns[1].Name = "Número de DUI";
            tabla.Columns[2].Name = "Saldo de Cuenta";
            tabla.Columns[3].Name = "Interés Anual";
            tabla.Rows.Add(Cuentas.Count);

            for (int i = 0; i < n; i++)
            {
                tabla.Rows[i].Cells[0].Value = Cuentas[i].NumeroCuenta;
                tabla.Rows[i].Cells[1].Value = Cuentas[i].NumeroDUI;
                tabla.Rows[i].Cells[2].Value = Cuentas[i].SaldoActual;
                tabla.Rows[i].Cells[3].Value = Cuentas[i].InteresAnual;
            }
        }

        
        public void actualizarSaldo()
        {
            decimal nuevosaldo;
            for (int i = 0; i < Cuentas.Count; i++)
            {
                nuevosaldo = (Cuentas[i].interesAnual / 365);
                nuevosaldo *= Cuentas[i].saldoActu;
                Cuentas[i].saldoActu += nuevosaldo;
            }
            MessageBox.Show("Saldos Actualizados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Ingesar(int nCuenta, decimal ingreso)
        {
            decimal nuevolsado;
            for (int i = 0; i < Cuentas.Count; i++)
            {
                if(nCuenta == Cuentas[i].nNum)
                {
                    nuevolsado = Cuentas[i].saldoActu + ingreso;
                    Cuentas[i].saldoActu = nuevolsado;
                }
                else
                {
                    MessageBox.Show("Número de Cuenta no válido");
                    return;
                }
            }
        }
        public void Retirar(int nCuenta, decimal ingreso)
        {
            decimal nuevolsado;
            for (int i = 0; i < Cuentas.Count; i++)
            {
                if (nCuenta == Cuentas[i].nNum)
                {
                    nuevolsado = Cuentas[i].saldoActu - ingreso;
                    Cuentas[i].saldoActu = nuevolsado;
                }
                else
                {
                    MessageBox.Show("Número de Cuenta no válido");
                    return;
                }
            }
        }


    }
}
