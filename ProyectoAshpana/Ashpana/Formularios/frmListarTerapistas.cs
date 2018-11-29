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
    public partial class frmListarTerapistas : Form
    {
        private TerapistaBL terapistaBL;
        private Terapista terapista;
        private BindingList<Terapista> terapistas;

        public frmListarTerapistas(int idServicio, int numSesiones)
        {
            InitializeComponent();
            terapistaBL = new TerapistaBL();
            dgvTerapistas.AutoGenerateColumns = false;
            if (numSesiones == 1)
                dgvTerapistas.DataSource = terapistaBL.listarTerapistas_X_Tratamiento(idServicio);
            else
            {
                dgvTerapistas.DataSource = terapistaBL.listarTerapistas_X_Paquete(idServicio);
            }
               
           
        }

        public Terapista Terapista { get => terapista; set => terapista = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Terapista = (Terapista)dgvTerapistas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK; 
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
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
