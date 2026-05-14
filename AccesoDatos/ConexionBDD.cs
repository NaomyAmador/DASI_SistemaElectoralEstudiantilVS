using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionBDD
    {
        private string CadenaConexion = "Data Source=LILY\\SQLEXPRESS;Initial Catalog=SistemaVotacionEscolar;Integrated Security=True;";
        //Servidor Naomy Amador: LAPTOP-9G07MQQC\SQLEXPRESS
        //Servidor Arianna Cedeño: LAPTOP-PHTCMGVS\SQLEXPRESS
        //Servidor Lía Torres: LILY\SQLEXPRESS

        public SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            Conexion.Open();
            return Conexion;
        }
    }
}
