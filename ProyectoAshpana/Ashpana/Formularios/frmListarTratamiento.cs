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
    public partial class frmListarTratamiento : Form
    {
        private Tratamiento tratamiento;
        private TratamientoBL tratamientoBL;
        private BindingList<Tratamiento> tratamientos;

        public Tratamiento Tratamiento { get => tratamiento; set => tratamiento = value; }

        public frmListarTratamiento()
        {
            InitializeComponent();
            dgvTratamientos.AutoGenerateColumns = false;
            tratamientoBL = new TratamientoBL();
            tratamientos = tratamientoBL.listarTratamientos();
            dgvTratamientos.DataSource = tratamientos;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Tratamiento = (Tratamiento)dgvTratamientos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var tratBuscados = new BindingList<Tratamiento>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            Regex rgx = new Regex(@"" + patron + @"");
            foreach (Tratamiento t in tratamientos)
            {
                if (rgx.IsMatch(t.Nombre))
                {
                    tratBuscados.Add(t);
                }

            }

            dgvTratamientos.DataSource = tratBuscados;
        }
    }
}
