using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil.DatosPlancha
{
    public partial class FrmDatosPlancha : Form
    {
        public FrmDatosPlancha()
        {
            InitializeComponent();
        }

        private void FrmDatosPlancha_Load(object sender, EventArgs e)
        {

        }

        private void MostrarDatos(string Nombre, string Curso, string Propuesta, string FrasePersonal, Image Foto)
        {
            Lbl_Nombre.Text = Nombre;
            Lbl_Curso.Text = Curso;
            Lbl_Propuesta.Text = Propuesta;
            Lbl_Frase.Text = FrasePersonal;
            PicBox_CandidatoElegido.Image = Foto;
        }

        private void Btn_InfoPresidente_Click(object sender, EventArgs e)
        {
            MostrarDatos("Miriam Rogríguez", "5to A Informática", "Más actividades estudiantiles", "¡Juntos podemos más!", pictureBox1.Image);
        }

        private void Btn_InfoVicepresidente_Click(object sender, EventArgs e)
        {
            MostrarDatos("José Pérez", "5to B Gestión", "Más eventos escolares", "¡El cambio empieza hoy!", pictureBox2.Image);
        }

        private void Btn_InfoSecretario_Click(object sender, EventArgs e)
        {
            MostrarDatos("Ana Martínez", "5to A Gastronomía", "Mejor comunicación", "¡Tu voz cuenta!", pictureBox3.Image);
        }

        private void Btn_InfoTesorero_Click(object sender, EventArgs e)
        {
            MostrarDatos("Carlos Gómez", "5to de Electrónica", "Mejor control monetario", "¡Unidos somos mejores!", pictureBox4.Image);
        }

        private void Btn_Votar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
