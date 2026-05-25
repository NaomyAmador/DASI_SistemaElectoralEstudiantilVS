using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil.EditarPlanchaYCandidato
{
    public partial class GestionCandidatos : Form
    {
        private LogicaNegocioPlancha logicaPlancha = new LogicaNegocioPlancha();

        private int candidatoIDSeleccionado = 0;
        public GestionCandidatos()
        {
            InitializeComponent();
            
        }

        private void Gestion_Candidatos_Load(object sender, EventArgs e)
        {
            CargarPlanchas();
            ConfigurarComboCargo();
            CargarCandidatosPorPlancha();
        }
        private void ConfigurarComboCargo()
        {
            cb_Cargo.Items.Clear();

            cb_Cargo.Items.Add("Presidente");
            cb_Cargo.Items.Add("Vicepresidente");
            cb_Cargo.Items.Add("Secretario");
            cb_Cargo.Items.Add("Tesorero");
            cb_Cargo.Items.Add("Vocal");
        }
        private void CargarPlanchas()
        {
            cb_PlanchaAsociada.DataSource = null;

            List<Planchas> lista =
                logicaPlancha.ObtenerPlanchas();

            cb_PlanchaAsociada.DataSource =
                lista;

            cb_PlanchaAsociada.DisplayMember =
                "NombrePlancha";

            cb_PlanchaAsociada.ValueMember =
                "PlanchaID";
        }


        private void CargarCandidatosPorPlancha()
        {
            try
            {
                if (cb_PlanchaAsociada.SelectedValue is int planchaID)
                {
                    dgv_Candidatos.DataSource = null;

                    dgv_Candidatos.DataSource =
                        logicaPlancha.ObtenerCandidatos(
                            planchaID);

                    // OPCIONAL
                    if (dgv_Candidatos.Columns["PlanchaID"] != null)
                    {
                        dgv_Candidatos.Columns["PlanchaID"].Visible = false;
                    }
                }
            }
            catch
            {

            }
        }
       
        private void dgv_Candidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgv_Candidatos.Rows[e.RowIndex];

                candidatoIDSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["CandidatoID"].Value);

                txt_Nombre.Text =
                    fila.Cells["Nombre"].Value.ToString();

                txt_Descripcion.Text =
                    fila.Cells["Descripcion"].Value.ToString();

                cb_Cargo.Text =
                    fila.Cells["Cargo"].Value.ToString();

                numericUpDown1.Value =
                    Convert.ToDecimal(
                        fila.Cells["Edad"].Value);

                cb_PlanchaAsociada.SelectedValue =
                    Convert.ToInt32(
                        fila.Cells["PlanchaID"].Value);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (candidatoIDSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un candidato.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Candidatos candidato =
                new Candidatos();

            candidato.CandidatoID =
                candidatoIDSeleccionado;

            candidato.Nombre =
                txt_Nombre.Text.Trim();

            candidato.Cargo =
                cb_Cargo.Text;

            candidato.Edad =
                Convert.ToInt32(
                    numericUpDown1.Value);

            candidato.Descripcion =
                txt_Descripcion.Text.Trim();

            candidato.PlanchaID =
                Convert.ToInt32(
                    cb_PlanchaAsociada.SelectedValue);

            var resultado =
                logicaPlancha.ModificarCandidato(
                    candidato);

            if (resultado.exito)
            {
                MessageBox.Show(
                    resultado.mensaje,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCandidatosPorPlancha();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(
                    resultado.mensaje,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (candidatoIDSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un candidato.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmacion =
                MessageBox.Show(
                    "¿Desea eliminar este candidato?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                int planchaID =
                    Convert.ToInt32(
                        cb_PlanchaAsociada.SelectedValue);

                var resultado =
                    logicaPlancha.EliminarCandidato(
                        candidatoIDSeleccionado,
                        txt_Nombre.Text,
                        planchaID,
                        cb_Cargo.Text
                    );

                if (resultado.exito)
                {
                    MessageBox.Show(
                        resultado.mensaje,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCandidatosPorPlancha();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        resultado.mensaje,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            candidatoIDSeleccionado = 0;

            txt_Nombre.Clear();

            txt_Descripcion.Clear();

            cb_Cargo.SelectedIndex = -1;

            numericUpDown1.Value = 1;

            if (cb_PlanchaAsociada.Items.Count > 0)
            {
                cb_PlanchaAsociada.SelectedIndex = 0;
            }
        }

        private void cb_PlanchaAsociada_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCandidatosPorPlancha();
        }

        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }

}
