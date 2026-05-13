using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace LogicaNegocio
{
    public class LogicaNegocioVotaciones
    {

        OperacionesVotaciones operaciones = new OperacionesVotaciones();

        public List<Planchas> ObtenerPlanchas()
        {
            return operaciones.MostrarPlanchas();
        }

        public List<Candidatos>
            ObtenerCandidatosPorPlancha(int planchaID)
        {

            if (planchaID <= 0)
            {
                throw new Exception("La plancha no es valida");
            }

            return operaciones.MostrarCandidatosPorPlancha(planchaID);
        }


        public bool VerificarSiUsuarioYaVoto(int usuarioID)
        {

            if (usuarioID <= 0)
            {
                throw new Exception("Usuario invalido");
            }

            return operaciones.VerificarSiUsuarioYaVoto(usuarioID);
        }

        public bool RegistrarVotoPlancha(int usuarioID,int planchaID,int votacionID)
        {

            if (usuarioID <= 0)
            {
                throw new Exception("Usuario invalido");
            }

            if (planchaID <= 0)
            {
                throw new Exception( "Plancha invalida");
            }

            if (votacionID <= 0)
            {
                throw new Exception("Votacion invalida");
            }

            bool yaVoto =operaciones.VerificarSiUsuarioYaVoto(usuarioID);

            if (yaVoto)
            {
                throw new Exception("El usuario ya voto");
            }

            return operaciones.RegistrarVotoPlancha( usuarioID,planchaID,votacionID);
        }

        public bool RegistrarVotoNulo(int usuarioID,int votacionID)
        {

            if (usuarioID <= 0)
            {
                throw new Exception("Usuario invalido");
            }

            if (votacionID <= 0)
            {
                throw new Exception("Votacion invalida");
            }

            bool yaVoto =operaciones.VerificarSiUsuarioYaVoto(usuarioID);

            if (yaVoto)
            {
                throw new Exception("El usuario ya voto");
            }

            return operaciones.RegistrarVotoNulo(usuarioID,votacionID);
        }

        public DataTable VerResultados(int votacionID)
        {

            if (votacionID <= 0)
            {
                throw new Exception("Votacion invalida");
            }

            return operaciones.VerResultadosVotacion(votacionID);
        }


        public int ContarVotosNulos(
            int votacionID)
        {

            if (votacionID <= 0)
            {
                throw new Exception("Votacion invalida");
            }

            return operaciones.ContarVotosNulos(votacionID);
        }
    }
}

   
