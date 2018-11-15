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
    public partial class frmListarPacientes : Form
    {
        private ClienteBL clienteBL;
        private Cliente cliente;

        private BindingList<Cliente> clientes;

        public frmListarPacientes()
        {
            InitializeComponent();
            clienteBL = new ClienteBL();
            dgvClientes.AutoGenerateColumns = false;
            clientes = clienteBL.listarClientes();
            dgvClientes.DataSource = clientes;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var clientesBuscados = new BindingList<Cliente>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            //"[nN][iI][cC][oO][lL][aA][sS]"
            Regex rgx = new Regex(@"" + patron + @"");
            foreach (Cliente c in clientes)
            {
                if (rgx.IsMatch(c.Nombres) || rgx.IsMatch(c.ApMaterno) || rgx.IsMatch(c.ApPaterno) || c.Dni == busqueda)
                {
                    clientesBuscados.Add(c);
                }

            }

            dgvClientes.DataSource = clientesBuscados;
        }
    }
}
