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
    public partial class frmGestionFichaMedidas : Form
    {
        public frmGestionFichaMedidas()
        {
            InitializeComponent();
        }

        private void columnasCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaFicha_Click(object sender, EventArgs e)
        {
            frmNuevaFichaMedida frmFicha = new frmNuevaFichaMedida();
            frmFicha.Show();
        }
    }
}
