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
    public partial class FormAdmin: Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            // Si el usuario no es administrador, cierra el formulario
            if (SesionUsuario.Rol != 1)
            {
                MessageBox.Show("Acceso denegado. No tienes permisos de administrador.", "Acceso Restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuariosAdmin formUsuarios = new FormUsuariosAdmin();
            formUsuarios.ShowDialog();
        }
    }
}
