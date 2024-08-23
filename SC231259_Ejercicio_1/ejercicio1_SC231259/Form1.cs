using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_SC231259
{

    public partial class BienvenidaForm : Form
    {

        private Timer timer;
        public BienvenidaForm()
        {
            InitializeComponent();
            // Configurar el Timer
            timer1.Interval = 15000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private bool loginFormOpened = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!loginFormOpened)
            {
                timer1.Stop(); 
                this.Hide(); 

                // Mostrar la pantalla de Login
                LoginForm login = new LoginForm();
                login.Show();
                loginFormOpened = true; 
            }
        }
    }
}
