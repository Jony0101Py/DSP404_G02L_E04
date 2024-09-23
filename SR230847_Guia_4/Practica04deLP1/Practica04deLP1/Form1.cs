
namespace Practica04deLP1
{
    public partial class Form1 : Form
    {
        //creacion de subrutina a utilizar
        private void presentacInic()
        {
            //prepara controles antes de mostrar form al usuario
            grbResult.Visible = false;
            nupBase.Focus();
        }
        private void HacerCalculos(Decimal N)
        {
            /*Se prepara a calcular tablas (de multiplicar y potencia)
            segun valor de variable argumentos N*/
            int c;
            decimal res;
            lstTabla1.Items.Clear();
            c = 1;
            do
            {
                res = N * c;
                lstTabla1.Items.Add(N.ToString() + "X" + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (!(c > 10));
            //Genera la portencia de las tablas
            lstTabla2.Items.Clear();
            c = 1;
            do
            {
                res = Elevar(N, c);
                lstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (c <= 10);
        }
        private decimal Elevar(decimal B, int expo)
        {
            //remplaza a operador pow que calcula la potencia de argumentos (Bpow(expo))
            int i = 1;
            decimal r = 1;
            do
            {
                r *= B;
                i += 1;
            } while (!(i > expo));
            return r;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            //Invoca a subrituna HacerCalculos
            decimal n = nupBase.Value;
            HacerCalculos(n);
            //Muestra resultados
            grbResult.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presentacInic();
        }
    }
}
