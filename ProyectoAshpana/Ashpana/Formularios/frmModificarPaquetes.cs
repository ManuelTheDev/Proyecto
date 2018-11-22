using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmModificarPaquetes : Form
    {

        private PaqueteBL paqueteBL;
        private Paquete paquete;
        private Paquete paqueteMod;
        private Tratamiento tratamientoSeleccionado;

        public frmModificarPaquetes()
        {
            InitializeComponent();
            paqueteBL = new PaqueteBL();
        }

        public frmModificarPaquetes(Paquete p)
        {
            InitializeComponent();
            paquete = new Paquete();
            paqueteMod = new Paquete();
            paqueteBL = new PaqueteBL();

            paquete.IdServicio = p.IdServicio;
            paquete.NombreServicio = p.NombreServicio;
            paquete.PrecioServicio = p.PrecioServicio;
            paqueteMod.IdServicio = p.IdServicio;
            paqueteMod.NombreServicio = p.NombreServicio;
            paqueteMod.PrecioServicio = p.PrecioServicio;
            paqueteMod.EstadoServicio = 1;


            paquete.NumSesiones = p.NumSesiones;
            paquete.IdPaquete = p.IdPaquete;
            paqueteMod.NumSesiones = p.NumSesiones;
            paqueteMod.IdPaquete = p.IdPaquete;

            foreach(Tratamiento trat in p.Tratamientos)
            {
                paquete.Tratamientos.Add(trat);
                paqueteMod.Tratamientos.Add(trat);
            }

            txtNombre.Text = p.NombreServicio;
            txtNumSes.Text = p.NumSesiones.ToString();
            txtPrecio.Text = p.PrecioServicio.ToString();

            dgvTratamientos.AutoGenerateColumns = false;
            dgvTratamientos.DataSource = paqueteMod.Tratamientos;
        }
        private void frmPaquetesModificar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e) //Modificar
        {
            if ((txtNombre.Text.Trim() == "") || (txtNombre.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un Nombre correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            paqueteMod.NombreServicio = txtNombre.Text.Trim();

            try
            {
                if (txtPrecio.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                paqueteMod.PrecioServicio = double.Parse(txtPrecio.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (txtNumSes.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el número de sesiones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                paqueteMod.NumSesiones = int.Parse(txtNumSes.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el número de sesiones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            paqueteBL.actualizar(paquete, paqueteMod);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modificado el elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            Tratamiento t = new Tratamiento();
            t = tratamientoSeleccionado;

            int encontrado = 0;
            int indice = 0;
            foreach (Tratamiento tAux in paquete.Tratamientos)
            {
                if (tAux.IdTrat == t.IdTrat)
                {
                    encontrado = 1;
                    break;
                }
                indice += 1;
            }

            if (encontrado == 0)
            {
                paqueteMod.Tratamientos.Add(t);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = dgvTratamientos.CurrentRow.Index;
            paqueteMod.Tratamientos.RemoveAt(indice);
            
        }

        private void btnListarTratamientos_Click(object sender, EventArgs e)
        {
            frmListarTratamiento frmListarTrat = new frmListarTratamiento();
            if (frmListarTrat.ShowDialog() == DialogResult.OK)
            {
                tratamientoSeleccionado = frmListarTrat.Tratamiento;
                txtIdTratamiento.Text = tratamientoSeleccionado.IdTrat.ToString();
                txtNomTratamiento.Text = tratamientoSeleccionado.NombreServicio;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombre.Text)) txtNombre.ForeColor = Color.Red;
            else txtNombre.ForeColor = Color.Black;
        }

        private void txtIdTratamiento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtPrecio.Text)) txtPrecio.ForeColor = Color.Red;
            else txtPrecio.ForeColor = Color.Black;
        }

        private void txtNumSes_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9]\d*$");
            if (!rgx.IsMatch(txtNumSes.Text)) txtNumSes.ForeColor = Color.Red;
            else txtNumSes.ForeColor = Color.Black;
        }
    }
}
