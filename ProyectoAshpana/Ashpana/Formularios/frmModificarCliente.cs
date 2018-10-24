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
    public partial class frmModificarCliente : Form
    {
        private ClienteBL clienteBL;
        public frmModificarCliente(Cliente t)
        {
            InitializeComponent();
            txtNombre.Text = t.Nombres;
            txtApPaterno.Text = t.ApPaterno;
            txtApMaterno.Text = t.ApMaterno;
            txtDni.Text = t.Dni;
            txtCorreo.Text = t.Correo;
            txtDireccion.Text = t.Direccion;
            txtTelefono.Text = t.Telefono;
            dtpFechaNac.Value = t.FechaNac;
            if (t.Sexo == 'M')
            {
                rbMasculino.Checked = true;
            }
            if (t.Sexo == 'F')
            {
                rbFemenino.Checked = true;
            }

            if (t.Estado == 1)
            {
                cboEstado.Text = "Activo";
            }

            if (t.Estado == 0)
            {
                cboEstado.Text = "Inactivo";
            }

        }

        public frmModificarCliente(object sender, EventArgs e)
        {
           
           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.OK;
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente s = new Cliente();
            s.Dni = txtDni.Text;
            s.Nombres = txtNombre.Text;
            s.ApPaterno = txtApPaterno.Text;
            s.ApMaterno = txtApMaterno.Text;
            s.Correo = txtCorreo.Text;
            s.Direccion = txtDireccion.Text;
            s.Telefono = txtTelefono.Text;
            s.FechaNac = dtpFechaNac.Value;
            if (rbFemenino.Checked == true)
            {
                s.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                s.Sexo = 'M';
            }
           


            if (cboEstado.Text.Equals("Activo"))
            {
                s.Estado = 1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                s.Estado = 0;
            }


            clienteBL = new ClienteBL();
            clienteBL.modificarTerapista(s);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el cliente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
