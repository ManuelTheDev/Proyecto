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
    public partial class frmNuevoPaquete : Form
    {
        private PaqueteBL paquetesBL;
        private Paquete paquete;
        private Tratamiento tratamientoSeleccionado;
        public frmNuevoPaquete()
        {
            InitializeComponent();
            paquetesBL = new PaqueteBL();
            paquete = new Paquete();

            dgvTratamientos.AutoGenerateColumns = false;
            dgvTratamientos.DataSource = paquete.Tratamientos;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombrePaquete.Text;
                double precio = Double.Parse(txtPrecio.Text);
                int numSesiones = Int32.Parse(txtNumSesiones.Text);

                paquete.NombreServicio = nombre;
                paquete.PrecioServicio = precio;
                paquete.NumSesiones = numSesiones;

                if (paquete.PrecioServicio <= 0 || paquete.NumSesiones <= 0)
                {
                    MessageBox.Show("Ingrese Numeros válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paquetesBL.RegistrarPaquete(paquete);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Se ha registrado el paquete correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error en la base de datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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
                paquete.Tratamientos.Add(t);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dgvTratamientos.CurrentRow.Index;
            paquete.Tratamientos.RemoveAt(indice);
        }

        private void txtNombrePaquete_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombrePaquete.Text)) txtNombrePaquete.ForeColor = Color.Red;
            else txtNombrePaquete.ForeColor = Color.Black;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtPrecio.Text)) txtPrecio.ForeColor = Color.Red;
            else txtPrecio.ForeColor = Color.Black;
        }

        private void txtNumSesiones_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d+$");
            if (!rgx.IsMatch(txtNumSesiones.Text)) txtNumSesiones.ForeColor = Color.Red;
            else txtNumSesiones.ForeColor = Color.Black;
        }
    }
}
