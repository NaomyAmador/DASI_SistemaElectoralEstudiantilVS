using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AddCandidato
    {
        ConexionBDD conexionBDD = new ConexionBDD();
        public int InsertarCandidato(Candidatos DatosCandidato)
        {
            using (SqlConnection Conexión = conexionBDD.ObtenerConexion())
            {
                string Consulta = @"INSERT INTO Candidatos (PlanchaID, Nombre, Cargo, Edad, Descripcion) VALUES (@PlanchaID, @Nombre, @Cargo, @Edad,@Descripcion); SELECT SCOPE_IDENTITY();";

                SqlCommand AgregarCandidato = new SqlCommand(Consulta, Conexión);

                AgregarCandidato.Parameters.AddWithValue("@PlanchaID", DatosCandidato.PlanchaID);
                AgregarCandidato.Parameters.AddWithValue("@Nombre", DatosCandidato.Nombre);
                AgregarCandidato.Parameters.AddWithValue("@Cargo", DatosCandidato.Cargo);
                AgregarCandidato.Parameters.AddWithValue("@Edad", DatosCandidato.Edad);
                AgregarCandidato.Parameters.AddWithValue("@Descripcion", DatosCandidato.Descripcion);
                

                int IdAgregado = Convert.ToInt32(AgregarCandidato.ExecuteScalar());
                return IdAgregado;
            }
        }
    }
}
