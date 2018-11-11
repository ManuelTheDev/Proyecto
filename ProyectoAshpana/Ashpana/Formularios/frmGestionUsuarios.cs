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
    public partial class frmGestionUsuarios : Form
    {
        private Superusuario superusuarioSeleccionado;
        private UsuarioBL usuarioBL;
        private BindingList<Superusuario> superusuarios;

        public Superusuario SuperusuarioSeleccionado { get => superusuarioSeleccionado; set => superusuarioSeleccionado = value; }

        public frmGestionUsuarios()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL();
            dgvUsuarios.AutoGenerateColumns = false;
            superusuarios = usuarioBL.listarSuperusuarios();
            dgvUsuarios.DataSource = superusuarios;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario frmNuevoUs = new frmNuevoUsuario();
            frmNuevoUs.ShowDialog();
            if (frmNuevoUs.DialogResult == DialogResult.OK)
            {
                usuarioBL = new UsuarioBL();
                dgvUsuarios.AutoGenerateColumns = false;
                superusuarios = usuarioBL.listarSuperusuarios();
                dgvUsuarios.DataSource = superusuarios;
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
                superusuarios = usuarioBL.listarSuperusuarios();
                dgvUsuarios.DataSource = superusuarios;
            }
        }

        private void txtboxBuscarPaquetes_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtboxBuscarPaquetes.Text;
            var suBuscados = new BindingList<Superusuario>();

            foreach (Superusuario su in superusuarios)
            {
                //String patron = @"^(\w)+" + busqueda + @"(\w)+$";
                Regex rgx = new Regex(@"^[\w\s]*"+busqueda + @"[\w\s]*$");
                if (rgx.IsMatch(su.Nombres) || rgx.IsMatch(su.ApMaterno) || rgx.IsMatch(su.ApPaterno)) {
                    suBuscados.Add(su);
                }
             
            }

            dgvUsuarios.DataSource = suBuscados;
        }
    }
}
