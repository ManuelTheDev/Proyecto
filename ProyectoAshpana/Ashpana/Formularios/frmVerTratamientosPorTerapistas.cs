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
        public frmVerTratamientosPorTerapistas(Terapista terapistaSeleccionada)
        {
            InitializeComponent();
            txtNombreTerapista.Text = terapistaSeleccionada.Nombres + " " + terapistaSeleccionada.ApPaterno + " " + terapistaSeleccionada.ApMaterno;
            dgvTratamientos.AutoGenerateColumns = false;
            terapistaModificar = new Terapista();
            terapistaModificar = terapistaSeleccionada;
            dgvTratamientos.AutoGenerateColumns = false;
            dgvTratamientos.DataSource = terapistaModificar.Tratamientos;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int indice = dgvTratamientos.CurrentRow.Index;
            terapistaModificar.Tratamientos.RemoveAt(indice);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
