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
    public partial class frmListarTratamiento : Form
    {
        private Tratamiento tratamiento;
        private TratamientoBL tratamientoBL;

        public Tratamiento Tratamiento { get => tratamiento; set => tratamiento = value; }

        public frmListarTratamiento()
        {
            InitializeComponent();
            dgvTratamientos.AutoGenerateColumns = false;
            tratamientoBL = new TratamientoBL();
            dgvTratamientos.DataSource = tratamientoBL.listarTratamientos();
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
    }
}
