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
    public partial class frmListarTerapistas : Form
    {
        private TerapistaBL terapistaBL;
        private Terapista terapista; 

        public frmListarTerapistas()
        {
            InitializeComponent();
            terapistaBL = new TerapistaBL();
            dgvTerapistas.AutoGenerateColumns = false;
            dgvTerapistas.DataSource = terapistaBL.listarTerapistas(); 
        }

        public Terapista Terapista { get => terapista; set => terapista = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Terapista = (Terapista)dgvTerapistas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK; 
        }
    }
}
