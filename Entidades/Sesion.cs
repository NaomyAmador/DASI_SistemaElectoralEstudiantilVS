using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sesion
    {
        public static Usuarios UsuarioActual {  get; set; }
        public static bool EsAdmin => UsuarioActual?.RolID == 1;
        public static void CerrarSecion()
        {
            UsuarioActual = null;
        }
    }
}
