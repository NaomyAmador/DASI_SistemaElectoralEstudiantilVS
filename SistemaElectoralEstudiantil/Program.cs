using SistemaElectoralEstudiantil.EditarPlanchaYCandidato;
using SistemaElectoralEstudiantil.Principal;
using SistemaElectoralEstudiantil.DatosPlancha;
using SistemaElectoralEstudiantil.Votaciones;
using SistemaElectoralEstudiantil.Reportes;
using SistemaElectoralEstudiantil.Menu;
using System;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Votaciones.frm_PanelVotaciones());
            //Application.Run(new EditarPlanchaYCandidato.GestionPlancha());
            //Application.Run(new GestionCandidatos()); 
            //Application.Run(new CrearPlancha());
            //Application.Run(new MenuAdmin());
            Application.Run(new FrmLogin());
            //Application.Run(new MenuVotante());
            //Application.Run(new FrmReporteListadoVotantes());
        }
    }
}
