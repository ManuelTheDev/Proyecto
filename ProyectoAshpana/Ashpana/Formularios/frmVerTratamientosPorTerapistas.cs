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
    public partial class frmVerTratamientosPorTerapistas : Form
    {
        private Tratamiento tratamientoSeleccionado;
        private Terapista terapistaModificar;
        private TerapistaBL terapistaBL;
        public frmVerTratamientosPorTerapistas(Terapista terapistaSeleccionada)
        {
            InitializeComponent();
            txtNombreTerapista.Text = terapistaSeleccionada.Nombres + " " + terapistaSeleccionada.ApPaterno + " " + terapistaSeleccionada.ApMaterno;
            dgvTratamientos.AutoGenerateColumns = false;
            terapistaModificar = new Terapista();
            terapistaModificar = terapistaSeleccionada;
            dgvTratamientos.AutoGenerateColumns = false;
            terapistaBL = new TerapistaBL();
            dgvTratamientos.DataSource = terapistaBL.listarTratamientos_x_Terapista(terapistaModificar.IdTerapista);

        }

        private void btnRegistrarTratamientos_Click(object sender, EventArgs e)
        {
            var frmRegistrarTrat = new frmRegistrarTratamientosXTerapista(terapistaModificar);
            if (frmRegistrarTrat.ShowDialog()== DialogResult.OK)
            {

            }
        }

        private void btnModificarTratamientos_Click(object sender, EventArgs e)
        {
            var frmModificarTratamientos = new frmModificaTratamientosXTerapista(terapistaModificar);
            if (frmModificarTratamientos.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
