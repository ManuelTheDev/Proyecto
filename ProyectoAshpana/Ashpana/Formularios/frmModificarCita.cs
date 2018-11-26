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
        private Cita citaAnt;

        public frmModificarCita(Cita cita)
        {
            InitializeComponent();
            citaMod = new Cita();
            citaBL = new CitaBL();
            citaAnt = new Cita();
            

            txtMontoTotal.Text = Convert.ToString(cita.MontoTotal);
            txtPaciente.Text = cita.NombPersona;
            citaMod.IdCita = cita.IdCita;
            citaAnt.IdCita = cita.IdCita;
            citaMod.MontoTotal = cita.MontoTotal;
            citaAnt.MontoTotal = cita.MontoTotal;
            citaMod.Estado_pago = cita.Estado_pago;
            citaAnt.Estado_pago = cita.Estado_pago;
            citaAnt.Cliente = cita.Cliente;
            citaMod.Cliente = cita.Cliente;

            citaMod.DetallesCitas = citaBL.listarDetallesCitas_X_Cita(citaMod.IdCita);
            citaAnt.DetallesCitas = citaBL.listarDetallesCitas_X_Cita(citaMod.IdCita);

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
        private void btnVerDetalleServicio_Click(object sender, EventArgs e)
        {
            if (dgvDetallesCitas.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un tratamiento o paquete", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmModificarDetalleSesion fmc = new frmModificarDetalleSesion((DetalleCita)dgvDetallesCitas.CurrentRow.DataBoundItem);
            fmc.ShowDialog();

            if (fmc.DialogResult == DialogResult.OK)
            {
                citaMod.DetallesCitas[dgvDetallesCitas.CurrentRow.Index] = fmc.DetalleCita1;
            }
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboEstadoPago.Text.Equals("PENDIENTE"))
            {
                citaMod.Estado_pago = 0;
            }
            else if (cboEstadoPago.Text.Equals("PAGADO"))
            {
                citaMod.Estado_pago = 1;
            }
            citaBL.actualizarCita(citaAnt, citaMod);
            MessageBox.Show("Se ha modificado correctamente la cita", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
