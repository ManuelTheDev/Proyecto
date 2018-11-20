using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Modelo;

namespace Formularios
{
    public partial class frmGestionFichaMedidas : Form
    {
       
        public frmGestionFichaMedidas() { }
        private Cliente cliente;
        public FichaMedida FichaMedida { get; private set; }
        private FichaMedidaBL fichaMedidaBL;

        private BindingList<FichaMedida> fichas;

        private void CargarDGV()
        {
            fichaMedidaBL = new FichaMedidaBL();
            columnasCitas.AutoGenerateColumns = false;
            fichas = fichaMedidaBL.listarFichaMedidas(cliente);
            columnasCitas.DataSource = fichas;
        }

        public frmGestionFichaMedidas(Cliente c)
        {
            InitializeComponent();
            cliente = new Cliente();
            cliente.ApMaterno = c.ApMaterno;
            cliente.ApPaterno = c.ApPaterno;
            cliente.CondicionesMedicas = c.CondicionesMedicas;
            cliente.Correo = c.Correo;
            cliente.Direccion = c.Direccion;
            cliente.Dni = c.Dni;
            cliente.Estado = c.Estado;
            cliente.FechaNac = c.FechaNac;
            cliente.IdCliente = c.IdCliente;
            cliente.IdPersona = c.IdPersona;
            cliente.Nombres = c.Nombres;
            cliente.Sexo = c.Sexo;
            cliente.Telefono = c.Telefono;
            lblNombreCli.Text = cliente.Nombres + " " + cliente.ApPaterno + " " + cliente.ApMaterno;
            CargarDGV();

        }

        private void columnasCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaFicha_Click(object sender, EventArgs e)
        {
            frmNuevaFichaMedida frmFicha = new frmNuevaFichaMedida(cliente);
            frmFicha.ShowDialog();
            if (frmFicha.DialogResult == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FichaMedida = (FichaMedida)columnasCitas.CurrentRow.DataBoundItem;
            frmModificarFichaMedidas fmfm = new frmModificarFichaMedidas(FichaMedida, cliente);
            fmfm.ShowDialog();
            if(fmfm.DialogResult == DialogResult.OK)
            {
                CargarDGV();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
