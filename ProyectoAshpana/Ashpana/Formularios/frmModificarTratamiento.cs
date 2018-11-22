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
    public partial class frmModificarTratamiento : Form
    {
        private TratamientoBL tratamientoBL;
        private Tratamiento tratamiento1;
        private CondicionMedicaBL condMedBL;
        private ZonaBL zonaBL;

        public TratamientoBL TratamientoBL { get => tratamientoBL; set => tratamientoBL = value; }
        public Tratamiento Tratamiento1 { get => tratamiento1; set => tratamiento1 = value; }


        /*public frmModificarTratamiento()
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
            tratamiento = new Tratamiento();
        }*/

        public frmModificarTratamiento(Tratamiento trat)
        {
            InitializeComponent();
            tratamientoBL = new TratamientoBL();
            condMedBL = new CondicionMedicaBL();
            zonaBL = new ZonaBL();
            tratamiento1 = new Tratamiento();
            Tratamiento1 = trat;
            txtNombreTrat.Text = tratamiento1.NombreServicio;
            txtDuracion.Text = tratamiento1.DuracionTrat.ToString();
            txtPrecio.Text = tratamiento1.PrecioServicio.ToString();

            if (tratamiento1.TipoTrat == 0)
            {
                rbtnCorporal.Checked = true;
            }
            else rbtnCorporal.Checked = false;

            if (tratamiento1.TipoTrat == 1)
                rbtnFacial.Checked = true;
            else rbtnFacial.Checked = false;

            BindingList<CondicionMedica> condicionesMedicas = condMedBL.listarCondicionesMedicas();
            foreach (CondicionMedica cm in condicionesMedicas)
            {
                chlCondMedicas.Items.Add(cm);
            }

            BindingList<CondicionMedica> condicionMedicasTratamiento = condMedBL.listarCondicionesMedicas_X_Tratamiento(tratamiento1.IdTrat);
            foreach (CondicionMedica c in condicionMedicasTratamiento)
            {
                int indice = chlCondMedicas.Items.IndexOf(c);
                chlCondMedicas.SetItemChecked(indice, true);
            }

            BindingList<Zona> zonas = zonaBL.listarZonas();
            foreach (Zona z in zonas)
            {
                chlZonas.Items.Add(z);
            }

            BindingList<Zona> zonasTratamiento = zonaBL.listarZonas_X_Tratamiento(tratamiento1.IdTrat);
            foreach(Zona a in zonasTratamiento)
            {
                int indice = chlZonas.Items.IndexOf(a);

                chlZonas.SetItemChecked(indice, true);
            }

           

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tratamiento trat1 = new Tratamiento();
            trat1.IdTrat = tratamiento1.IdTrat;

            if ((txtNombreTrat.Text.Trim() == "") || (txtNombreTrat.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            trat1.NombreServicio = txtNombreTrat.Text.Trim();

            try
            {
                if (txtDuracion.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                trat1.DuracionTrat = double.Parse(txtDuracion.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente la duracion en minutos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (txtPrecio.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                trat1.PrecioServicio = double.Parse(txtPrecio.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el precio en soles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rbtnCorporal.Checked == true)
                trat1.TipoTrat = 0;
            else
                trat1.TipoTrat = 1;

            if (rbtnFacial.Checked == false && rbtnCorporal.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un tipo de tratamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tratamientoBL.desacativarCondMedicas_X_Tratamiento(tratamiento1.IdTrat);

            for (int i = 0; i < chlCondMedicas.CheckedIndices.Count; i++)
            {
                trat1.CondicionesMedicas.Add((CondicionMedica)chlCondMedicas.CheckedItems[i]);

            }

            tratamientoBL.desactivarZonas_X_Tratamiento(tratamiento1.IdTrat);

            for (int i = 0; i < chlZonas.CheckedIndices.Count; i++)
            {
                trat1.ZonasTratar.Add((Zona)chlZonas.CheckedItems[i]);

            }

            if (tratamientoBL.modificarTratamiento(trat1)==1)
            {
                MessageBox.Show("Se ha registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.DialogResult = DialogResult.OK;


        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtDuracion.Text)) txtDuracion.ForeColor = Color.Red;
            else txtDuracion.ForeColor = Color.Black;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)//no acepta ingresar cero como objeto, solo puedes ingresar un cero si es 0.x
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtPrecio.Text)) txtPrecio.ForeColor = Color.Red;
            else txtPrecio.ForeColor = Color.Black;
        }

        private void txtNombreTrat_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombreTrat.Text)) txtNombreTrat.ForeColor = Color.Red;
            else txtNombreTrat.ForeColor = Color.Black;
        }
    }
}
