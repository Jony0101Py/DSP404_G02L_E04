using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Guia6Ejercicio1
{
    class clsPersona
    {
        protected string nombre;
        protected string foto;
        protected DateTime fechanac;
        protected float sueldo;


        public clsPersona()
        {
            nombre = "";
            foto = "";
            fechanac = Convert.ToDateTime("1990/01/01");
        }

        public virtual void asignarfechanac(string anno, string mes, string dia)
        {
            fechanac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
            MessageBox.Show("de clase persona");
        }

        public string nombreempleado
        {
            get
            {
                return (nombre);
            }
            set
            {
                if (value.Length > 1)
                {
                    nombre = value;
                }
                else
                {
                    nombre = "";
                }
            }
        }

        public string URLfoto
        {
            get
            {
                return (foto);
            }
            set
            {
                if (nombre == "")
                {
                    MessageBox.Show("usuario no tiene aún nombre asignado");
                }
                else
                {
                    foto = Application.StartupPath + "\\" + nombre + ".jpg";
                    File.Copy(value, foto, true);
                }
            }
        }

        public float sueldobase
        {
            get
            {
                return (sueldo);
            }
            set
            {
                if (value > 0)
                {
                    sueldo = value;
                }
                else
                {
                    MessageBox.Show("Valor de sueldo incorrecto", "ERROR-SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string fecha_nacimiento
        {
            get
            {
                return (fechanac.ToShortDateString().ToString());
            }
        }


       
    }

    //Clase Derivada Doctor

    class clsDoctor : clsPersona
    {
        string cod_doctor;

        public string codigodoctor
        {
            get
            {
                return (cod_doctor);
            }
            set
            {
                cod_doctor = value;
            }
        }

        //Metodos
        public clsDoctor()
        {
            nombre = "";
            sueldo = 5;
            fechanac = Convert.ToDateTime("1990/1/1");
        }

        public override void asignarfechanac(string anno, string mes, string dia)
        {
            TimeSpan difttiempo;
            try
            {
                DateTime fnac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);

                difttiempo = fnac - DateTime.Now;

                if (difttiempo.TotalDays < -365 * 18)
                {
                    fechanac = fnac;
                }
                else
                {
                    MessageBox.Show("Fecha nacimiento debe ser al menos 18 años antes de hoy", "ERROR-Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Fecha brindada es incorrecta", "ERROR-SISTEMA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sobrecarga de Metodo
        public void asignarfechanac(string fecha)
        {
            DateTime fechafin;

            if (DateTime.TryParse(fecha, out fechafin))
            {
                fechanac = fechafin;
            }
            else
            {
                MessageBox.Show("Fecha de nacimiento es recibida", "ERROR DE SISTEMA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Datossoncorrectos()
        {
            if (nombre != "")
                if (sueldo > 0)
                    if (fechanac != Convert.ToDateTime("1990/01/01"))
                        return (true);
                    else
                        MessageBox.Show("aún no se ha asignado fecha de nacimiento");
                else
                    MessageBox.Show("Sueldo incorrecto");
            else
                MessageBox.Show("Nombre aun no asignado");
            return (false);
        }
    }

    //Clase Derivada Vendedor
    class clsVendedor : clsPersona
    {
        DateTime fechacontratac;

        public clsVendedor()
        {
            fechanac = Convert.ToDateTime("1950/01/01");
            fechacontratac = Convert.ToDateTime("2000/01/01");
        }

        public new void asignarfechanac(DateTime fechanacimiento)
        {
            fechanac = fechanacimiento;
        }

        public DateTime FechaContrato
        {
            get
            {
                return (fechacontratac);
            }
            set
            {
                this.fechacontratac = value;
            }
        }
    }
}
