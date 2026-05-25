using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace SistemaElectoralEstudiantil
{
    public partial class CrearPlancha : Form
    {
        
        private int indiceCandidatoAEditar = -1;
        private LogicaNegocioPlancha logicaPlancha = new LogicaNegocioPlancha();
        private List<Candidatos> listaCandidatosTemporal = new List<Candidatos>();
        private byte[] logoByte = null;

        public CrearPlancha()
        {
            InitializeComponent();
            ConfigurarDiseñoGrid();
        
        }
        private void ConfigurarDiseñoGrid()
        {
            dgv_CrearCandidato.AllowUserToAddRows = false;
            dgv_CrearCandidato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CrearCandidato.ReadOnly = true;
            dgv_CrearCandidato.RowHeadersVisible = false; // Quita el borde izquierdo extra para ganar espacio

            // --- AJUSTE DE COLUMNAS Y SCROLLBARS ---
            // Cambiamos a 'AllCells' para que las columnas respeten el tamaño de la letra y el texto
            dgv_CrearCandidato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Forzamos al control a activar sus barras de desplazamiento cuando el texto desborde
            dgv_CrearCandidato.ScrollBars = ScrollBars.Both;

            // --- CONFIGURACIÓN DE FUENTES (Modern No. 20) ---
            Font fuentePequeña = new Font("Modern No. 20", 9.5F, FontStyle.Regular);
            Font fuenteCabecera = new Font("Modern No. 20", 9.5F, FontStyle.Bold);

            dgv_CrearCandidato.DefaultCellStyle.Font = fuentePequeña;
            dgv_CrearCandidato.ColumnHeadersDefaultCellStyle.Font = fuenteCabecera;
            dgv_CrearCandidato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CrearCandidato.RowTemplate.Height = 22;

            //dgv_CrearCandidato.RowHeadersVisible = false; 

        }

        private void btn_CargarLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picLogo.Image = Image.FromFile(ofd.FileName);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    logoByte = System.IO.File.ReadAllBytes(ofd.FileName);
                }
            }

        }

        private void btn_AgregarCandi_Click(object sender, EventArgs e)
        {
            // SEGURIDAD: Evita que agreguen un candidato nuevo si dejaron una edición a medias
            if (indiceCandidatoAEditar != -1)
            {
                MessageBox.Show("Actualmente está editando un candidato. Use el botón 'Actualizar' o termine la edición.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_NombreCandidato.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del candidato.");
                return;
            }

            Candidatos nuevoCandidato = new Candidatos
            {
                Nombre = txt_NombreCandidato.Text,
                Cargo = cmb_Cargo.Text,
                Edad = (int)n_Edad.Value,
                Descripcion = txt_DescriCandi.Text
            };

            listaCandidatosTemporal.Add(nuevoCandidato);

            // Actualizamos el DataGridView (cuadro gris)
            ActualizarGrid();

            // Limpiar solo los campos del candidato
            txt_NombreCandidato.Clear();
            txt_DescriCandi.Clear();
            n_Edad.Value = 0;
        }
        private void ActualizarGrid()
        {
            dgv_CrearCandidato.DataSource = null;
            dgv_CrearCandidato.DataSource = listaCandidatosTemporal;
            // --- OCULTAR COLUMNAS DE IDENTIFICADORES (Los ceros de la imagen) ---
            // Como son objetos en memoria, CandidatoID y PlanchaID siempre valen 0 y quitan mucho espacio.
            if (dgv_CrearCandidato.Columns["CandidatoID"] != null)
                dgv_CrearCandidato.Columns["CandidatoID"].Visible = false;

            if (dgv_CrearCandidato.Columns["PlanchaID"] != null)
                dgv_CrearCandidato.Columns["PlanchaID"].Visible = false;

            // --- REDISEÑAR LOS ENCABEZADOS PARA QUE SE VEAN IMPECABLES ---
            if (dgv_CrearCandidato.Columns["Nombre"] != null)
                dgv_CrearCandidato.Columns["Nombre"].HeaderText = "Nombre Completo";

            if (dgv_CrearCandidato.Columns["Cargo"] != null)
                dgv_CrearCandidato.Columns["Cargo"].HeaderText = "Cargo";

            if (dgv_CrearCandidato.Columns["Edad"] != null)
                dgv_CrearCandidato.Columns["Edad"].HeaderText = "Edad";

            if (dgv_CrearCandidato.Columns["Descripcion"] != null)
                dgv_CrearCandidato.Columns["Descripcion"].HeaderText = "Biografía / Descripción";
        }

        private void btn_GuardarPlancha_Click(object sender, EventArgs e)
        {
            txt_NombreCandidato.Enabled = true;

            Planchas nuevaPlancha = new Planchas
            {
                NombrePlancha = txt_NombrePlancha.Text,
                Descripcion = txt_DescriPlancha.Text,
                Logo = logoByte,
                Activa = cmb_Estado.Text == "Activo" // Según tu ComboBox de la imagen
            };

            // 2. Llamar a la lógica de negocio
            // Esta función ya valida si hay presidente y si el nombre es único
            var (exito, mensaje) = logicaPlancha.CrearPlancha(nuevaPlancha, listaCandidatosTemporal);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioCompleto();
            }
            else
            {
                // Muestra errores de validación (Ej: "Falta un Presidente")
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarFormularioCompleto()
        {
            txt_NombrePlancha.Clear();
            txt_DescriPlancha.Clear();
            picLogo.Image = null;
            logoByte = null;
            listaCandidatosTemporal.Clear();
            ActualizarGrid();
        }

        private void btn_ActualizarCandi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreCandidato.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del candidato para poder actualizar.");
                return;
            }

            // 2. Verificar que haya un candidato seleccionado mediante el Doble Clic
            if (indiceCandidatoAEditar >= 0)
            {
                // 3. Modificamos el candidato existente en tu lista en memoria
                listaCandidatosTemporal[indiceCandidatoAEditar].Nombre = txt_NombreCandidato.Text;
                listaCandidatosTemporal[indiceCandidatoAEditar].Cargo = cmb_Cargo.Text;
                listaCandidatosTemporal[indiceCandidatoAEditar].Edad = (int)n_Edad.Value;
                listaCandidatosTemporal[indiceCandidatoAEditar].Descripcion = txt_DescriCandi.Text;

                // 4. Refrescamos tu cuadro gris
                ActualizarGrid();

                // 5. Limpiamos los campos usando tu mismo estilo
                txt_NombreCandidato.Clear();
                txt_DescriCandi.Clear();
                n_Edad.Value = 0;

                // 6. Reseteamos el rastreador y restauramos los botones
                indiceCandidatoAEditar = -1;
                btn_AgregarCandi.Enabled = true;
                btn_ActualizarCandi.Enabled = false; // Se vuelve a apagar

                MessageBox.Show("Candidato actualizado con éxito en la lista temporal.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
    
}
