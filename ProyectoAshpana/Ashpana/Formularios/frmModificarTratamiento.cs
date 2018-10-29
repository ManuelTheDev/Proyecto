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
            trat1.NombreServicio = txtNombreTrat.Text;
            trat1.DuracionTrat = double.Parse(txtDuracion.Text);
            trat1.PrecioServicio = double.Parse(txtPrecio.Text);

            if (rbtnCorporal.Checked == true)
                trat1.TipoTrat = 0;
            else
                trat1.TipoTrat = 1;

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

            tratamientoBL.modificarTratamiento(trat1);
            this.DialogResult = DialogResult.OK;


        }
    }
}
