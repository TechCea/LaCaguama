using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaCaguama.Configuracion;

namespace LaCaguama.Formularios
{
    public partial class FormUsuario: Form
    {
        public FormUsuario()
        {
            InitializeComponent();

            // Si el usuario no es normal (rol 2), cierra el formulario
            if (SesionUsuario.Rol != 2)
            {
                MessageBox.Show("Acceso denegado. No tienes permisos de usuario.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click_Click(object sender, EventArgs e)
        {
            // Cierra la sesión
            SesionUsuario.CerrarSesion();

            // Vuelve al formulario de login
            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnIrAAdmin_Click_Click(object sender, EventArgs e)
        {
            SesionUsuario.CerrarSesion(); // Limpiar datos de sesión
            Form1 loginForm = new Form1();
            this.Hide(); // Ocultar la ventana actual
            loginForm.ShowDialog(); // Mostrar login
            this.Close();
        }
    }
}
