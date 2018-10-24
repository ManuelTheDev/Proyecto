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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmRegistroTratamientos : Form
    {
        private TratamientoBL tratamientoBL;
        public frmRegistroTratamientos()
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tratamiento trat = new Tratamiento();
            if (txtNombreTrat.Text.Trim() == "")
            {
                lblErrorNombre.Visible = true;
                MessageBox.Show("Por favor ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            trat.NombreTrat = txtNombreTrat.Text.Trim();
            lblErrorNombre.Visible = false;

            if (rbtnFacial.Checked == true)
            {
                trat.TipoTrat = 1;
                lblErrorTipo.Visible = false;
            }
            else if (rbtnCorporal.Checked == true)
            {
                trat.TipoTrat = 0;
                lblErrorTipo.Visible = false;
            }
            else lblErrorTipo.Visible = true;

            try
            {
                trat.DuracionTrat = double.Parse(txtDuracion.Text.Trim());
                lblErrorDuracion.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorDuracion.Visible = true;
                MessageBox.Show("Por favor ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                trat.PrecioTrat = double.Parse(txtPrecio.Text.Trim());
                lblErrorPrecio.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorPrecio.Visible = true;
                MessageBox.Show("Por favor ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tratamientoBL.registrarTratamiento(trat) != 0)
            {
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //estadoComponentes(Estado.Guardar);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            this.DialogResult = DialogResult.OK;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoles_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescPadecimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomPadecimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZonaTratar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoTratamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }

        private void lblDescPadecimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblNomPadecimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblZonaTratar_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoTratamiento_Click(object sender, EventArgs e)
        {

        }
    }
}
