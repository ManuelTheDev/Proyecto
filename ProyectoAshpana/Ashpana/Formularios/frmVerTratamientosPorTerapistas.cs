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
        private Terapista terapista;
        private Terapista terapistaModificar;
        private TerapistaBL terapistaBL;

        public frmVerTratamientosPorTerapistas(Terapista terapistaSeleccionada)
        {
            InitializeComponent();
            terapistaModificar = new Terapista();
            terapistaBL = new TerapistaBL();
            terapista = new Terapista();

            terapista.IdPersona = terapistaSeleccionada.IdPersona;
            terapista.IdTrabajador = terapistaSeleccionada.IdTrabajador;
            terapista.IdTerapista = terapistaSeleccionada.IdTerapista;
            
            terapistaModificar.IdPersona = terapistaSeleccionada.IdPersona;
            terapistaModificar.IdTrabajador = terapistaSeleccionada.IdTrabajador;
            terapistaModificar.IdTerapista = terapistaSeleccionada.IdTerapista;
            terapistaModificar.Tratamientos = terapistaSeleccionada.Tratamientos;


            txtNombreTerapista.Text = terapistaSeleccionada.Nombres + " " + terapistaSeleccionada.ApPaterno + " " + terapistaSeleccionada.ApMaterno;
            dgvTratamientos.AutoGenerateColumns = false;
            terapistaModificar.Tratamientos= terapistaBL.listarTratamientos_X_Terapista(terapistaModificar.IdTerapista);
            terapista.Tratamientos= terapistaBL.listarTratamientos_X_Terapista(terapistaModificar.IdTerapista);
            dgvTratamientos.DataSource = terapistaModificar.Tratamientos;
        }

        private void btnRegistrarTratamientos_Click(object sender, EventArgs e)
        {
            terapistaBL = new TerapistaBL();

            if (dgvTratamientos.RowCount == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un Tratamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool registrado = terapistaBL.registrarTratamiento_X_terapista(terapista, terapistaModificar);

            if (registrado)
            {
                MessageBox.Show("Se ha registrado correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar correctamente");
            }
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnListarTratamientos_Click(object sender, EventArgs e)
        {
            var frmListarTrat = new frmListarTratamiento();
            if (frmListarTrat.ShowDialog() == DialogResult.OK)
            {
                tratamientoSeleccionado = frmListarTrat.Tratamiento;   
                txtNomTratamiento.Text = tratamientoSeleccionado.NombreServicio;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.RowCount != 0)
            {
                int indice = dgvTratamientos.CurrentRow.Index;
                terapistaModificar.Tratamientos.RemoveAt(indice);
            }
           
        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            if (txtNomTratamiento.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un tratamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tratamiento t = new Tratamiento();
            t = tratamientoSeleccionado;

            int encontrado = 0;
            int indice = 0;
            foreach (Tratamiento tAux in terapistaModificar.Tratamientos)
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
                terapistaModificar.Tratamientos.Add(t);
            }
        }
    }
}
