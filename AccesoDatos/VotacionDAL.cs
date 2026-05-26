using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VotacionDAL
    {
        ConexionBDD conexionBDD = new ConexionBDD();
        public Votacion ObtenerVotacionActiva()
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                Conexion.Open();
                string Consulta = "SELECT TOP 1 * FROM Votacion WHERE Activa = 1";
                //string Consulta = "SELECT TOP 1 VotacionID, NombreVotacion, FechaInicio, FechaFin, Activa FROM Votacion WHERE Activa = 1 AND GETDATE() BETWEEN FechaInicio AND FechaFin";
                SqlCommand votacion = new SqlCommand(Consulta, Conexion);
                SqlDataReader reader = votacion.ExecuteReader();

                if (reader.Read())
                
                    return new Votacion
                    {
                        VotacionID =        Convert.ToInt32(reader["VotacionID"]),
                        NombreVotacion =    reader["NombreVotacion"].ToString(),
                        FechaInicio =       Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin =          Convert.ToDateTime(reader["FechaFin"]),
                        Activa =            Convert.ToBoolean(reader["Activa"])
                    };

                return null;
            }
        }

        public int ObtenerTotalVotantes()
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                Conexion.Open();
                SqlCommand votacion = new SqlCommand(
                    "SELECT COUNT(*) FROM Usuarios WHERE RolID = 2 AND Activo = 1",
                    Conexion);
                return Convert.ToInt32(votacion.ExecuteScalar());

            }
        }

        public int ObtenerTotalVotosEmitidos(int VotacionID)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                Conexion.Open();
                SqlCommand votacion = new SqlCommand(
                    "SELECT COUNT(*) FROM Votos WHERE VotacionID = @VotacionID",
                    Conexion);
                votacion.Parameters.AddWithValue("@VotacionID", VotacionID);
                return Convert.ToInt32(votacion.ExecuteScalar());
                
            }    
        }

        public int ObtenerVotosPorPlancha(int PlanchaID, int VotacionID)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                Conexion.Open();
                SqlCommand votacion = new SqlCommand(
                    "SELECT COUNT(*) FROM Votos WHERE PlanchaID = @PlanchaID AND VotacionID = @VotacionID AND EsNulo = 0",
                    Conexion);
                votacion.Parameters.AddWithValue("@PlanchaID", PlanchaID);
                votacion.Parameters.AddWithValue("@VotacionID", VotacionID);
                return Convert.ToInt32(votacion.ExecuteScalar());
            }
        }

        public int ObtenerVotosNulos(int VotacionID)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                Conexion.Open();
                SqlCommand votacion = new SqlCommand(
                    "SELECT COUNT(*) FROM Votos WHERE VotacionID = @VotacionID AND EsNulo = 1",
                    Conexion);
                votacion.Parameters.AddWithValue("@VotacionID", VotacionID);
                return Convert.ToInt32(votacion.ExecuteScalar());
            }
        }
    }
}
