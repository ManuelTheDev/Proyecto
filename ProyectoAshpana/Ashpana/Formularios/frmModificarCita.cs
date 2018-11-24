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
    public partial class frmModificarCita : Form
    {
        private CitaBL citaBL;
        private Cita citaMod; 

        public frmModificarCita(Cita cita)
        {
            InitializeComponent();
            citaMod = new Cita();
            citaBL = new CitaBL();

            txtMontoTotal.Text = Convert.ToString(cita.MontoTotal);
            txtPaciente.Text = cita.NombPersona;
            citaMod.IdCita = cita.IdCita;
            citaMod.MontoTotal = cita.MontoTotal;
            citaMod.Estado_pago = cita.Estado_pago;
            citaMod.DetallesCitas = citaBL.listarDetallesCitas_X_Cita(citaMod.IdCita);
            dgvDetallesCitas.AutoGenerateColumns = false; 
            dgvDetallesCitas.DataSource = citaMod.DetallesCitas;

            if (citaMod.Estado_pago == 0)
            {
                cboEstadoPago.Text = "PENDIENTE";
            }
            else
            {
                cboEstadoPago.Text = "PAGADO";
            }

        }

        private void btnListarTratamientos_Click(object sender, EventArgs e)
        {

        }

        private void btnListarPaquete_Click(object sender, EventArgs e)
        {

        }

        private void btnVerDetalleServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
