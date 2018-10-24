using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmGestionCitas : Form
    {
        public frmGestionCitas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmNuevaCita frmNuevaCita = new frmNuevaCita();
            frmNuevaCita.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmModificarCita frmCita = new frmModificarCita();
            frmCita.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CITAS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
