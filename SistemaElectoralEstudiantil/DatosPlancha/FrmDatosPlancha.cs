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

        private void MostrarDatos(string Nombre, string Curso, string Propuesta, string FrasePersonal)
        {
            Lbl_Nombre.Text = "Nombre: " + Nombre;
            Lbl_Curso.Text = "Curso: " + Curso;
            Lbl_Propuesta.Text = "Cargo: " + Propuesta;
            Lbl_Frase.Text = "Propuesta: " + FrasePersonal;
        }

        private void Btn_InfoPresidente_Click(object sender, EventArgs e)
        {
            MostrarDatos("Miriam Rogríguez", "5to A Informática", "Mejorar las actividades estudiantiles", "¡Juntos podemos más!");
        }

        private void Btn_InfoVicepresidente_Click(object sender, EventArgs e)
        {
            MostrarDatos("José Pérez", "5to B Gestión", "Apoyar más eventos escolares", "¡El cambio empieza hoy!");
        }

        private void Btn_InfoSecretario_Click(object sender, EventArgs e)
        {
            MostrarDatos("Ana Martínez", "5to A Gastronomía", "Mejor comunicación entre estudiantes", "¡Tu voz cuenta!");
        }

        private void Btn_InfoTesorero_Click(object sender, EventArgs e)
        {
            MostrarDatos("Carlos Gómez", "5to de Electrónica", "Organizar mejor los fondos estudiantiles", "¡Unidos somos mejores!");
        }
    }
}
