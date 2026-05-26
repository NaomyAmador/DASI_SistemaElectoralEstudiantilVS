using Entidades;
using LogicaNegocio;
using SistemaElectoralEstudiantil.Menu;
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
using static System.Collections.Specialized.BitVector32;

namespace SistemaElectoralEstudiantil
{
    public partial class VerDatosUser : Form
    {
        public VerDatosUser()
        {
            InitializeComponent();
        }

        private void CargarDatosUsuario()
        {
            lblNombre.Text = Sesion.UsuarioActual
                .NombreCompleto;

            lblUsuario.Text =
                Sesion.UsuarioActual
                .Usuario;

            lblCorreo.Text =
                Sesion.UsuarioActual
                .Correo;

            lblMatricula.Text =
                Sesion.UsuarioActual
                .Matricula;

            lblCurso.Text =
                Sesion.UsuarioActual
                .Curso;

            lblSeccion.Text =
                Sesion.UsuarioActual
                .Seccion;

            if (Sesion.UsuarioActual.RolID == 1)
            {
                lblRol.Text =
                    "Administrador";
            }
            else
            {
                lblRol.Text =
                    "Votante";
            }
        }
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EditarDatos frm = new EditarDatos();
            frm.ShowDialog();

            CargarDatosUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
       MessageBox.Show("¿Desea cerrar sesión?","Cerrar Sesión",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.UsuarioActual = null;

                    MenuVotante frm =
                    new MenuVotante();

                frm.Show();

                this.Close();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resultado =
                    MessageBox.Show(
                        "¿Seguro que desea eliminar su cuenta?",
                        "Eliminar Cuenta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    LogicaNegocioUsuario logica =
                        new LogicaNegocioUsuario();

                    bool eliminado =
                        logica.EliminarUsuario(
                            Sesion.UsuarioActual
                            .UsuarioID);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Cuenta eliminada correctamente");

                        Sesion.UsuarioActual =
                            null;

                        MenuVotante frm =
                            new MenuVotante();

                        frm.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar la cuenta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
