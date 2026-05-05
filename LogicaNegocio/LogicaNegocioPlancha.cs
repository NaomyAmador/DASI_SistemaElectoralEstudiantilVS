using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LogicaNegocioPlancha
    {
        private PlanchaDAL planchaDAL = new PlanchaDAL();
        private AddPlancha addPlancha = new AddPlancha();
        private AddCandidato addCandidato = new AddCandidato();
        private AuditoriaDAL auditoria = new AuditoriaDAL();

        public (bool exito, string mensaje) CrearPlancha(Planchas plancha, List<Candidatos> candidatos)
        {
            // Validar nombre único ANTES de tocar la BD
            if (planchaDAL.ExisteNombrePlancha(plancha.NombrePlancha))
                return (false, $"Ya existe una plancha con el nombre '{plancha.NombrePlancha}'.");

            var validacion = ValidarPlancha(plancha, candidatos);
            if (!validacion.esValida)
                return (false, validacion.motivo);

            int idPlancha = addPlancha.InsertarPlancha(plancha);
            if (idPlancha <= 0)
                return (false, "Error al guardar la plancha.");

            foreach (Candidatos c in candidatos)
            {
                c.PlanchaID = idPlancha;
                addCandidato.InsertarCandidato(c);
            }

            auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                "PLANCHA_CREADA",
                $"Plancha '{plancha.NombrePlancha}' creada con {candidatos.Count} candidato(s).");

            return (true, "Plancha creada exitosamente.");
        }

        public bool DesactivarPlancha(int planchaID, string nombrePlancha)
        {
            bool resultado = planchaDAL.DesactivarPlancha(planchaID);
            if (resultado)
                auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                    "PLANCHA_DESACTIVADA", $"Se desactivó '{nombrePlancha}'.");
            return resultado;
        }

        public List<Planchas> ObtenerPlanchas() => planchaDAL.ObtenerTodasLasPlanchas();

        public List<Candidatos> ObtenerCandidatos(int planchaID) =>
            planchaDAL.ObtenerCandidatosPorPlancha(planchaID);

        private (bool esValida, string motivo) ValidarPlancha(Planchas plancha, List<Candidatos> candidatos)
        {
            if (string.IsNullOrWhiteSpace(plancha.NombrePlancha))
                return (false, "El nombre de la plancha es obligatorio.");

            if (candidatos == null || candidatos.Count == 0)
                return (false, "Debe agregar al menos un candidato.");

            if (!candidatos.Exists(c => c.Cargo == "Presidente"))
                return (false, "La plancha debe tener un Presidente.");
            foreach (var c in candidatos)

                if (string.IsNullOrWhiteSpace(c.Nombre))
                    return (false, "Todos los candidatos deben tener nombre.");
            return (true, "");
        }
    }
}
