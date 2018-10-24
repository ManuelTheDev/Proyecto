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
    public partial class frmGestionTerapistas : Form
    {
        private Terapista terapistaSeleccionada;
        private TerapistaBL terapistaBL;

        public frmGestionTerapistas()
        {
            InitializeComponent();
            terapistaBL = new TerapistaBL();
            dgvTerapistas.AutoGenerateColumns = false;
            dgvTerapistas.DataSource = terapistaBL.listarTerapistas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoTerapista_Click(object sender, EventArgs e)
        {
            frmNuevoTerapista frmTerapista = new frmNuevoTerapista();
            if (frmTerapista.ShowDialog() == DialogResult.OK)
            {
                terapistaBL = new TerapistaBL();
                dgvTerapistas.AutoGenerateColumns = false;
                dgvTerapistas.DataSource = terapistaBL.listarTerapistas();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            terapistaSeleccionada = (Terapista)dgvTerapistas.CurrentRow.DataBoundItem;
            frmModificarTerapista frmTerapista = new frmModificarTerapista(terapistaSeleccionada);
            frmTerapista.ShowDialog();
            if (frmTerapista.DialogResult == DialogResult.OK)
            {
                terapistaBL = new TerapistaBL();
                dgvTerapistas.AutoGenerateColumns = false;
                dgvTerapistas.DataSource = terapistaBL.listarTerapistas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
