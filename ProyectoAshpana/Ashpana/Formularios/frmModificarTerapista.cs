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
    public partial class frmModificarTerapista : Form
    {
        private TerapistaBL terapistaBL;
        public frmModificarTerapista(Terapista t)
        {
            InitializeComponent();
            txtNombre.Text = t.Nombres;
            txtApPaterno.Text = t.ApPaterno;
            txtApMaterno.Text = t.ApMaterno;
            txtDni.Text = t.Dni;
            txtCorreo.Text = t.Correo;
            txtDireccion.Text = t.Direccion;
            txtTelefono.Text = t.Telefono;
            txtContrasena.Text = t.Contrasena;
            dtpFechaNac.Value = t.FechaNac;
            txtSueldo.Text = t.Sueldo.ToString(); 
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


            if (t.Tipo == 0)
            {
                cboTerapista.Text = "Principal";
            }

            if (t.Tipo == 1)
            {
                cboTerapista.Text = "Secundario";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            Terapista s = new Terapista();
            s.Dni = txtDni.Text;
            s.Nombres = txtNombre.Text;
            s.ApPaterno = txtApPaterno.Text;
            s.ApMaterno = txtApMaterno.Text;
            s.Contrasena = txtContrasena.Text;
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
            s.Sueldo = Double.Parse(txtSueldo.Text);


            if (cboEstado.Text.Equals("Activo"))
            {
                s.Estado=1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                s.Estado = 0;
            }

            if (cboTerapista.Text.Equals("Principal"))
            {
                s.Tipo = 0; 
            }

            if (cboTerapista.Text.Equals("Secundario"))
            {
                s.Tipo = 1;
            }

            terapistaBL = new TerapistaBL();
            terapistaBL.modificarTerapista(s);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el terapista", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
