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
    public partial class frmListarPacientes : Form
    {
        private ClienteBL clienteBL;
        private Cliente cliente; 
        public frmListarPacientes()
        {
            InitializeComponent();
            clienteBL = new ClienteBL();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clienteBL.listarClientes();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
