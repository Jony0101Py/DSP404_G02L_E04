using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_SC231259
{
    public partial class LoginForm : Form
    {

        // Simulando una base de datos con un diccionario
        private Dictionary<string, string> users;

        public LoginForm()
        {
            InitializeComponent();
            // Crear usuarios simulados
            users = new Dictionary<string, string>();
            users.Add("user1", "123456");
            users.Add("user2", "password2");
            users.Add("user3", "password3");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(username))
            {
                ShowMessage("El campo de usuario no puede estar vacío.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowMessage("El campo de contraseña no puede estar vacío.");
                return;
            }

            if (username.Length < 3 || username.Length > 20)
            {
                ShowMessage("El nombre de usuario debe tener entre 3 y 20 caracteres.");
                return;
            }

            if (password.Length < 6)
            {
                ShowMessage("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            // Verificar credenciales
            if (users.ContainsKey(username) && users[username] == password)
            {
                
                lblMessage.Text = "Login exitoso";
                lblMessage.ForeColor = System.Drawing.Color.Green;

               
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
               
                ShowMessage("Usuario o contraseña incorrectos");
            }
        }

        private void ShowMessage(string message)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
    
}
