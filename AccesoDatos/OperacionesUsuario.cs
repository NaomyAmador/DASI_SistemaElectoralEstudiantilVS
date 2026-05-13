using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class OperacionesUsuario
    {

        Usuarios User;
        ConexionBDD conexionBDD = new ConexionBDD();

        public Usuarios VerUsuarios(string Usuario, string @Contraseña)
        {

            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MostrarDatosUsuario", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())

                {
                    Usuarios User = new Usuarios()

                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        NombreCompleto = dr["NombreCompleto"].ToString(),
                        Usuario = dr["Usuario"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Curso = dr["Curso"].ToString(),
                        Seccion = dr["Seccion"].ToString(),
                        RolID = Convert.ToInt32(dr["RolID"])

                    };

                }
                return User;


            }

        }
        public bool RegistrarUsusario(string NombreCompleto, string Usuario, String Contraseña, string Correo, string Matricula, string Curso, string Seccion)
        {
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand("RegistrarUsuario", conexion);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Contraseña", Contraseña);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@Matricula", Matricula);
                command.Parameters.AddWithValue("@Curso", Curso);
                command.Parameters.AddWithValue("@Seccion", Seccion);

                SqlDataReader reader = command.ExecuteReader();

                if ((reader.Read()))
                {
                    return true;

                }

                else
                {
                    return false;
                }
            }

        }

                public bool EliminarUsuario(int ID)
                 {
            try 
            {
                using (SqlConnection conexion = conexionBDD.ObtenerConexion())
                {

                    SqlCommand command = new SqlCommand("BorrarUsuario", conexion);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UsuarioID", ID);

                    command.ExecuteNonQuery();

                    return true;
                }
            }

            catch
            {
                return false;
            }

        }


        public bool ActualizarUsuario(Usuarios usuario)
        {
            try
            {
                using (SqlConnection conexion = conexionBDD.ObtenerConexion())
                {
                    SqlCommand command = new SqlCommand("ActualizarUsuario", conexion);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                    command.Parameters.AddWithValue("@Correo", usuario.Correo);
                    command.Parameters.AddWithValue("@Matricula", usuario.Matricula);
                    command.Parameters.AddWithValue("@Curso", usuario.Curso);
                    command.Parameters.AddWithValue("@Seccion", usuario.Seccion);

                    command.ExecuteNonQuery();

                    return true;

                }
            }
            catch
            {
                return false;
            }

         
        }

    }
}
  
