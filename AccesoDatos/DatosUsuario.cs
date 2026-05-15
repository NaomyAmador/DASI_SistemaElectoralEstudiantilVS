using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class DatosUsuario
    {
        ConexionBDD conexionBD = new ConexionBDD();
        public LoginUsuario Login(string usuario, string password)
        {
            SqlConnection conexion = conexionBD.ObtenerConexion();
            SqlCommand Procedimiento = new SqlCommand("LoginUsuario", conexion);
            
            Procedimiento.CommandType = CommandType.StoredProcedure;
            Procedimiento.Parameters.AddWithValue("@Usuario", usuario);
            Procedimiento.Parameters.AddWithValue("@Password", password);
            
            SqlDataReader LecturaDatos = Procedimiento.ExecuteReader();
            //Variable vacía a utilizar más adelante
            LoginUsuario User = null;

            if (LecturaDatos.Read())
            {
                //Objeto a usar: User
                User = new LoginUsuario();

                //Llenar datos mediante el Objeto
                User.UsuarioID = Convert.ToInt32(LecturaDatos["UsuarioID"]);
                User.NombreCompleto = LecturaDatos["NombreCompleto"].ToString();
                User.UsuarioLogin = LecturaDatos["Usuario"].ToString();
                User.Correo = LecturaDatos["Correo"].ToString();
                User.Matricula = LecturaDatos["Matricula"].ToString();
                User.Curso = LecturaDatos["Curso"].ToString();
                User.Seccion = LecturaDatos["Seccion"].ToString();
                User.RolID =Convert.ToInt32(LecturaDatos["RolID"]);
            }

            conexion.Close();

            return User;
        }

    }
}
