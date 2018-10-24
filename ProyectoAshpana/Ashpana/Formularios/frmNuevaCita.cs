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
    public partial class frmNuevaCita : Form
    {
        public frmNuevaCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            frmListarTratamiento frmAgTrata = new frmListarTratamiento();
            frmAgTrata.ShowDialog();
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            frmListarPaquete frmListarPaquetes = new frmListarPaquete();
            frmListarPaquetes.ShowDialog(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha reservado satisfactoriamente la cita", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevaCita_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void idPaquete_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbpTerapista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
