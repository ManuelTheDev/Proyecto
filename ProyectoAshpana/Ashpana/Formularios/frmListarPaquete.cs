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
using System.Text.RegularExpressions;

namespace Formularios
{
    public partial class frmListarPaquete : Form
    {
        private Paquete paquete;
        private PaqueteBL paqueteBL;
        private BindingList<Paquete> paquetes;

        public Paquete Paquete { get => paquete; set => paquete = value; }

        public frmListarPaquete()
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paquete = (Paquete)dgvPaquetes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            
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
    }
}
