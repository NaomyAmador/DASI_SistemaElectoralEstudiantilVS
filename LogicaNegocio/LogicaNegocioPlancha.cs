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
        private CandidatoDAL candidatoDAL = new CandidatoDAL();
        private AuditoriaDAL auditoria = new AuditoriaDAL();

        public (bool exito, string mensaje) CrearPlancha(Planchas plancha, List<Candidatos> candidatos)
        {
            List<Planchas> listaExistente = planchaDAL.ObtenerTodasLasPlanchas();

            if (listaExistente.Count >= 4)
            {
                return (false, "Límite alcanzado: Solo se permiten 4 planchas activas simultáneamente. Debe eliminar o desactivar una para continuar.");
            }

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
        public (bool exito, string mensaje) ModificarPlancha(Planchas plancha)
        {
            if (string.IsNullOrWhiteSpace(plancha.NombrePlancha))
                return (false, "El nombre de la plancha es obligatorio.");

            bool resultado = planchaDAL.ActualizarPlancha(plancha);

            if (resultado)
            {
                auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                    "PLANCHA_MODIFICADA",
                    $"Se modificaron los datos de la plancha '{plancha.NombrePlancha}' (ID: {plancha.PlanchaID}).");

                return (true, "Plancha actualizada con éxito.");
            }

            return (false, "No se pudieron guardar los cambios en la base de datos.");
        }

        public (bool exito, string mensaje) ActivarPlancha(int planchaID, string nombrePlancha)
        {
            List<Planchas> listaExistente = planchaDAL.ObtenerTodasLasPlanchas();

            if (listaExistente.Count >= 4)
            {
                return (false, "Límite alcanzado: Ya existen 4 planchas activas. Desactiva una antes de activar esta.");
            }

            bool resultado = planchaDAL.ActivarPlancha(planchaID);

            if (resultado)
            {
                auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                    "PLANCHA_ACTIVADA",
                    $"Se volvió a activar la plancha '{nombrePlancha}'.");

                return (true, "Plancha activada exitosamente.");
            }

            return (false, "No se pudo activar la plancha.");
        }

        public (bool exito, string mensaje) ActualizarPlancha(Planchas plancha)
        {
            // 1. Validaciones rápidas de negocio antes de tocar la base de datos
            if (string.IsNullOrWhiteSpace(plancha.NombrePlancha))
            {
                return (false, "El nombre de la plancha es obligatorio.");
            }

            try
            {
                // 2. Llamamos a tu método que ya tienes en Acceso a Datos (DAL)
                // (Ajusta el nombre 'planchaDAL.Actualizar' al nombre exacto de tu método en la DAL)
                bool resultado = planchaDAL.ActualizarPlancha(plancha);

                if (resultado)
                {
                    // 3. Si tienes el sistema de auditoría que mencionamos antes, lo registras aquí
                    // auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID, "PLANCHA_MODIFICADA", $"ID: {plancha.PlanchaID}");

                    return (true, "La plancha se actualizó correctamente.");
                }
                else
                {
                    return (false, "No se encontraron cambios o no se pudo actualizar la plancha.");
                }
            }
            catch (Exception ex)
            {
                // Por si ocurre un error inesperado con la conexión SQL
                return (false, $"Error en la capa de negocio: {ex.Message}");
            }
        }


        public (bool exito, string mensaje) EliminarPlancha(int planchaID, string nombrePlancha)
        {
            bool resultado = planchaDAL.EliminarPlancha(planchaID);

            if (resultado)
            {
                auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                    "PLANCHA_ELIMINADA",
                    $"Se eliminó físicamente la plancha '{nombrePlancha}' del sistema.");

                return (true, "La plancha ha sido eliminada permanentemente.");
            }

            return (false, "Error al intentar eliminar la plancha. Verifique que no tenga restricciones.");
        }

        // =====================================
        // VALIDAR CARGOS ÚNICOS
        // =====================================
        private bool CargoUnico(string cargo)
        {
            return cargo == "Presidente" ||
                   cargo == "Vicepresidente" ||
                   cargo == "Secretario" ||
                   cargo == "Tesorero";
        }

        // =====================================
        // VALIDAR SI EXISTE OTRO PRESIDENTE
        // =====================================
        public bool ExisteOtroPresidente(
            int planchaID,
            int candidatoID)
        {
            List<Candidatos> candidatos =
                candidatoDAL.ObtenerTodosLosCandidatos();

            return candidatos.Any(c =>
                c.PlanchaID == planchaID &&
                c.Cargo == "Presidente" &&
                c.CandidatoID != candidatoID);
        }

        // =====================================
        // MODIFICAR CANDIDATO
        // =====================================
        public (bool exito, string mensaje) ModificarCandidato(Candidatos candidato)
        {
            // VALIDAR NOMBRE
            if (string.IsNullOrWhiteSpace(candidato.Nombre))
            {
                return (false,
                    "El nombre es obligatorio.");
            }

            // VALIDAR CARGO
            if (string.IsNullOrWhiteSpace(candidato.Cargo))
            {
                return (false,
                    "El cargo es obligatorio.");
            }

            // VALIDAR CARGOS ÚNICOS
            if (CargoUnico(candidato.Cargo))
            {
                bool existe =
                    candidatoDAL.ExisteCargoEnPlancha(
                        candidato.PlanchaID,
                        candidato.Cargo,
                        candidato.CandidatoID
                    );

                if (existe)
                {
                    return (false,
                        $"Ya existe un {candidato.Cargo} en esta plancha.");
                }
            }

            // ACTUALIZAR
            bool resultado =
                candidatoDAL.ActualizarCandidato(
                    candidato);

            if (resultado)
            {
                auditoria.RegistrarAccion(
                    Sesion.UsuarioActual?.UsuarioID,
                    "CANDIDATO_MODIFICADO",
                    $"Se modificó el candidato '{candidato.Nombre}'."
                );

                return (true,
                    "Candidato actualizado correctamente.");
            }

            return (false,
                "No se pudo actualizar.");
        }

        // =====================================
        // ELIMINAR CANDIDATO
        // =====================================
        public (bool exito, string mensaje)
        EliminarCandidato( int candidatoID, string nombre, int planchaID,
            string cargo)
        {
            // 🚨 NO BORRAR ÚNICO PRESIDENTE
            if (cargo == "Presidente")
            {
                bool existeOtro = ExisteOtroPresidente( planchaID,candidatoID);

                if (!existeOtro)
                {
                    return (false,"No se puede eliminar el único presidente.");
                }
            }

            bool resultado =
                candidatoDAL.EliminarCandidato(
                    candidatoID);

            if (resultado)
            {
                auditoria.RegistrarAccion(
                Sesion.UsuarioActual?.UsuarioID,
                "CANDIDATO_ELIMINADO",
                $"Se eliminó '{nombre}'."
                );

                return (true, "Candidato eliminado.");
            }

            return (false,"Error al eliminar.");
        }

        public List<Candidatos> ObtenerTodosLosCandidatos()
        {
            return candidatoDAL.ObtenerTodosLosCandidatos();
        }

    }
}
