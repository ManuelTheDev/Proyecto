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
    public partial class frmVerHistorialServicios_X_Paciente : Form
    {
        private ClienteBL clienteBL;
        private BindingList<Servicio> servicios;

        public frmVerHistorialServicios_X_Paciente(int idCliente)
        {
            InitializeComponent();
            clienteBL = new ClienteBL();
            dgvServicios.AutoGenerateColumns = false;
            servicios = clienteBL.listarServiciosXCliente(idCliente);
            dgvServicios.DataSource = servicios;

            //dgvCondMedTratamiento.AutoGenerateColumns = false;
            //dgvCondMedTratamiento.DataSource = condicionMedicaBL.listarCondicionesMedicas_X_Cliente(idCliente);
        }

        private void txtboxBuscarServicio_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarServicio.Text;
            var serviciosBuscados = new BindingList<Servicio>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            Regex rgx = new Regex(@"^[\w\s]*" + patron + @"[\w\s]*$");
            foreach (Servicio s in servicios)
            {
                if (rgx.IsMatch(s.NombreServicio))
                {
                    serviciosBuscados.Add(s);
                }

            }

            dgvServicios.DataSource = serviciosBuscados;
        }
    }
}
