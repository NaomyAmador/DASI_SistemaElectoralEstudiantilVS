using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class UsuarioDAL
    {
        ConexionBDD conexionBDD = new ConexionBDD();

            public Usuarios ObtenerUsuarioPorID(int UsuarioID)
            {
                using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
                {
                
                    SqlCommand usuario = new SqlCommand(
                        @"SELECT UsuarioID, NombreCompleto, Usuario, Matricula, 
                             Curso, Seccion, YaVoto, Activo, RolID, PadronID 
                      FROM Usuarios WHERE UsuarioID = @UsuarioID", Conexion);
                   Conexion.Open();
                usuario.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                    SqlDataReader reader = usuario.ExecuteReader();

                    if (reader.Read())
                        return new Usuarios
                        {
                            UsuarioID =         Convert.ToInt32(reader["UsuarioID"]),
                            NombreCompleto =    reader["NombreCompleto"].ToString(),
                            Matricula =         reader["Matricula"].ToString(),
                            Curso =             reader["Curso"].ToString(),
                            Seccion =           reader["Seccion"].ToString(),
                            YaVoto =            Convert.ToBoolean(reader["YaVoto"]),
                            Activo =            Convert.ToBoolean(reader["Activo"]),
                            RolID =             Convert.ToInt32(reader["RolID"]),
                            PadronID =          Convert.ToInt32(reader["PadronID"])
                        };
                    return null;
                }
            }
        
    }
}
