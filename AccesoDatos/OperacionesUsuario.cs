using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class OperacionesUsuario
    {

        ConexionBDD conexionBDD = new ConexionBDD();



        /// Estas son para cuando lo ve un ADMIN

        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> lista =new List<Usuarios>();

            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("[MostrarTodosLosUsuarios]", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                              
                SqlDataReader dr =  cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuarios user = new Usuarios();

                    user.UsuarioID =Convert.ToInt32( dr["UsuarioID"]);

                    user.NombreCompleto = dr["NombreCompleto"].ToString();

                    user.Usuario = dr["Usuario"].ToString();

                    user.Correo = dr["Correo"].ToString();

                    user.Matricula =dr["Matricula"].ToString();

                    user.Curso = dr["Curso"].ToString();

                    user.Seccion =dr["Seccion"].ToString();

                    user.RolID = Convert.ToInt32( dr["RolID"]);

                    user.Activo = Convert.ToBoolean( dr["Activo"]);

                    lista.Add(user);
                    
                }
                
            }


            return lista;
        }


        public List<Usuarios> BuscarUsuariosPorNombre(string nombre)
        {
            List<Usuarios> lista =new List<Usuarios>();

            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("BuscarUsuariosPorNombre",conexion);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre",nombre);

               
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Usuarios user =new Usuarios();

                    user.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);

                    user.NombreCompleto =dr["NombreCompleto"].ToString();

                    user.Usuario = dr["Usuario"].ToString();

                    user.Correo = dr["Correo"].ToString();

                    user.Matricula = dr["Matricula"].ToString();

                    user.Curso = dr["Curso"] .ToString();

                    user.Seccion =dr["Seccion"].ToString();

                    user.RolID = Convert.ToInt32(dr["RolID"]);

                    user.Activo =Convert.ToBoolean(dr["Activo"]);

                    lista.Add(user);
                }
            }

            return lista;
        }



        //Esto es como lo veria un user normal

        public Usuarios VerUsuarios(string Usuario, string @Contraseña)
        {
            Usuarios user = null;
            using (SqlConnection conexion = conexionBDD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("MostrarDatosUsuario", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

               
                SqlDataReader dr = cmd.ExecuteReader();

                
                if (dr.Read())

                {
                    user = new Usuarios
                    {
                        UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                        NombreCompleto = dr["NombreCompleto"].ToString(),
                        Usuario = dr["Usuario"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Matricula = dr["Matricula"].ToString(),
                        Curso = dr["Curso"].ToString(),
                        Seccion = dr["Seccion"].ToString(),
                        RolID = Convert.ToInt32(dr["RolID"])

                    };

                }

            }
                return user;
        }
        public bool RegistrarUsuario(string NombreCompleto, string Usuario, String Contraseña, string Correo, string Matricula, string Curso, string Seccion)
        {
            try
            {
                using (SqlConnection conexion = conexionBDD.ObtenerConexion())
                {
                    SqlCommand command = new SqlCommand("RegistrarUsuario", conexion);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Contraseña", Contraseña);
                    command.Parameters.AddWithValue("@Correo", Correo);
                    command.Parameters.AddWithValue("@Matricula", Matricula);
                    command.Parameters.AddWithValue("@Curso", Curso);
                    command.Parameters.AddWithValue("@Seccion", Seccion);

                    return command.ExecuteNonQuery() > 0;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    ex.Message);
            }

        }

                public bool EliminarUsuario(int ID)
                 {
            try 
            {
                using (SqlConnection conexion = conexionBDD.ObtenerConexion())
                {

                    SqlCommand command = new SqlCommand("BorrarUsuario", conexion);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UsuarioID", ID);

                    conexion.Open();

                    return command.ExecuteNonQuery() > 0;
                   
                }
            }

            catch
            {
                return false;
            }

        }


        public bool ActualizarUsuario(Usuarios usuario)
        {
            try
            {
                using (SqlConnection conexion = conexionBDD.ObtenerConexion())
                {
                    SqlCommand command = new SqlCommand("ActualizarUsuario", conexion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                    command.Parameters.AddWithValue( "@Usuario",usuario.Usuario);
                    command.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                    command.Parameters.AddWithValue("@Correo", usuario.Correo);
                    command.Parameters.AddWithValue("@Matricula", usuario.Matricula);
                    command.Parameters.AddWithValue("@Curso", usuario.Curso);
                    command.Parameters.AddWithValue("@Seccion", usuario.Seccion);

                    conexion.Open();
                    
                    return command.ExecuteNonQuery() > 0;


                }
            }
            catch
            {
                return false;
            }

         
        }


        public bool ConvertirUsuarioAdmin(int usuarioID)
        {
            try
            {
                using (SqlConnection conexion =conexionBDD.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand( "ConvertirUsuarioAdmin",conexion);

                    cmd.CommandType =CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UsuarioID",usuarioID);


                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }


        public bool QuitarAdmin(int usuarioID)
        {
            try
            {
                using (SqlConnection conexion =
                    conexionBDD.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand( "QuitarAdmin", conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UsuarioID",usuarioID);


                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    ex.Message);
            }
        }


    }
}
  
