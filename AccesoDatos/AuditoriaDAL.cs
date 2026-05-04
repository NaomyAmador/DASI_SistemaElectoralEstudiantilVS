using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AuditoriaDAL
    {
        ConexionBDD conexionBDD = new ConexionBDD();
        public void RegistrarAccion(int? UsuarioID, string Accion, string Detalle)
        {
            try
            {
                using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
                {
                    string Consulta = @"INSERT INTO AuditoriaAcciones(UsuarioID, Accion, FechaHora, Detalle) VALUES (@UsuarioID, @Accion, @FechaHora, @Detalle)";
                    SqlCommand aud = new SqlCommand(Consulta, Conexion);
                    aud.Parameters.AddWithValue("@UsuarioID",
                        UsuarioID.HasValue ? (object)UsuarioID.Value : DBNull.Value);
                    aud.Parameters.AddWithValue("Accion", Accion);
                    aud.Parameters.AddWithValue("Detalle",Detalle);
                    aud.ExecuteNonQuery();
                }


            }
            catch { }
        }
    }
}
