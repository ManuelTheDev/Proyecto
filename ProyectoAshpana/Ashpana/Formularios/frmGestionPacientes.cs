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
    public partial class frmGestionPacientes : Form
    {

        private Cliente clienteSeleccionado;
        private ClienteBL clienteBL;
        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        public frmGestionPacientes()
        {
            InitializeComponent();
            clienteBL = new ClienteBL();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clienteBL.listarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            frmModificarCliente frmCliente = new frmModificarCliente(ClienteSeleccionado);
            frmCliente.ShowDialog();
            if (frmCliente.DialogResult == DialogResult.OK)
            {
                clienteBL = new ClienteBL();
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = clienteBL.listarClientes();
            }

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmNuevoCliente frmCliente = new frmNuevoCliente();
            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                clienteBL = new ClienteBL();
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = clienteBL.listarClientes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVerFichaMedidas_Click(object sender, EventArgs e)
        {
            frmGestionFichaMedidas frmfichaMedidas = new frmGestionFichaMedidas();
            if (frmfichaMedidas.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
