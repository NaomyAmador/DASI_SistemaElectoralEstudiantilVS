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

namespace SistemaElectoralEstudiantil
{
    public partial class ADMINVerDatosTodosUsuario : Form
    {
        public ADMINVerDatosTodosUsuario()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            LogicaNegocioUsuario logica =
                new LogicaNegocioUsuario();

            dgvUsuarios.DataSource =logica.ListarUsuarios();
            dgvUsuarios.Columns["YaVoto"].Visible = false;
            dgvUsuarios.Columns["PadronID"].Visible = false;
        }

        private void ADMINVerDatosTodosUsuario_Load(object sender, EventArgs e)
        {

            CargarUsuarios();

            cmbRol.Items.Add("Administrador");

            cmbRol.Items.Add("Votante");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                LogicaNegocioUsuario logica =new LogicaNegocioUsuario();

                dgvUsuarios.DataSource =logica.BuscarUsuariosPorNombre(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un usuario");

                    return;
                }

                if (cmbRol.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un rol");

                    return;
                }

                int usuarioID = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UsuarioID"].Value);

                string rol = cmbRol.SelectedItem.ToString();

                LogicaNegocioUsuario logica = new LogicaNegocioUsuario();

                bool resultado = false;

                if (rol.Trim().ToLower() == "administrador")
                {
                    resultado =logica.ConvertirUsuarioAdmin(usuarioID);
                }
                else
                {
                    resultado =logica.QuitarAdmin( usuarioID);
                }

                if (resultado)
                {
                    MessageBox.Show("Rol actualizado");

                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
    
}


