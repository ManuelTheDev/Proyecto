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
    public partial class frmCitasDelDia : Form
    {
        private SesionBL sesionBL;
        private BindingList<Sesion> sesiones;

        public frmCitasDelDia()
        {
            InitializeComponent();
            sesionBL = new SesionBL();
            dgvCitas.AutoGenerateColumns = false;
            CargarDGV();
        }

        private void CargarDGV()
        {
            sesiones = sesionBL.listarSesionesDelDia();
            dgvCitas.DataSource = sesiones;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            var sesionesBuscadas = new BindingList<Sesion>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];
            
            Regex rgx = new Regex(@"" + patron + @"");
            foreach (Sesion s in sesiones)
            {
                if (rgx.IsMatch(s.NomCliente))
                {
                    sesionesBuscadas.Add(s);
                }

            }

            dgvCitas.DataSource = sesionesBuscadas;
        }
    }
}
