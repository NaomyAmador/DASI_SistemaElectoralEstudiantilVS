using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil.EditarPlanchaYCandidato
{
    public partial class GestionPlancha : Form
    {
        private LogicaNegocioPlancha logicaPlancha = new LogicaNegocioPlancha();

        
        private int idPlanchaSeleccionada = 0;
        private byte[] imagenLogoBytes = null;
        public GestionPlancha()
        {
            InitializeComponent();
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CargarGridPlanchas();
        }

        private void CargarGridPlanchas()
        {
            try
            {
         
                dgv_Planchas.DataSource = null;

          
                dgv_Planchas.DataSource = logicaPlancha.ObtenerPlanchas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las planchas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionPlancha_Load(object sender, EventArgs e)
        {
            CargarGridPlanchas();
        }

        private void dgv_Planchas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_Planchas.Rows[e.RowIndex];

                idPlanchaSeleccionada = Convert.ToInt32(fila.Cells["PlanchaID"].Value);

               
                txt_Nombre.Text = fila.Cells["NombrePlancha"].Value.ToString();
                txt_Descripcion.Text = fila.Cells["Descripcion"].Value.ToString();

               
                cB_PlanchaActiva.Checked = Convert.ToBoolean(fila.Cells["Activa"].Value);

           
                if (fila.Cells["Logo"].Value != DBNull.Value && fila.Cells["Logo"].Value != null)
                {
                    imagenLogoBytes = (byte[])fila.Cells["Logo"].Value;
                    using (MemoryStream ms = new MemoryStream(imagenLogoBytes))
                    {
                        picLogo.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenLogoBytes = null;
                    picLogo.Image = null; 
                }
            }

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (idPlanchaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, seleccione una plancha de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El nombre de la plancha no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            Planchas datosPlancha = new Planchas
            {
                PlanchaID = idPlanchaSeleccionada,
                NombrePlancha = txt_Nombre.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                Logo = imagenLogoBytes, 

               
                Activa = cB_PlanchaActiva.Checked
            };

        
            var resultado = logicaPlancha.ActualizarPlancha(datosPlancha);

            if (resultado.exito)
            {
                MessageBox.Show(resultado.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridPlanchas(); 
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CambiarLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picLogo.Image = Image.FromFile(ofd.FileName);
                  
                    imagenLogoBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }
        private void LimpiarFormulario()
        {
            idPlanchaSeleccionada = 0;
            imagenLogoBytes = null;    

            txt_Nombre.Clear();
            txt_Descripcion.Clear();
            cB_PlanchaActiva.Checked = false;

            if (picLogo != null)
            {
                picLogo.Image = null; 
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idPlanchaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, seleccione una plancha de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta plancha por completo? Esto podría afectar a sus candidatos asociados.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                
                var resultado = logicaPlancha.EliminarPlancha(idPlanchaSeleccionada, txt_Nombre.Text.Trim());

                if (resultado.exito)
                {
                    MessageBox.Show(resultado.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridPlanchas(); 
                    LimpiarFormulario();  
                }
                else
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
