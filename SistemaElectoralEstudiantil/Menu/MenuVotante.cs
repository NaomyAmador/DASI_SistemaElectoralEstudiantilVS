using SistemaElectoralEstudiantil.DatosPlancha;
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
    public partial class MenuVotante : Form
    {
        public MenuVotante()
        {
            InitializeComponent();
        }

        private void btn_DatosPartido_Click(object sender, EventArgs e)
        {
            FrmDatosPlancha DatosPlancha = new FrmDatosPlancha();
            DatosPlancha.Owner = this;
            DatosPlancha.Show();
            this.Hide();
        }

        private void btn_DatosUsuarios_Click(object sender, EventArgs e)
        {
            VerDatosUser DatosUser = new VerDatosUser();
            DatosUser.Owner = this;
            DatosUser.Show();
            this.Hide();
        }

        private void btn_PanelVotacion_Click(object sender, EventArgs e)
        {
            frm_PanelVotaciones BotonPanelVotaciones = new frm_PanelVotaciones();
            BotonPanelVotaciones.Owner = this;
            BotonPanelVotaciones.Show();
            this.Hide();
        }

        private void btn_Votaciones_Click(object sender, EventArgs e)
        {
            FrmVotaciones VotarBoton = new FrmVotaciones();
            VotarBoton.Owner = this;
            VotarBoton.Show();
            this.Hide();
        }
    }
}
