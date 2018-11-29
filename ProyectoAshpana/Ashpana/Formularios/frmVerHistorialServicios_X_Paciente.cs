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
    public partial class frmVerHistorialServicios_X_Paciente : Form
    {
        private ClienteBL clienteBL;
        public frmVerHistorialServicios_X_Paciente(int idCliente)
        {
            InitializeComponent();
            clienteBL = new ClienteBL();
            dgvServicios.AutoGenerateColumns = false;
            dgvServicios.DataSource = clienteBL.listarServiciosXCliente(idCliente);

            //dgvCondMedTratamiento.AutoGenerateColumns = false;
            //dgvCondMedTratamiento.DataSource = condicionMedicaBL.listarCondicionesMedicas_X_Cliente(idCliente);
        }
        
    }
}
