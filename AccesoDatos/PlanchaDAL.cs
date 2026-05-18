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
    public class PlanchaDAL
    {
        ConexionBDD conexionBDD = new ConexionBDD();

        public bool ExisteNombrePlancha (string NombrePlancha)
        {
            using(SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                string Consulta = "SELECT COUNT (*) FROM Planchas WHERE NombrePlancha = @NombrePlancha";
                SqlCommand nombreplancha = new SqlCommand(Consulta, Conexion);
                nombreplancha.Parameters.AddWithValue("@NombrePlancha", NombrePlancha);
                return Convert.ToInt32(nombreplancha.ExecuteScalar()) > 0;
            }
            
        }

        public List<Planchas> ObtenerTodasLasPlanchas()
        {
            List<Planchas> Lista = new List <Planchas>();
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                string Consulta = "SELECT PlanchaID, NombrePlancha, Logo, Descripcion, Activa FROM Planchas WHERE Activa = 1";
                SqlCommand Planchas = new SqlCommand(Consulta,Conexion);
                SqlDataReader reader = Planchas.ExecuteReader();
                while (reader.Read())
                {
                    Planchas p = new Planchas();
                    p.PlanchaID =       Convert.ToInt32(reader["PlanchaID"]);
                    p.NombrePlancha =   reader["NombrePlancha"].ToString();
                    p.Descripcion =     reader["Descripcion"].ToString();
                    p.Activa =          Convert.ToBoolean(reader["Activa"]);
                    p.Logo =            reader["Logo"] != DBNull.Value ? (byte[])reader["Logo"] : null;
                    Lista.Add(p);
                }
            }
            return Lista;
        }

        public List<Candidatos> ObtenerCandidatosPorPlancha(int planchaID)
        {
            List<Candidatos> Lista = new List<Candidatos>();
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                string Consulta = "SELECT CandidatoID, PlanchaID, Nombre, Cargo, Edad, Descripcion FROM Candidatos WHERE PlanchaID = @PlanchaID";
                SqlCommand id = new SqlCommand(Consulta, Conexion);
                id.Parameters.AddWithValue("@PlanchaID", planchaID);
                SqlDataReader reader = id.ExecuteReader();
                while (reader.Read())
                {
                    Candidatos c = new Candidatos();
                    c.CandidatoID =     Convert.ToInt32(reader["CandidatoID"]);
                    c.PlanchaID =       Convert.ToInt32(reader["PlanchaID"]);
                    c.Nombre =          reader["Nombre"].ToString();
                    c.Cargo =           reader["Cargo"].ToString();
                    c.Descripcion =     reader["Descripcion"].ToString();

                    if (reader["Edad"] != DBNull.Value)
                        c.Edad = Convert.ToInt32(reader["Edad"]);
                    Lista.Add(c);
                }
            }
            return Lista;
        }

        
        public bool DesactivarPlancha(int planchaID)
        {
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                string consulta = "UPDATE Planchas SET Activa = 0 WHERE PlanchaID = @PlanchaID";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@PlanchaID", planchaID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActivarPlancha(int planchaID)
        {
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                string consulta = "UPDATE Planchas SET Activa = 1 WHERE PlanchaID = @PlanchaID";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@PlanchaID", planchaID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ActualizarPlancha (Planchas DatosPlancha)
        {
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                string consulta = "UPDATE Planchas SET NombrePlancha = @NombrePlancha, Logo = @Logo, Descripcion = @Descripcion, Activa = @Activa WHERE PlanchaID =@PlanchaID";
                SqlCommand cmd = new SqlCommand( consulta, conexion);
                cmd.Parameters.AddWithValue("@NombrePlancha" , DatosPlancha.NombrePlancha);
                cmd.Parameters.AddWithValue("@Descripcion", DatosPlancha.Descripcion);
                cmd.Parameters.AddWithValue("@NombrePlancha", DatosPlancha.NombrePlancha);
                cmd.Parameters.AddWithValue("@PlanchaID", DatosPlancha.PlanchaID);

                if (DatosPlancha.Logo != null)
                {
                    cmd.Parameters.Add("@Logo", SqlDbType.VarBinary).Value = DatosPlancha.Logo;
                }
                else
                {
                    cmd.Parameters.Add("@Logo", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarPlancha(int PlanchaID)
        {
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                string consulta = "DELETE FROM Planchas WHERE PlanchaID =@PlanchaID";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@PlanchaID", PlanchaID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
