using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace LogicaNegocio
{

     public class LogicaNegocioUsuario
    {
        OperacionesUsuario operaciones = new OperacionesUsuario();

        //Vista ADMIN Usuarios

        public List<Usuarios> ListarUsuarios()
        {
            return operaciones.ListarUsuarios();
        }

        public List<Usuarios> BuscarUsuariosPorNombre(string nombre)
        {

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Debe ingresar un nombre");
            }

            return operaciones.BuscarUsuariosPorNombre(nombre);
        }

        //Usuaios Normales


        public bool RegistrarUsuario( string nombreCompleto, string usuario,string contraseña,string correo,
            string matricula, string curso, string seccion)
        {

            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                throw new Exception(
                    "El nombre es obligatorio");
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception(
                    "El usuario es obligatorio");
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                throw new Exception(
                    "La contraseña es obligatoria");
            }

            if (contraseña.Length < 6)
            {
                throw new Exception(
                    "La contraseña debe tener minimo 6 caracteres");
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new Exception(
                    "El correo es obligatorio");
            }

            if (!correo.Contains("@"))
            {
                throw new Exception(
                    "Correo invalido");
            }

            if (string.IsNullOrWhiteSpace(matricula))
            {
                throw new Exception(
                    "La matricula es obligatoria");
            }

            if (string.IsNullOrWhiteSpace(curso))
            {
                throw new Exception(
                    "El curso es obligatorio");
            }

            if (string.IsNullOrWhiteSpace(seccion))
            {
                throw new Exception(
                    "La seccion es obligatoria");
            }

            return operaciones.RegistrarUsuario(nombreCompleto, usuario, contraseña,correo,matricula,curso, seccion);
        }

        public Usuarios Login(
            string usuario,
            string contraseña)
        {

            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception(
                    "Ingrese el usuario");
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                throw new Exception(
                    "Ingrese la contraseña");
            }

            Usuarios user = operaciones.VerUsuarios(usuario,contraseña);

            if (user == null)
            {
                throw new Exception(
                    "Usuario o contraseña incorrectos");
            }

            return user;
        }

        public bool EliminarUsuario(int id)
        {

            if (id <= 0)
            {
                throw new Exception(
                    "ID invalido");
            }

            return operaciones.EliminarUsuario(id);
        }


        public bool ActualizarUsuario( Usuarios usuario)
        {

            if (usuario == null)
            {
                throw new Exception(
                    "El usuario no existe");
            }

            if (usuario.UsuarioID <= 0)
            {
                throw new Exception(
                    "ID invalido");
            }

            if (string.IsNullOrWhiteSpace(
                usuario.NombreCompleto))
            {
                throw new Exception(
                    "Nombre obligatorio");
            }

            if (string.IsNullOrWhiteSpace(
                usuario.Correo))
            {
                throw new Exception(
                    "Correo obligatorio");
            }

            if (!usuario.Correo.Contains("@"))
            {
                throw new Exception(
                    "Correo invalido");
            }

            if (string.IsNullOrWhiteSpace(
                usuario.Matricula))
            {
                throw new Exception(
                    "Matricula obligatoria");
            }

            if (string.IsNullOrWhiteSpace(
                usuario.Curso))
            {
                throw new Exception(
                    "Curso obligatorio");
            }

            if (string.IsNullOrWhiteSpace(
                usuario.Seccion))
            {
                throw new Exception(
                    "Seccion obligatoria");
            }

            return operaciones.ActualizarUsuario(usuario);
        }
    }
}
