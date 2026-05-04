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
    public class VotoDAL
    {
        ConexionBDD conexionBDD = new ConexionBDD();
        AuditoriaDAL auditoria = new AuditoriaDAL();

        public (bool exito, string mensaje) RegistrarVoto(int UsuarioID, int? PlanchaID, int VotacionID, bool EsNulo)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                SqlTransaction transaccion = Conexion.BeginTransaction();
                try
                {
                    // Doble candado dentro de la transacción
                    SqlCommand cmdVerificar = new SqlCommand(
                        "SELECT YaVoto FROM Usuarios WHERE UsuarioID = @UsuarioID",
                        Conexion, transaccion);
                    cmdVerificar.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                    bool yaVoto = Convert.ToBoolean(cmdVerificar.ExecuteScalar());

                    if (yaVoto)
                    {
                        transaccion.Rollback();
                        auditoria.RegistrarAccion(UsuarioID, "VOTO_RECHAZADO",
                            "Intento de votar más de una vez.");
                        return (false, "Este usuario ya ejerció su voto.");
                    }

                    // Insertar el voto
                    SqlCommand cmdVoto = new SqlCommand(
                        @"INSERT INTO Votos (UsuarioID, PlanchaID, VotacionID, FechaHora, EsNulo) 
                          VALUES (@UsuarioID, @PlanchaID, @VotacionID, GETDATE(), @EsNulo)",
                        Conexion, transaccion);
                    cmdVoto.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                    cmdVoto.Parameters.AddWithValue("@VotacionID", VotacionID);
                    cmdVoto.Parameters.AddWithValue("@EsNulo", EsNulo);
                    if (PlanchaID.HasValue)
                        cmdVoto.Parameters.AddWithValue("@PlanchaID", PlanchaID.Value);
                    else
                        cmdVoto.Parameters.Add("@PlanchaID", SqlDbType.Int).Value = DBNull.Value;
                    cmdVoto.ExecuteNonQuery();

                    // Marcar usuario como que ya votó
                    SqlCommand cmdMarcar = new SqlCommand(
                        "UPDATE Usuarios SET YaVoto = 1 WHERE UsuarioID = @UsuarioID",
                        Conexion, transaccion);
                    cmdMarcar.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                    cmdMarcar.ExecuteNonQuery();

                    transaccion.Commit();

                    // Auditoría DESPUÉS del commit (no dentro de la transacción)
                    auditoria.RegistrarAccion(UsuarioID, "VOTO_EMITIDO",
                        EsNulo ? "Voto nulo emitido." : "Voto válido emitido.");

                    return (true, "¡Voto registrado exitosamente!");
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    return (false, $"Error al registrar el voto: {ex.Message}");
                }
            }
        }

        public bool UsuarioYaVoto(int UsuarioID)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand votacion = new SqlCommand(
                    "SELECT YaVoto FROM Usuarios WHERE UsuarioID = @UsuarioID", Conexion);
                votacion.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                return Convert.ToBoolean(votacion.ExecuteScalar());
            }
        }

        public bool UsuarioPerteneceAlPadron(int UsuarioID)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand votacion = new SqlCommand(
                    @"SELECT COUNT(*) FROM Usuarios u
                      INNER JOIN Padron p ON u.PadronID = p.PadronID
                      WHERE u.UsuarioID = @UsuarioID AND u.Activo = 1", Conexion);
                votacion.Parameters.AddWithValue("@UsuarioID", UsuarioID);
                return Convert.ToInt32(votacion.ExecuteScalar()) > 0;
            }
        }

        public Votacion ObtenerVotacionActiva()
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand votacion = new SqlCommand(
                    @"SELECT TOP 1 VotacionID, NombreVotacion, FechaInicio, FechaFin, Activa 
                      FROM Votacion WHERE Activa = 1 
                      AND GETDATE() BETWEEN FechaInicio AND FechaFin", Conexion);
                SqlDataReader reader = votacion.ExecuteReader();
                if (reader.Read())
                    return new Votacion
                    {
                        VotacionID = Convert.ToInt32(reader["VotacionID"]),
                        NombreVotacion = reader["NombreVotacion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                        Activa = Convert.ToBoolean(reader["Activa"])
                    };
                return null;
            }
        }



    }
}
