using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCaguama.Formularios
{
    public partial class LoginForm: Form
    {
        Configuracion.CConexio conexion = new Configuracion.CConexio();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (conexion.ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                Form1 formPrincipal = new Form1();
                this.Hide(); // Ocultar el formulario de login
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
