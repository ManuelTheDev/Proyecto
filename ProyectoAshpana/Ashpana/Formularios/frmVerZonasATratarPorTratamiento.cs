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
    public partial class frmVerZonasATratarPorTratamiento : Form
    {
        private ZonaBL zonaBL;
        public frmVerZonasATratarPorTratamiento(int idTrat)
        {
            InitializeComponent();
            zonaBL = new ZonaBL();
            dgvVerZonasATratarTratamiento.AutoGenerateColumns = false;
            dgvVerZonasATratarTratamiento.DataSource = zonaBL.listarZonas_X_Tratamiento(idTrat);
        }
    }
}
