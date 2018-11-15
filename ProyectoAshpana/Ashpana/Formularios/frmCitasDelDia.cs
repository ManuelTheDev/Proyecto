using LogicaNegocio;
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
    public partial class frmCitasDelDia : Form
    {
        private SesionBL sesionBL;
        public frmCitasDelDia()
        {
            InitializeComponent();
            sesionBL = new SesionBL();
            dgvCitas.AutoGenerateColumns = false;
            dgvCitas.DataSource = sesionBL.listarSesionesDelDia();
        }
    }
}
