using System;
using Entidades;
using LogicaNegocio;
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
    public partial class EditarDatos : Form
    {
        public EditarDatos()
        {
            InitializeComponent();
        }

        private void CargarCursos()
        {
            cmbCurso.Items.Clear();

            cmbCurso.Items.Add("1ro");
            cmbCurso.Items.Add("2do");
            cmbCurso.Items.Add("3ro");
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

        private void CargarDatosUsuario()
        {
            txtNombre.Text =
                Sesion.UsuarioActual
                .NombreCompleto;

            txtUsuario.Text =
                Sesion.UsuarioActual
                .Usuario;

            txtCorreo.Text =
                Sesion.UsuarioActual
                .Correo;

            txtMatricula.Text =
                Sesion.UsuarioActual
                .Matricula;

            cmbCurso.Text =
                Sesion.UsuarioActual
                .Curso;

            cmbSeccion.Text =
                Sesion.UsuarioActual
                .Seccion;

            txtUsuario.ReadOnly = true;

            txtMatricula.ReadOnly = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditarDatos_Load(object sender, EventArgs e)
        {
            CargarCursos();

            CargarSecciones();

            CargarDatosUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocioUsuario logica =
                    new LogicaNegocioUsuario();

                Usuarios user =   new Usuarios();

                user.UsuarioID = Sesion.UsuarioActual.UsuarioID;
                             
                user.Usuario = Sesion.UsuarioActual.Usuario = Sesion.UsuarioActual.Usuario;
                user.Matricula = Sesion.UsuarioActual.Matricula;

                user.UsuarioID =
                    Sesion.UsuarioActual
                    .UsuarioID;

                user.NombreCompleto =
                    txtNombre.Text;

                user.Correo =
                    txtCorreo.Text;

                user.Curso =
                    cmbCurso.Text;

                user.Seccion =
                    cmbSeccion.Text;

                bool resultado =
                    logica.ActualizarUsuario(
                        user);

                if (resultado)
                {
                    user.Usuario =
                        Sesion.UsuarioActual
                        .Usuario;

                    user.Matricula =
                        Sesion.UsuarioActual
                        .Matricula;

                    user.RolID =
                        Sesion.UsuarioActual
                        .RolID;

                    Sesion.UsuarioActual =
                        user;

                    MessageBox.Show(
                        "Datos actualizados correctamente");

                    this.Close();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "No se pudo actualizar",  ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
