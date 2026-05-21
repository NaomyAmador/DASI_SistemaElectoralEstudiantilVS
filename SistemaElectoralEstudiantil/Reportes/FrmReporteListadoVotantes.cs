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

namespace SistemaElectoralEstudiantil.Reportes
{
    public partial class FrmReporteListadoVotantes : Form
    {
        public FrmReporteListadoVotantes()
        {
            InitializeComponent();
        }

        private void FrmReporteListadoVotantes_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                LogicaNegocioUsuario logica = new LogicaNegocioUsuario();

                DataTable tabla = logica.ReporteListadoVotantes();

                ReportDataSource origen = new ReportDataSource("DSVotantes", tabla);

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(origen);

                reportViewer1.LocalReport.ReportEmbeddedResource =
                 "SistemaElectoralEstudiantil.Reportes.ReporteListadoVotantes.rdlc";

                reportViewer1.LocalReport.Refresh();

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
  
        }
    }
}
