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
    public partial class frmModificarTratamiento : Form
    {
        private TratamientoBL tratamientoBL;
        private Tratamiento tratamiento;

        public TratamientoBL TratamientoBL { get => tratamientoBL; set => tratamientoBL = value; }
        public Tratamiento Tratamiento { get => tratamiento; set => tratamiento = value; }

        public frmModificarTratamiento()
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
            tratamiento = new Tratamiento();
        }

        public frmModificarTratamiento(Tratamiento trat)
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
            tratamiento = new Tratamiento();
            Tratamiento = trat;

            txtNombreTrat.Text = tratamiento.NombreTrat;
            txtDuracion.Text = tratamiento.DuracionTrat.ToString();
            txtPrecio.Text = tratamiento.PrecioTrat.ToString();

            if (tratamiento.TipoTrat == 0)
            {
                rbtnCorporal.Checked = true;
            }
            else rbtnCorporal.Checked = false;

            if (tratamiento.TipoTrat == 1)
                rbtnFacial.Checked = true;
            else rbtnFacial.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tratamiento trat = new Tratamiento();
            trat.NombreTrat = txtNombreTrat.Text;
            trat.DuracionTrat = Int32.Parse(txtDuracion.Text);
            trat.PrecioTrat = double.Parse(txtPrecio.Text);

            if (rbtnCorporal.Checked == true)
                trat.TipoTrat = 0;
            else
                trat.TipoTrat = 1;

            tratamientoBL.modificarTratamiento(trat);
            this.DialogResult = DialogResult.OK;


        }
    }
}
