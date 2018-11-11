using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmGestionTratamientos : Form
    {
        private TratamientoBL tratamientoBL;
        private BindingList<Tratamiento> tratamientos;

        public frmGestionTratamientos()
        {
            InitializeComponent();
            CargarDGV();
        }

        private void CargarDGV()
        {
            tratamientoBL = new TratamientoBL();
            dgvTratamientos.AutoGenerateColumns = false;
            tratamientos = tratamientoBL.listarTratamientos();
            dgvTratamientos.DataSource = tratamientos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmNuevoTratamientos fat = new frmNuevoTratamientos();
            //fat.ShowDialog();
            if (fat.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void dgvTratamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento = (Tratamiento)dgvTratamientos.CurrentRow.DataBoundItem;
            frmModificarTratamiento fmt = new frmModificarTratamiento(tratamiento);
            fmt.ShowDialog();

            if (fmt.DialogResult == DialogResult.OK)
            {
                CargarDGV();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento = (Tratamiento)dgvTratamientos.CurrentRow.DataBoundItem;
            frmModificarTratamiento fmt = new frmModificarTratamiento(tratamiento);
            fmt.ShowDialog();

            if (fmt.DialogResult == DialogResult.OK)
            {
                CargarDGV();

            }
        }

        private void btnVerCondMed_Click(object sender, EventArgs e)
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento = (Tratamiento)dgvTratamientos.CurrentRow.DataBoundItem;
            frmVerCondicionesMedicasPorTratamiento formCondMed = new frmVerCondicionesMedicasPorTratamiento(tratamiento.IdTrat);
            formCondMed.ShowDialog();
        }

        private void btnVerZonas_Click(object sender, EventArgs e)
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento = (Tratamiento)dgvTratamientos.CurrentRow.DataBoundItem;
            frmVerZonasATratarPorTratamiento formZonas = new frmVerZonasATratarPorTratamiento(tratamiento.IdTrat);
            formZonas.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTratamientos.DataSource = tratamientoBL.BuscarTratamiento(txtboxBuscarPaquetes.Text);
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var tratBuscados = new BindingList<Tratamiento>();

            foreach (Tratamiento t in tratamientos)
            {
                //String patron = @"^(\w)+" + busqueda + @"(\w)+$";
                Regex rgx = new Regex(@"^[\w\s]*" + busqueda + @"[\w\s]*$");
                if (rgx.IsMatch(t.Nombre))
                {
                    tratBuscados.Add(t);
                }

            }

            dgvTratamientos.DataSource = tratBuscados;
        }
    }
}
