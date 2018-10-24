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
    public partial class frmListarPaquete : Form
    {
        private Paquete paquete;
        private PaqueteBL paqueteBL;

        public Paquete Paquete { get => paquete; set => paquete = value; }

        public frmListarPaquete()
        {
            InitializeComponent();
            dgvPaquetes.AutoGenerateColumns = false;
            paqueteBL = new PaqueteBL();
            dgvPaquetes.DataSource = paqueteBL.listarPaquetes();
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

            this.Close();
        }
    }
}
