using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioNegocio
    {
        DatosUsuario Datos = new DatosUsuario();
        public Usuarios Login(string usuario, string password)
        {
            if (usuario == "")
            {
                throw new Exception("Ingrese el Usuario");
            }

            if (password == "")
            {
                throw new Exception("Ingrese la Contraseña");
            }

            Usuarios User = Datos.Login(usuario, password);
            if (User == null)
            {
                throw new Exception("Usuario o Contraseña incorrectas");
            }

            return User;
        }
    }
}
