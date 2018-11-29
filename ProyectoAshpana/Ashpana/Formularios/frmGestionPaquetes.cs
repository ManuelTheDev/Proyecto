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

            CargarDGV();
            MessageBox.Show("Paquete eliminado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var paqBuscados = new BindingList<Paquete>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            Regex rgx = new Regex(@"^[\w\s]*" + patron + @"[\w\s]*$");
            foreach (Paquete p in paquetes)
            {
                if (rgx.IsMatch(p.Nombre))
                {
                    paqBuscados.Add(p);
                }

            }

            dgvPaquetes.DataSource = paqBuscados;
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
