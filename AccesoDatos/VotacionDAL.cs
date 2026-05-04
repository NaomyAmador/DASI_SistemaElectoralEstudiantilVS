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
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                string Consulta = @""
            }
        }
    }
}
