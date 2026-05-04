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
    public class AddPlancha
    {
        ConexionBDD conexionBDD = new ConexionBDD();

        public int InsertarPlancha (Planchas DatosPlancha)
        {
            using (SqlConnection Conexion = conexionBDD.ObtenerConexion())
            {
                string Consulta = @"INSERT INTO Planchas (NombrePlancha, Logo, Descripcion, Activa) VALUES (@NombrePlancha, @Logo, @Descripcion, @Activa) ; SELECT SCOPE_IDENTITY ();";
                SqlCommand AgregarPlancha = new SqlCommand (Consulta, Conexion);

                AgregarPlancha.Parameters.AddWithValue("@NombrePlancha", DatosPlancha.NombrePlancha);
                AgregarPlancha.Parameters.AddWithValue("@Descripcion", DatosPlancha.Descripcion);
                AgregarPlancha.Parameters.AddWithValue("@Activa", DatosPlancha.Activa);

                if (DatosPlancha.Logo != null)
                {
                    AgregarPlancha.Parameters.Add("@Logo", SqlDbType.VarBinary).Value = DatosPlancha.Logo;
                }
                else
                {
                    AgregarPlancha.Parameters.Add("@Logo", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                int IdAgregado = Convert.ToInt32(AgregarPlancha.ExecuteScalar());
                return IdAgregado;
            }
        }
    }
}
