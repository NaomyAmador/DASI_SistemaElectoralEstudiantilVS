using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;


namespace LogicaNegocio
{
    public class EstadisticasVotacion
    {
        public string NombreVotacion { get; set; }
        public int TotalPadron { get; set; }
        public int TotalVotaron { get; set; }
        public int TotalNulos { get; set; }
        public double PorcentajeParticipacion { get; set; }
        public double PorcentajeNulos { get; set; }
        public TimeSpan TiempoRestante { get; set; }
        public Dictionary<string, int> VotosPorPlancha { get; set; }
        public Dictionary<string, double> PorcentajePorPlancha { get; set; }
    }
    public class LogicaNegocioVotacion
    {
        private VotacionDAL votacionDAL = new VotacionDAL();
        private PlanchaDAL planchaDAL = new PlanchaDAL();
       // private VotoDAL votoDAL = new VotoDAL();
        private AuditoriaDAL auditoria = new AuditoriaDAL();

        public (bool hayVotacion, EstadisticasVotacion stats, string mensaje) ObtenerEstadisticas()
        {
            Votacion v = votacionDAL.ObtenerVotacionActiva();
            if (v == null)
                return (false, null, "No hay votación activa en este momento.");

            int padron = votacionDAL.ObtenerTotalVotantes();
            int votaron = votacionDAL.ObtenerTotalVotosEmitidos(v.VotacionID);
            int nulos = votacionDAL.ObtenerVotosNulos(v.VotacionID);

            double porcPart = padron > 0 ? Math.Round(votaron * 100.0 / padron, 2) : 0;
            double porcNulos = votaron > 0 ? Math.Round(nulos * 100.0 / votaron, 2) : 0;

            TimeSpan tiempo = v.FechaFin - DateTime.Now;
            if (tiempo < TimeSpan.Zero) tiempo = TimeSpan.Zero;

            var planchas = planchaDAL.ObtenerTodasLasPlanchas();
            var votos = new Dictionary<string, int>();
            var porcentajes = new Dictionary<string, double>();
            int validos = votaron - nulos;

            foreach (var p in planchas)
            {
                int vp = votacionDAL.ObtenerVotosPorPlancha(p.PlanchaID, v.VotacionID);
                votos[p.NombrePlancha] = vp;
                porcentajes[p.NombrePlancha] = validos > 0
                    ? Math.Round(vp * 100.0 / validos, 2) : 0;
            }

            auditoria.RegistrarAccion(Sesion.UsuarioActual?.UsuarioID,
                "PANEL_CONSULTADO", "Consulta de estadísticas de votación.");

            return (true, new EstadisticasVotacion
            {
                NombreVotacion = v.NombreVotacion,
                TotalPadron = padron,
                TotalVotaron = votaron,
                TotalNulos = nulos,
                PorcentajeParticipacion = porcPart,
                PorcentajeNulos = porcNulos,
                TiempoRestante = tiempo,
                VotosPorPlancha = votos,
                PorcentajePorPlancha = porcentajes
            }, "");
        }

        // Para el menú: solo 3 datos simples, sin detalle
        public string ObtenerResumenBreve()
        {
            Votacion v = votacionDAL.ObtenerVotacionActiva();
            if (v == null) return "Sin votación activa";
            int padron = votacionDAL.ObtenerTotalVotantes();
            int votaron = votacionDAL.ObtenerTotalVotosEmitidos(v.VotacionID);
            double porc = padron > 0 ? Math.Round(votaron * 100.0 / padron, 1) : 0;
            return $"Participación: {porc}%  |  Votaron: {votaron}  |  Padrón: {padron}";
        }

        //public string ObtenerEstadoUsuario(int usuarioID)
        //{
        //    return votoDAL.UsuarioYaVoto(usuarioID)
        //        ? "✓ Ya emitiste tu voto."
        //        : "⚠ Aún no has votado.";
        //}
    }
}
