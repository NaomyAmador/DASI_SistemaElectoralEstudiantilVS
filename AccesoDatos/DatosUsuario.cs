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
        public Usuarios Login(string Usuario, string Password)
        {
            using (SqlConnection Conexion = conexionBD.ObtenerConexion())
            {
                Conexion.Open();
                SqlCommand Procedimiento = new SqlCommand("LoginUsuario", Conexion);
                Procedimiento.CommandType = CommandType.StoredProcedure;
                Procedimiento.Parameters.AddWithValue("@Usuario", Usuario);
                Procedimiento.Parameters.AddWithValue("@Password", Password);

                using (SqlDataReader LecturaDatos = Procedimiento.ExecuteReader())
                {
                    Usuarios User = null;
                    if (LecturaDatos.Read())
                    {
                        User = new Usuarios();
                        User.UsuarioID = Convert.ToInt32(LecturaDatos["UsuarioID"]);
                        User.NombreCompleto = LecturaDatos["NombreCompleto"].ToString();
                        User.Usuario = LecturaDatos["Usuario"].ToString();
                        User.Correo = LecturaDatos["Correo"].ToString();
                        User.Matricula = LecturaDatos["Matricula"].ToString();
                        User.Curso = LecturaDatos["Curso"].ToString();
                        User.Seccion = LecturaDatos["Seccion"].ToString();
                        User.RolID = Convert.ToInt32(LecturaDatos["RolID"]);
                        return User;
                    }

                    return null;
                }
            }
        }

    }
}
