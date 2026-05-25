using LogicaNegocio;
using SistemaElectoralEstudiantil.Principal;
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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
       private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

            CargarCursos();

            CargarSecciones();
        }


        private void CargarCursos()
        {            
            cmbCurso.Items.Add("4to");

            cmbCurso.Items.Add("5to");

            cmbCurso.Items.Add("6to");
        }

        private void CargarSecciones()
        {
            cmbSeccion.Items.Add("Informática");

            cmbSeccion.Items.Add("Gestión");

            cmbSeccion.Items.Add("Electronica");

            cmbSeccion.Items.Add("Musica");

            cmbSeccion.Items.Add("Gastronomía");
        }

        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();

            txtUsuario.Clear();

            txtContraseña.Clear();

            txtCorreo.Clear();

            txtMatricula.Clear();

            cmbCurso.SelectedIndex = -1;

            cmbSeccion.SelectedIndex = -1;

            txtNombreCompleto.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocioUsuario logica =
                    new LogicaNegocioUsuario();

                bool resultado = logica.RegistrarUsuario(
                        txtNombreCompleto.Text,
                        txtUsuario.Text,
                        txtContraseña.Text,
                        txtCorreo.Text,
                        txtMatricula.Text,
                        cmbCurso.Text,
                        cmbSeccion.Text);

                if (resultado)
                {
                    MessageBox.Show( "Usuario registrado");

                    LimpiarCampos();
                }
                else
                {                    
                    MessageBox.Show("No se pudo registrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
