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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmGestionPacientes : Form
    {

        private Cliente clienteSeleccionado;
        private ClienteBL clienteBL;
        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        private BindingList<Cliente> clientes;

        public frmGestionPacientes()
        {
            InitializeComponent();
            CargarDGV();
        }

        private void CargarDGV()
        {
            clienteBL = new ClienteBL();
            dgvClientes.AutoGenerateColumns = false;
            clientes = clienteBL.listarClientes();
            dgvClientes.DataSource = clientes;
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
                CargarDGV();
            }

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmNuevoCliente frmCliente = new frmNuevoCliente();
            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVerFichaMedidas_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            frmGestionFichaMedidas frmfichaMedidas = new frmGestionFichaMedidas(clienteSeleccionado);
            frmfichaMedidas.ShowDialog();
            if (frmfichaMedidas.DialogResult == DialogResult.OK)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clienteBL.BuscarCliente(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            var clientesBuscados = new BindingList<Cliente>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            //"[nN][iI][cC][oO][lL][aA][sS]"
            Regex rgx = new Regex(@"" + patron + @"");
            foreach (Cliente c in clientes)
            {
                if (rgx.IsMatch(c.Nombres) || rgx.IsMatch(c.ApMaterno) || rgx.IsMatch(c.ApPaterno) || c.Dni==busqueda)
                {
                    clientesBuscados.Add(c);
                }

            }

            dgvClientes.DataSource = clientesBuscados;
        }

        private void btnVerCondicionMed_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            frmVerCondicionesMedicas_X_Paciente frmConMed = new frmVerCondicionesMedicas_X_Paciente(clienteSeleccionado.IdCliente);
            frmConMed.ShowDialog();
            if (frmConMed.DialogResult == DialogResult.OK)
            {

            }
        }

        private void btnVerServicios_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            var frmConMed = new frmVerHistorialServicios_X_Paciente(clienteSeleccionado.IdCliente);
            frmConMed.ShowDialog();
            if (frmConMed.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
