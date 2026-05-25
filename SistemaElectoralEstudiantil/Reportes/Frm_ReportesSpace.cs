using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaElectoralEstudiantil.Reportes
{
    public partial class Frm_ReportesSpace : Form
    {
        public Frm_ReportesSpace()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
