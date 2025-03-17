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
using LaCaguama.Formularios;

namespace LaCaguama
{
    public partial class Form1: Form
    {
        Configuracion.CConexio conexion = new Configuracion.CConexio();
        public Form1()
        {
            InitializeComponent();

            Configuracion.CConexio conexion = new Configuracion.CConexio();
            conexion.EstablecerConexion();

            txtContrasena.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
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

            // Obtiene los datos del usuario
            var usuarioData = conexion.ObtenerDatosUsuario(usuario, contrasena);

            if (usuarioData != null)
            {
                // Guarda los datos en la sesión
                SesionUsuario.IdUsuario = usuarioData.Item1;
                SesionUsuario.NombreUsuario = usuario;
                SesionUsuario.Rol = usuarioData.Item2;

                MessageBox.Show("Inicio de sesión exitoso");

                // Redirige según el rol
                if (SesionUsuario.Rol == 1) // Administrador
                {
                    FormAdmin formAdmin = new FormAdmin();
                    this.Hide();
                    formAdmin.ShowDialog();
                }
                else if (SesionUsuario.Rol == 2) // Usuario normal
                {
                    FormUsuario formUsuario = new FormUsuario(); // Crea este formulario
                    this.Hide();
                    formUsuario.ShowDialog();
                }

                // Cierra el login después de abrir otro formulario
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpiar los campos de usuario y contraseña
                txtUsuario.Clear();
                txtContrasena.Clear();
            }   
        }

        private void btnMostrarContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                // Si está oculto, mostramos la contraseña en texto claro
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                // Si está visible, volvemos a ocultar la contraseña
                txtContrasena.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
