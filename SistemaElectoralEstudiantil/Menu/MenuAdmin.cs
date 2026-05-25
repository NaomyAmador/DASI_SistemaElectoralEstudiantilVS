using SistemaElectoralEstudiantil.DatosPlancha;
using SistemaElectoralEstudiantil.EditarPlanchaYCandidato;
using SistemaElectoralEstudiantil.Principal;
using SistemaElectoralEstudiantil.Reportes;
using SistemaElectoralEstudiantil.Votaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil.Menu
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
           
        }

        private void btn_CreacionPlancha_Click(object sender, EventArgs e)
        {
            CrearPlancha BotonCrearP = new CrearPlancha();
            BotonCrearP.Owner = this;
            BotonCrearP.Show();
            this.Hide();
        }

        private void btn_DatosPartido_Click(object sender, EventArgs e)
        {
            FrmDatosPlancha DatosPlancha = new FrmDatosPlancha();
            DatosPlancha.Owner = this;
            DatosPlancha.Show();
            this.Hide();
        }

        private void btn_Votaciones_Click(object sender, EventArgs e)
        {
            FrmVotaciones VotarBoton = new FrmVotaciones();
            VotarBoton.Owner = this;
            VotarBoton.Show();
            this.Hide();
        }

        private void btn_DatosUsuario_Click(object sender, EventArgs e)
        {
            ADMINVerDatosTodosUsuario DatosAdmin = new ADMINVerDatosTodosUsuario();
            DatosAdmin.Owner = this;
            DatosAdmin.Show();
            this.Hide();
        }

        private void btn_PanelVotaciones_Click(object sender, EventArgs e)
        {
            frm_PanelVotaciones BotonPanelVotaciones = new frm_PanelVotaciones();
            BotonPanelVotaciones.Owner = this;
            BotonPanelVotaciones.Show();
            this.Hide();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            Frm_ReportesSpace BotonReporte = new Frm_ReportesSpace();
            BotonReporte.Owner = this;
            BotonReporte.Show();
            this.Hide();
        }

        private void btn_GestionPlanchas_Click(object sender, EventArgs e)
        {
            GestionPlancha gestionPlancha = new GestionPlancha();
            gestionPlancha.Owner = this;
            gestionPlancha.Show();
            this.Hide();
        }

        private void btn_GestionCandidatos_Click(object sender, EventArgs e)
        {
            GestionCandidatos gestionCandidatos = new GestionCandidatos();
            gestionCandidatos.Owner = this;
            gestionCandidatos.Show();
            this.Hide();
        }
    }
}
