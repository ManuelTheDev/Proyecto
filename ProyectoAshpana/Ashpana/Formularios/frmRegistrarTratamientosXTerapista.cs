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
    public partial class frmRegistrarTratamientosXTerapista : Form
    {
        private Tratamiento tratamientoSeleccionado;
        private Terapista terapistaModificado;
        private TerapistaBL terapistaBL;
        public frmRegistrarTratamientosXTerapista(Terapista t)
        {
            InitializeComponent();
            txtNombreTerapista.Text = t.Nombres + " " + t.ApPaterno + " " + t.ApMaterno;
            terapistaModificado = new Terapista();
            terapistaModificado = t;
            dgvTratamientos.AutoGenerateColumns = false;
            dgvTratamientos.DataSource = terapistaModificado.Tratamientos;
        }

        private void btnListarTratamientos_Click(object sender, EventArgs e)
        {
            var frmListarTrat = new frmListarTratamiento();
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
            foreach (Tratamiento tAux in terapistaModificado.Tratamientos)
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
                terapistaModificado.Tratamientos.Add(t);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dgvTratamientos.CurrentRow.Index;
            terapistaModificado.Tratamientos.RemoveAt(indice);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            terapistaBL = new TerapistaBL();
            bool registrado = terapistaBL.registrarTratamiento_X_terapista(terapistaModificado);

            if (registrado)
            {
                MessageBox.Show("Se ha registrado correctamente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
