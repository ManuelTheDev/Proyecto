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
    public partial class frmGestionTerapistas : Form
    {
        private Terapista terapistaSeleccionada;
        private TerapistaBL terapistaBL;
        private BindingList<Terapista> terapistas;

        public frmGestionTerapistas()
        {
            InitializeComponent();
            CargarDGV();
        }

        private void CargarDGV()
        {
            terapistaBL = new TerapistaBL();
            dgvTerapistas.AutoGenerateColumns = false;
            terapistas = terapistaBL.listarTerapistas();
            dgvTerapistas.DataSource = terapistas;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoTerapista_Click(object sender, EventArgs e)
        {
            frmNuevoTerapista frmTerapista = new frmNuevoTerapista();
            if (frmTerapista.ShowDialog() == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            terapistaSeleccionada = (Terapista)dgvTerapistas.CurrentRow.DataBoundItem;
            
            frmModificarTerapista frmTerapista = new frmModificarTerapista(terapistaSeleccionada);
            frmTerapista.ShowDialog();
            if (frmTerapista.DialogResult == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerTratamientosHabilitados_Click(object sender, EventArgs e)
        {
            terapistaSeleccionada = (Terapista)dgvTerapistas.CurrentRow.DataBoundItem;
            frmVerTratamientosPorTerapistas frmTratXTerapista = new frmVerTratamientosPorTerapistas(terapistaSeleccionada);
            frmTratXTerapista.ShowDialog(); 
            if (frmTratXTerapista.DialogResult== DialogResult.OK)
            {
               
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            var tratBuscados = new BindingList<Terapista>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            Regex rgx = new Regex(@"^[\w\s]*" + patron + @"[\w\s]*$");
            foreach (Terapista t in terapistas)
            {
                if (rgx.IsMatch(t.Nombres) || rgx.IsMatch(t.ApMaterno) || rgx.IsMatch(t.ApPaterno) || t.Dni == busqueda)
                {
                    tratBuscados.Add(t);
                }

            }

            dgvTerapistas.DataSource = tratBuscados;
        }
    }
}
