﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LaCaguama.Configuracion
{
    class CConexio
    {
        private MySqlConnection conectar = null;

        private static string usuario = "root";
        private static string contrasenia = "root";
        private static string bd = "LaCaguamaBD";
        private static string ip = "localhost";
        private static string puerto = "3306";

        string cadenaConexion = $"Server={ip};Port={puerto};Database={bd};User Id={usuario};Password={contrasenia};";


        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conectar = new MySqlConnection(cadenaConexion);
                conectar.Open();
                MessageBox.Show("Conexión establecida");
                return conectar;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al establecer la conexión");
            }
            return conectar;
        }


        public void CerrarConexion()
        {
            try
            {
                if(conectar != null && conectar.State == System.Data.ConnectionState.Open)           
                    conectar.Close();
                    MessageBox.Show("Conexión cerrada");
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cerrar la conexión" + e.ToString());
            }
        }

    }
}
