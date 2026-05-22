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
        //Servidor Naomy Amador: LAPTOP-9G07MQQC\SQLEXPRESS
        //Servidor Arianna Cedeño: DESKTOP-BF73E8O\\SQLEXPRESS
        //Servidor Lía Torres: LILY\SQLEXPRESS

        public SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            return Conexion;
        }
    }
}
