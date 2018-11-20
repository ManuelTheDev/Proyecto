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
    public partial class frmVerCondicionesMedicas_X_Paciente : Form
    {
        private CondicionMedicaBL condicionMedicaBL;
        public frmVerCondicionesMedicas_X_Paciente(int idCliente)
        {
            
            InitializeComponent();
            condicionMedicaBL = new CondicionMedicaBL();
            dgvCondMedTratamiento.AutoGenerateColumns = false;
            dgvCondMedTratamiento.DataSource = condicionMedicaBL.listarCondicionesMedicas_X_Cliente(idCliente);
        }
    }
}
