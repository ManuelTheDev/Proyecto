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
    public partial class frmGestionCitas : Form
    {
        private CitaBL citaBL;
        private BindingList<Cita> citas;

        public frmGestionCitas()
        {
            InitializeComponent();
            citaBL = new CitaBL();
            dgvCitas.AutoGenerateColumns = false;
            CargarDGV();
        }

        private void CargarDGV()
        {
            citas = citaBL.listarCitas();
            dgvCitas.DataSource = citas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmNuevaCita frmNuevaCita = new frmNuevaCita();
            frmNuevaCita.ShowDialog();
            dgvCitas.AutoGenerateColumns = false;
            CargarDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita();
            cita = (Cita)dgvCitas.CurrentRow.DataBoundItem;
            frmModificarCita fmc = new frmModificarCita(cita);
            fmc.ShowDialog();

            if (fmc.DialogResult == DialogResult.OK)
            {
                dgvCitas.AutoGenerateColumns = false;
                CargarDGV();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CITAS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionCitas_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            var sesionesBuscadas = new BindingList<Cita>();

            string patron = "";
            for (int i = 0; i < busqueda.Length; i++)
                if (('A' <= busqueda[i] && busqueda[i] <= 'Z') || ('a' <= busqueda[i] && busqueda[i] <= 'z')) patron += "[" + System.Char.ToLower(busqueda[i]) + System.Char.ToUpper(busqueda[i]) + "]";
                else patron += busqueda[i];

            Regex rgx = new Regex(@"" + patron + @"");
            foreach (Cita c in citas)
            {
                if (rgx.IsMatch(c.Cliente.Nombres)||rgx.IsMatch(c.Cliente.ApMaterno) || rgx.IsMatch(c.Cliente.ApPaterno))
                {
                    sesionesBuscadas.Add(c);
                }

            }

            dgvCitas.DataSource = sesionesBuscadas;
        }
    }
}
