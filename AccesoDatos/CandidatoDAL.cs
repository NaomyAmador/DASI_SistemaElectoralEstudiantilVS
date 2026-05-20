using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CandidatoDAL
    {
        private ConexionBDD conexionBDD = new ConexionBDD();

        // =====================================
        // OBTENER TODOS LOS CANDIDATOS
        // =====================================
        public List<Candidatos> ObtenerTodosLosCandidatos()
        {
            List<Candidatos> lista = new List<Candidatos>();

            using (SqlConnection conexion =
                conexionBDD.ObtenerConexion())
            {
                string consulta = @"SELECT 
                                        CandidatoID,
                                        PlanchaID,
                                        Nombre,
                                        Cargo,
                                        Edad,
                                        Descripcion
                                    FROM Candidatos";

                SqlCommand cmd =
                    new SqlCommand(consulta, conexion);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    Candidatos c = new Candidatos();

                    c.CandidatoID =
                        Convert.ToInt32(reader["CandidatoID"]);

                    c.PlanchaID =
                        Convert.ToInt32(reader["PlanchaID"]);

                    c.Nombre =
                        reader["Nombre"].ToString();

                    c.Cargo =
                        reader["Cargo"].ToString();

                    if (reader["Edad"] != DBNull.Value)
                    {
                        c.Edad =
                            Convert.ToInt32(reader["Edad"]);
                    }

                    c.Descripcion =
                        reader["Descripcion"].ToString();

                    lista.Add(c);
                }
            }

            return lista;
        }

        // =====================================
        // VALIDAR SI YA EXISTE ESE CARGO
        // EN LA PLANCHA
        // =====================================
        public bool ExisteCargoEnPlancha(
            int planchaID,
            string cargo,
            int candidatoID = 0)
        {
            using (SqlConnection conexion =
                conexionBDD.ObtenerConexion())
            {
                string consulta = @"SELECT COUNT(*)
                                    FROM Candidatos
                                    WHERE PlanchaID = @PlanchaID
                                    AND Cargo = @Cargo
                                    AND CandidatoID != @CandidatoID";

                SqlCommand cmd =
                    new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue(
                    "@PlanchaID",
                    planchaID);

                cmd.Parameters.AddWithValue(
                    "@Cargo",
                    cargo);

                cmd.Parameters.AddWithValue(
                    "@CandidatoID",
                    candidatoID);

                return Convert.ToInt32(
                    cmd.ExecuteScalar()) > 0;
            }
        }

        // =====================================
        // ACTUALIZAR CANDIDATO
        // =====================================
        public bool ActualizarCandidato(
            Candidatos candidato)
        {
            using (SqlConnection conexion =
                conexionBDD.ObtenerConexion())
            {
                string consulta = @"UPDATE Candidatos
                                    SET Nombre = @Nombre,
                                        Cargo = @Cargo,
                                        Edad = @Edad,
                                        Descripcion = @Descripcion
                                    WHERE CandidatoID = @CandidatoID";

                SqlCommand cmd =
                    new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue(
                    "@Nombre",
                    candidato.Nombre);

                cmd.Parameters.AddWithValue(
                    "@Cargo",
                    candidato.Cargo);

                cmd.Parameters.AddWithValue(
                    "@Edad",
                    candidato.Edad);

                cmd.Parameters.AddWithValue(
                    "@Descripcion",
                    candidato.Descripcion);

                cmd.Parameters.AddWithValue(
                    "@CandidatoID",
                    candidato.CandidatoID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // =====================================
        // ELIMINAR
        // =====================================
        public bool EliminarCandidato(
            int candidatoID)
        {
            using (SqlConnection conexion =
                conexionBDD.ObtenerConexion())
            {
                string consulta = @"DELETE FROM Candidatos
                                    WHERE CandidatoID = @CandidatoID";

                SqlCommand cmd =
                    new SqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue(
                    "@CandidatoID",
                    candidatoID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
