using Entidades;
using LogicaNegocio;
using SistemaElectoralEstudiantil.DatosPlancha;
using SistemaElectoralEstudiantil.FolderPrueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaElectoralEstudiantil.Principal
{
    public partial class FrmLogin : Form
    {
        Usuarios User;
        public FrmLogin()
        {
            InitializeComponent();
            //Configuración del ProgressBar
            ProgressBar_InicioSesión.Minimum = 0;
            ProgressBar_InicioSesión.Maximum = 100;
            ProgressBar_InicioSesión.Value = 0;
            ProgressBar_InicioSesión.Step = 1;

            //Configuración del Timer
            Tiempo_InicioSesión.Interval = 100;

            //Label del ProgressBar
            Lbl_ProgressBarTexto.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            Lbl_ProgressBarTexto.ForeColor = this.BackColor;
        }

        private void Btn_IniciarSesión_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio Logica = new UsuarioNegocio();
                User = Logica.Login(TxtBox_Usuario.Text, TxtBox_Password.Text);
                Sesion.UsuarioActual = User;

                //Reiniciar ProgressBar
                ProgressBar_InicioSesión.Value = 0;
                Lbl_ProgressBarTexto.Text = "Iniciando sesión...";
                Lbl_ProgressBarTexto.ForeColor = Color.Peru;
                //Iniciar Timer
                Tiempo_InicioSesión.Start();
            }
            catch (Exception Errores)
            {
                MessageBox.Show(Errores.Message);
            }
        }

        private void Tiempo_InicioSesión_Tick(object sender, EventArgs e)
        {
            ProgressBar_InicioSesión.PerformStep();
            if (ProgressBar_InicioSesión.Value >= 100)
            {
                Tiempo_InicioSesión.Stop();
                MessageBox.Show( "Bienvenido " + User.NombreCompleto);
                this.Hide();

                if (User.RolID == 1)
                {
                    FrmAdmin FrmAdmin = new FrmAdmin();
                    FrmAdmin.Show();
                }
                else
                {
                    FrmVotante FrmVotante = new FrmVotante();
                    FrmVotante.Show();
                }
            }
        }

        private void Btn_VerPassword_Click(object sender, EventArgs e)
        {
            if (TxtBox_Password.PasswordChar == '*')
            {
                TxtBox_Password.PasswordChar = '\0';
                Btn_NoVerPassword.BringToFront();
            }
        }

        private void Btn_NoVerPassword_Click(object sender, EventArgs e)
        {
            if (TxtBox_Password.PasswordChar == '\0')
            {
                TxtBox_Password.PasswordChar = '*';
                Btn_VerPassword.BringToFront();
            }
        }
    }
}
