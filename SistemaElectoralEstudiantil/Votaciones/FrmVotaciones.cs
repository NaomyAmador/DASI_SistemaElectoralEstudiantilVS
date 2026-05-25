using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace SistemaElectoralEstudiantil
{
    public partial class FrmVotaciones : Form
    {
        public FrmVotaciones()
        {
            InitializeComponent();
        }

        private void FrmVotaciones_Load(
            object sender,
            EventArgs e)
        {
            CargarPlanchas();

            VerificarSiYaVoto();
        }

        private void CargarPlanchas()
        {
            LogicaNegocioVotaciones logica =
                new LogicaNegocioVotaciones();

            List<Planchas> lista =
                logica.ObtenerPlanchas();

            flpPlanchas.Controls.Clear();

            foreach (Planchas plancha in lista)
            {
                Panel tarjeta =
                    CrearTarjetaPlancha(plancha);

                flpPlanchas.Controls.Add(
                    tarjeta);
            }
        }

        private Panel CrearTarjetaPlancha(
            Planchas plancha)
        {
            Panel panel =
                new Panel();

            panel.Width = 260;

            panel.Height = 320;

            panel.BorderStyle =
                BorderStyle.FixedSingle;

            panel.Margin =
                new Padding(15);

            panel.BackColor =
                Color.White;

            PictureBox pbLogo =
                new PictureBox();

            pbLogo.Width = 120;

            pbLogo.Height = 120;

            pbLogo.Top = 10;

            pbLogo.Left = 65;

            pbLogo.SizeMode =
                PictureBoxSizeMode.StretchImage;

            if (plancha.Logo != null)
            {
                using (MemoryStream ms =
                    new MemoryStream(plancha.Logo))
                {
                    pbLogo.Image =
                        Image.FromStream(ms);
                }
            }

            Label lblNombre =
                new Label();

            lblNombre.Text =
                plancha.NombrePlancha;

            lblNombre.Font =
                new Font(
                    "Arial",
                    12,
                    FontStyle.Bold);

            lblNombre.AutoSize = false;

            lblNombre.Width = 220;

            lblNombre.Height = 30;

            lblNombre.TextAlign =
                ContentAlignment.MiddleCenter;

            lblNombre.Top = 145;

            lblNombre.Left = 15;

            Label lblDescripcion =
                new Label();

            lblDescripcion.Text =
                plancha.Descripcion;

            lblDescripcion.Width = 220;

            lblDescripcion.Height = 60;

            lblDescripcion.Top = 180;

            lblDescripcion.Left = 15;

            lblDescripcion.TextAlign =
                ContentAlignment.MiddleCenter;

            Button btnVotar =new Button();

            btnVotar.Text = "Votar";

            btnVotar.Width = 120;

            btnVotar.Height = 40;

            btnVotar.Top = 250;

            btnVotar.Left = 65;

            btnVotar.Tag =
                plancha.PlanchaID;

            btnVotar.BackColor =
                Color.LightBlue;

            btnVotar.Click +=
                BtnVotar_Click;

            panel.Controls.Add(pbLogo);

            panel.Controls.Add(lblNombre);

            panel.Controls.Add(lblDescripcion);

            panel.Controls.Add(btnVotar);

            return panel;
        }

        private void BtnVotar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Button btn =
                    (Button)sender;

                int planchaID =
                    Convert.ToInt32(
                        btn.Tag);

                int usuarioID =
                    Sesion.UsuarioActual
                    .UsuarioID;

                int votacionID = 1;

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Desea votar por esta plancha?",
                        "Confirmar Voto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LogicaNegocioVotaciones logica =
                        new LogicaNegocioVotaciones();

                    bool voto =
                        logica.RegistrarVotoPlancha(
                            usuarioID,
                            planchaID,
                            votacionID);

                    if (voto)
                    {
                        MessageBox.Show(
                            "Voto registrado correctamente");

                        DeshabilitarBotonesVotar();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo registrar el voto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerificarSiYaVoto()
        {
            try
            {
                LogicaNegocioVotaciones logica =
                    new LogicaNegocioVotaciones();

                bool yaVoto =
                    logica.VerificarSiUsuarioYaVoto(
                        Sesion.UsuarioActual.UsuarioID);

                if (yaVoto)
                {
                    DeshabilitarBotonesVotar();

                    MessageBox.Show(
                        "Usted ya realizó su voto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void DeshabilitarBotonesVotar()
        {
            foreach (Control control in flpPlanchas.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control item in control.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = false;
                            btnVotoNulo.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado =
                    MessageBox.Show(
                        "¿Desea registrar un voto nulo?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LogicaNegocioVotaciones logica =
                        new LogicaNegocioVotaciones();

                    bool voto =
                        logica.RegistrarVotoNulo(
                            Sesion.UsuarioActual.UsuarioID,
                            1);

                    if (voto)
                    {
                        MessageBox.Show(
                            "Voto nulo registrado");

                        DeshabilitarBotonesVotar();

                        btnVotoNulo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo registrar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flpPlanchas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
