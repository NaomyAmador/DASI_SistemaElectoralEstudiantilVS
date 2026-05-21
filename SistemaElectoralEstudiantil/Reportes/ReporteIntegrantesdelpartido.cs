using Entidades;
using LogicaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil
{
    public partial class ReporteIntegrantesdelpartido : Form
    {
        public ReporteIntegrantesdelpartido()
        {
            InitializeComponent();
        }

        private void ReporteIntegrantesdelpartido_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtNombrePlancha.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la plancha");

                    return;
                }

                LogicaNegocioVotaciones logica =
                    new LogicaNegocioVotaciones();

                List<Candidatos> lista =
                    logica.ObtenerCandidatosPorPlancha(
                        txtNombrePlancha.Text);

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No existen candidatos");

                    return;
                }

                ReportDataSource origen =
                    new ReportDataSource(
                        "DSCandidatos",
                        lista);

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add( origen);

                reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaElectoralEstudiantil.ReporteCandidatos.rdlc";

                reportViewer1.RefreshReport();

                txtNombrePlancha.Clear();

                txtNombrePlancha.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
    }
}
