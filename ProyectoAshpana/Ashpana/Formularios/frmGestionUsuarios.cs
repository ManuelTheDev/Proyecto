using LogicaNegocio;
using Modelo;
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
    public partial class frmGestionUsuarios : Form
    {
        private Superusuario superusuarioSeleccionado;
        private UsuarioBL usuarioBL;

        public Superusuario SuperusuarioSeleccionado { get => superusuarioSeleccionado; set => superusuarioSeleccionado = value; }

        public frmGestionUsuarios()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
            dgvUsuarios.AutoGenerateColumns = false; 
            dgvUsuarios.DataSource = usuarioBL.listarSuperusuarios();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario frmNuevoUs = new frmNuevoUsuario();
            frmNuevoUs.ShowDialog();
            if (frmNuevoUs.DialogResult == DialogResult.OK)
            {
                usuarioBL = new UsuarioBL();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = usuarioBL.listarSuperusuarios();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SuperusuarioSeleccionado = (Superusuario)dgvUsuarios.CurrentRow.DataBoundItem;
            frmModificarUsuario frmUsuario = new frmModificarUsuario(SuperusuarioSeleccionado);
            frmUsuario.ShowDialog();
            if(frmUsuario.DialogResult == DialogResult.OK)
            {
                usuarioBL = new UsuarioBL();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = usuarioBL.listarSuperusuarios();
            }
        }
    }
}
