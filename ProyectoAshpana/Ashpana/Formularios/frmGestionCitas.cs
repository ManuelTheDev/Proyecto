using LogicaNegocio;
using Modelo;
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
        private CitaBL citaBL;
        public frmGestionCitas()
        {
            InitializeComponent();
            citaBL = new CitaBL();
            dgvCitas.AutoGenerateColumns = false;
            dgvCitas.DataSource = citaBL.listarCitas();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmNuevaCita frmNuevaCita = new frmNuevaCita();
            frmNuevaCita.ShowDialog();
            dgvCitas.AutoGenerateColumns = false;
            dgvCitas.DataSource = citaBL.listarCitas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita();
            cita = (Cita)dgvCitas.CurrentRow.DataBoundItem;
            frmModificarCita fmc = new frmModificarCita(cita);
            fmc.ShowDialog();

            if (fmc.DialogResult == DialogResult.OK)
            {
                dgvCitas.AutoGenerateColumns = false;
                dgvCitas.DataSource = citaBL.listarCitas();

            }
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
