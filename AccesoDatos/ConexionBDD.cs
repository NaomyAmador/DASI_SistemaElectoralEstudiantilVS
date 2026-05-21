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
        private string CadenaConexion = "server=DESKTOP-BF73E8O\\SQLEXPRESS; database=SistemaVotacionEscolar; integrated security=true;";
        //Servidor Naomy Amador: DESKTOP-BF73E8O\SQLEXPRESS
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
