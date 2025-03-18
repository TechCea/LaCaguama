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
    public partial class FormUsuariosAdmin: Form
    {
        CConexio conexion = new CConexio();
        public FormUsuariosAdmin()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = conexion.ObtenerUsuarios();
        }

        private void FormUsuariosAdmin_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            DataTable dtRoles = conexion.ObtenerRoles(); // Necesitas crear este método en `CConexio`
            cmbRol.DataSource = dtRoles;
            cmbRol.DisplayMember = "nombre_rol";
            cmbRol.ValueMember = "id_rol";
        }
     
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarUsuarios();

            if (e.RowIndex >= 0) // Verifica que se hizo clic en una fila válida
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtNombreU.Text = fila.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                txtContraseñaU.Text = fila.Cells["Contraseña"].Value.ToString();
                cmbRol.Text = fila.Cells["Rol"].Value.ToString();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarU_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreU.Text;
            string correo = txtCorreo.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseñaU.Text;
            string telefono = txtTelefono.Text;
            int idRol = Convert.ToInt32(cmbRol.SelectedValue);

            if (conexion.AgregarUsuario(nombre, correo, usuario, contrasena, telefono, idRol))
            {
                MessageBox.Show("Usuario agregado correctamente");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Error al agregar usuario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
