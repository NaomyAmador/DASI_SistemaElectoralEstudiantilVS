using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class RegistrarUsuario
    {
        ConexionBDD conexionBDD = new ConexionBDD();
        public bool RegistrarUsusario(string NombreCompleto, string Usuario, String Contraseña, string Correo,string Matricula, string Curso, string Seccion)
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


    }
}
