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
    public class VerDatosUsuario
    {
        ConexionBDD Conexion = new ConexionBDD();
        Usuarios User;
        public Usuarios VerUsuarios(string Usuario, string @Contraseña)
        {

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MostrarDatosUsuario", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())

                {
                    Usuarios User = new Usuarios()

                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        NombreCompleto = dr["NombreCompleto"].ToString(),
                        Usuario = dr["Usuario"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Curso = dr["Curso"].ToString(),
                        Seccion = dr["Seccion"].ToString(),
                        RolID = Convert.ToInt32(dr["RolID"])

                    };

                }
                return User;


            }
        
           }

        }
    }

