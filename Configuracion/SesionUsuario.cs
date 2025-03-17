using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCaguama.Configuracion
{
    class SesionUsuario
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static int Rol { get; set; } // 1 = Administrador, 2 = Usuario

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = "";
            Rol = 0;
        }
    }
}
