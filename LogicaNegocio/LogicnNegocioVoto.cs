using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LogicnNegocioVoto
    {
        private VotoDAL votoDAL = new VotoDAL();
        private UsuarioDAL usuarioDAL= new UsuarioDAL();

        public (bool puede, string mensaje) VerificarSiPuedeVotar(int UsuarioID)
        {
            if (votoDAL.ObtenerVotacionActiva() == null)
                return (false, "No hay votacion activa.");

            if (votoDAL.UsuarioYaVoto(UsuarioID))
                return (false, "Ya emitiste tu voto");

            if (!votoDAL.UsuarioPerteneceAlPadron(UsuarioID))
                return (false, "No estás habilitado para esta votación.");
            return (true, "Puedes votar.");
        }

        public (bool exito, string mensaje) EmitirVoto (int UsuarioID, int? PlanchaID, bool EsNulo)
        {
            Votacion v = votoDAL.ObtenerVotacionActiva();
            if (v == null)
                return (false, "No hay votación activa.");

            if (votoDAL.UsuarioYaVoto(UsuarioID))
                return (false, "Ya votaste. No puedes votar dos veces.");

            if (usuarioDAL.ObtenerUsuarioPorID(UsuarioID) == null)
                return (false, "Usuario no encontrado.");

            if (!votoDAL.UsuarioPerteneceAlPadron(UsuarioID))
                return (false, "No perteneces al padrón de esta votación.");

            if (!EsNulo && !PlanchaID.HasValue)
                return (false, "Selecciona una plancha o marca voto nulo.");

            if (EsNulo) PlanchaID = null;
            return votoDAL.RegistrarVoto(UsuarioID, PlanchaID, v.VotacionID, EsNulo);
        } 
    }
}
