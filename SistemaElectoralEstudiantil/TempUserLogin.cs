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

namespace SistemaElectoralEstudiantil
{
    public partial class TempUserLogin : Form
    {
        public TempUserLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocioUsuario logica =
                    new LogicaNegocioUsuario();

                Usuarios user =
                    logica.Login(
                        txtUsuario.Text,
                        txtContraseña.Text);

                Sesion.UsuarioActual = user;

                MessageBox.Show(
                    "Bienvenido " +
                    user.NombreCompleto);

                this.Hide();

                if (user.RolID == 1)
                {
                    ADMINVerDatosTodosUsuario frm =
                        new ADMINVerDatosTodosUsuario();

                    frm.Show();
                }
                else
                {
                    FrmVotaciones frm =
                    new FrmVotaciones();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void TempUserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
