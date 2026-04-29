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
        private string CadenaConexion = "server=LAPTOP-PHTCMGVS\\SQLEXPRESS; database=SistemaVotacionEscolar; integrated security=true;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            Conexion.Open();
            return Conexion;
        }
    }
}
