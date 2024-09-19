using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
{
    internal class clsAnimales
    {
        protected string nomComun;
        protected string nomCien;
        protected string foto;
        protected string familia;
        protected string habitat;
        protected DateTime fecharegistro;

        public clsAnimales()
        {
            nomComun = "";
            nomCien = "";
            foto = "";
            familia = "";
            habitat = "";
            fecharegistro = DateTime.Now;
        }

        public string nombreComun
        {
            get { return (nomComun); }
            set { if (value.Length > 1) nomComun = value;
                else nomComun = "";
            }
        }

        public string nombreCient
        {
            get { return(nomCien);}
            set { if (value.Length > 1) { nomCien = value; }
                else nomCien = "";
            }
        }

        public string urlFoto
        {
            get { return (foto); }
            set { 
                if (nomComun == "")
                {
                    MessageBox.Show("No ha registrado el nombre del animal");
                }
                else
                {
                    foto = Application.StartupPath + "\\" + nomComun + ".jpg";
                    File.Copy(value, foto, true);
                }
            }
        }

        public string nFamilia
        {
            get { return (familia); }
            set { if (value.Length > 1) { familia = value; }
                else familia = "";
            }
        }

        public string nHabitat
        {
            get { return (habitat); }
            set { if (value.Length > 1) { habitat = value; }
                else habitat = "";
            }
        }

        public string fecha_res
        {
            get { return (fecharegistro.ToShortDateString().ToString()); }
        }
    }

    //Clase Derivada Mamifero
    class clsMamifero : clsAnimales
    {
        string des_embrio;
        int cant_mamas;

        public string desarrollo_embrionario
        {
            get
            {
                return (des_embrio);
            }
            set
            {
                des_embrio = value;
            }
        }

        public int cantidad_mamas
        {
            get 
            { 
                return (cant_mamas); 
            }
            set
            {
                cant_mamas = value;
            }

        }

        public clsMamifero()
        {
            fecharegistro = DateTime.Now;
            des_embrio = "";
            cant_mamas = 0;
        }

        public void asig_fechres(DateTime fecharegistrada)
        {
            if (fecharegistrada > Convert.ToDateTime("2000/01/01"))
            {
                fecharegistro = fecharegistrada;
            }
            else
            {
                MessageBox.Show("Fecha fuera de rango (01/01/2000 en adelante)");
            }
        }

        public bool datoscompletos()
        {
            if (nomComun != "")
                if (nomCien != "")
                    if (familia != "")
                        if (habitat != "")
                            if (fecharegistro != Convert.ToDateTime("2000/01/01"))
                                if (des_embrio != "")
                                    if (cant_mamas > 0)
                                        return (true);
                                    else MessageBox.Show("Ingresa una cantidad de Mamas");
                                else MessageBox.Show("Seleccione un tipo de Desarrollo Embrionario");
                            else MessageBox.Show("Ingrese una fecha dentro del rango");
                        else MessageBox.Show("Selecciona un habitad");
                    else MessageBox.Show("Selecciona una familia");
                else MessageBox.Show("Ingrese el nombre cientifico");
            else MessageBox.Show("Ingrese el nombre del animal");
            return (false);
        }
    }
}
