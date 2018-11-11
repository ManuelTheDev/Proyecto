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
    public partial class frmGestionPaquetes : Form
    {
        private Paquete paquete;
        private PaqueteBL paqueteBL;
        private BindingList<Paquete> paquetes;

        public Paquete Paquete { get => paquete; set => paquete = value; }


        public frmGestionPaquetes()
        {
            InitializeComponent();
            CargarDGV();
        }
        
        private void CargarDGV()
        {
            paqueteBL = new PaqueteBL();
            dgvPaquetes.AutoGenerateColumns = false;
            paquetes = paqueteBL.listarPaquetes();
            dgvPaquetes.DataSource = paquetes;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Paquete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paquete = new Paquete();
            paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;

            frmModificarPaquetes fb = new frmModificarPaquetes(paquete);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoPaquete fb = new frmNuevoPaquete();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPaquetes.DataSource = paqueteBL.BuscarPaquete(txtboxBuscarPaquetes.Text);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Paquete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            paquete = new Paquete();
            paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;

            paqueteBL.eliminar(paquete);

            MessageBox.Show("Paquete eliminado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDGV();
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var paqBuscados = new BindingList<Paquete>();

            foreach (Paquete p in paquetes)
            {
                //String patron = @"^(\w)+" + busqueda + @"(\w)+$";
                Regex rgx = new Regex(@"^[\w\s]*" + busqueda + @"[\w\s]*$");
                if (rgx.IsMatch(p.Nombre))
                {
                    paqBuscados.Add(p);
                }

            }

            dgvPaquetes.DataSource = paqBuscados;
        }
    }
}
