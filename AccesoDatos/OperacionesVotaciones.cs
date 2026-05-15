using Entidades;
using  System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AccesoDatos
{
    public class OperacionesVotaciones
    {

        ConexionBDD conexion = new ConexionBDD();

        public List<Planchas> MostrarPlanchas()
        {
            List<Planchas> lista = new List<Planchas>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MostrarPlanchas", cn);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader dr =  cmd.ExecuteReader();

                while (dr.Read())
                {
                    Planchas plancha =  new Planchas();

                    plancha.PlanchaID = Convert.ToInt32( dr["PlanchaID"]);

                    plancha.NombrePlancha = dr["NombrePlancha"].ToString();

                    plancha.Descripcion = dr["Descripcion"].ToString();

                    if (dr["Logo"] != DBNull.Value)
                    {
                        plancha.Logo =(byte[])dr["Logo"];
                    }

                    lista.Add(plancha);
                }
            }

            return lista;
        }


        public List<Candidatos>
    MostrarCandidatosPorPlancha(
        string nombrePlancha)
        {
            List<Candidatos> lista =
                new List<Candidatos>();

            using (SqlConnection cn =
                conexion.ObtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "MostrarCandidatosPorPlancha",
                        cn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@NombrePlancha",
                    nombrePlancha);

 
                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    Candidatos candidato =
                        new Candidatos();

                    candidato.CandidatoID =
                        Convert.ToInt32(
                            dr["CandidatoID"]);

                    candidato.NombrePlancha =
                        dr["NombrePlancha"].ToString();

                    candidato.Nombre =
                        dr["Nombre"].ToString();

                    candidato.Cargo =
                        dr["Cargo"].ToString();

                    candidato.Edad =
                        Convert.ToInt32(
                            dr["Edad"]);

                    candidato.Descripcion =
                        dr["Descripcion"].ToString();

                    lista.Add(candidato);
                }
            }
            
            return lista;
        }

        public bool VerificarSiUsuarioYaVoto(int usuarioID)
        {
            try
            {

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    {
                        SqlCommand cmd = new SqlCommand("VerificarSiUsuarioYaVoto", cn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            return Convert.ToBoolean(resultado);
                        }

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error verificando voto", ex);
            }
        }

        public bool RegistrarVotoPlancha( int usuarioID,int planchaID,int votacionID)
        {
            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    {
                        SqlCommand cmd =new SqlCommand("RegistrarVotoPlancha",cn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue( "@UsuarioID",usuarioID);

                        cmd.Parameters.AddWithValue("@PlanchaID", planchaID);

                        cmd.Parameters.AddWithValue( "@VotacionID", votacionID);


                        return
                            cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("Este usuario ya votó.");
                }


                throw;
            }
        }


        public bool RegistrarVotoNulo( int usuarioID,int votacionID)
        {
            try
            {
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    {
                        SqlCommand cmd = new SqlCommand("RegistrarVotoNulo",cn);

                        cmd.CommandType =CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue( "@UsuarioID", usuarioID);

                        cmd.Parameters.AddWithValue("@VotacionID",votacionID);

                        return
                            cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable VerResultadosVotacion(
            int votacionID)
        {
            DataTable tabla =
                new DataTable();
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                {
                    SqlCommand cmd = new SqlCommand("VerResultadosVotacion",cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue( "@VotacionID", votacionID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(tabla);
                }

                return tabla;
            }
        }

        public int ContarVotosNulos(
            int votacionID)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                {
                    SqlCommand cmd = new SqlCommand("ContarVotosNulos",cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@VotacionID", votacionID);

                    cn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}