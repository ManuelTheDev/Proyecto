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
    public partial class frmNuevaCita : Form
    {
        private Tratamiento tratamientoSeleccionado;
        private Paquete paqueteSeleccionado;
        private Cliente pacienteSeleccionado;
        public Cita cita;
        private CitaBL citaBL; 

        public frmNuevaCita()
        {
            InitializeComponent();
            cita = new Cita();
            citaBL = new CitaBL();
            dgvDetallesCitas.AutoGenerateColumns = false;
            dgvDetallesCitas.DataSource = cita.DetallesCitas;
            txtMontoTotal.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text == "")
            {
                MessageBox.Show("Por favor ingrese un cliente de la lista");
                return;
            }
            frmListarTratamiento frmListarTrat = new frmListarTratamiento();
            if (frmListarTrat.ShowDialog() == DialogResult.OK)
            {
                if (frmListarTrat.Tratamiento.verificarClienteApto(pacienteSeleccionado))
                {
                    tratamientoSeleccionado = frmListarTrat.Tratamiento;
                    DetalleCita dt = new DetalleCita();
                    dt.Servicio = tratamientoSeleccionado;
                    dt.Servicio.NumSesiones = 1;
                    cita.DetallesCitas.Add(dt);
                    if (txtMontoTotal.Text == "")
                    {
                        txtMontoTotal.Text = dt.Precio.ToString();
                    }
                    else
                    {
                        double monto = Double.Parse(txtMontoTotal.Text) + tratamientoSeleccionado.PrecioServicio;
                        txtMontoTotal.Text = Convert.ToString(monto);
                    }
                }
                else
                {
                    MessageBox.Show("El paciente no está apto para el tratamiento", "ErrorTratamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text == "")
            {
                MessageBox.Show("Por favor ingrese un cliente de la lista");
                return; 
            }
            frmListarPaquete frmListarPaq = new frmListarPaquete();
            if (frmListarPaq.ShowDialog() == DialogResult.OK)
            {
                if (frmListarPaq.Paquete.verificarClienteApto(pacienteSeleccionado))
                {
                    paqueteSeleccionado = frmListarPaq.Paquete;
                    DetalleCita dt = new DetalleCita();
                    dt.Servicio = paqueteSeleccionado;
                    dt.Servicio.NumSesiones = paqueteSeleccionado.NumSesiones;
                    cita.DetallesCitas.Add(dt);
                    if (txtMontoTotal.Text == "")
                    {
                        txtMontoTotal.Text = dt.Precio.ToString();
                    }
                    else
                    {
                        double monto = Double.Parse(txtMontoTotal.Text) + paqueteSeleccionado.PrecioServicio;
                        txtMontoTotal.Text = Convert.ToString(monto);
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no está apto para el paquete", "ErrorPaquete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text == "")
            {
                MessageBox.Show("Por favor ingrese un cliente de la lista");
                return;
            }

            if (txtMontoTotal.Text == "")
            {
                MessageBox.Show("Por favor seleccione algún tratamiento o paquete");
                return;
            }
            if (dgvDetallesCitas.Rows.Count == 0)
            {
                MessageBox.Show("Debe haber al menos un tratamiento o paquete en la cita", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cita.Cliente = pacienteSeleccionado;
            cita.MontoTotal = Double.Parse(txtMontoTotal.Text);
            
            if (citaBL.registrarCita(cita) == 1)
            {
                MessageBox.Show("Se ha reservado satisfactoriamente la cita", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("No se ha podido reservar la cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            this.Dispose();

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

        private void btnAgregarTratamiento_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            frmListarPacientes frmListarPacientes = new frmListarPacientes();
            if (frmListarPacientes.ShowDialog() == DialogResult.OK)
            {
                pacienteSeleccionado = frmListarPacientes.Cliente;
                txtPaciente.Text = pacienteSeleccionado.Nombres + " " + pacienteSeleccionado.ApPaterno + " " + pacienteSeleccionado.ApMaterno;
                cita.Cliente = pacienteSeleccionado; 
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (dgvDetallesCitas.Rows.Count == 0)
            {
                MessageBox.Show("No hay tratamientos o paquetes disponibles para eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indice = dgvDetallesCitas.CurrentRow.Index;
            double monto = Double.Parse(txtMontoTotal.Text) - cita.DetallesCitas[indice].Precio;
            txtMontoTotal.Text = Convert.ToString(monto);
            cita.DetallesCitas.RemoveAt(indice);

        }

        private void btnVerDetalleServicio_Click(object sender, EventArgs e)
        {

            if (dgvDetallesCitas.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un tratamiento o paquete", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int indice = dgvDetallesCitas.CurrentRow.Index;
            frmDetalleCita frmVerDetalleCita = new frmDetalleCita(cita.DetallesCitas[indice]); 
            if (frmVerDetalleCita.ShowDialog() == DialogResult.OK)
            {
                cita.DetallesCitas[indice] = frmVerDetalleCita.DetalleServicioModificado; 
            }
        }
    }
}
