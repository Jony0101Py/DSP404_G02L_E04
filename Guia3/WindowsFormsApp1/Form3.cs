using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        Dictionary<string, string> palabras = new Dictionary<string, string>();


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //agregamos datos al diccionario
            palabras.Add("Manzana", "Fruta pomácea comestible, fruto\n del manzano doméstico (Malusdomestica)\n, otros manzanos(especies del género\n Malus).");
            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conocecoloquialmente como peral común.Existen, de todas maneras, muchas clases de peras, que sonproducidas por otros árboles del género Pyrus.");
            palabras.Add("Melocotón", "Fruto del melocotonero. Es una drupa de olor agradable, esférica, deseis a ocho centímetros de diámetro, con un surco profundo que ocupa media circunferencia,epicarpio delgado, velloso, de color amarillo con manchas encarnadas, mesocarpio amarillento, desabor agradable y adherido a un hueso pardo, duro y rugoso, que encierra una almendra muyamarga.");
            //recorre el diccionario para llenar la lista con la llave
            foreach (var item in palabras.Keys)
            {
                lstPalabras.Items.Add(item);
            }
        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPalabras.Text;
            //buscamos dato de la lista dentro del diccionario
            for (int i = 0; i < palabras.Count; i++)
            {
                var item = palabras.ElementAt(i);
                if (buscar == item.Key)
                {
                    lblpalabra.Text = item.Key;
                    txtsignificado.Text = item.Value;
                    break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
