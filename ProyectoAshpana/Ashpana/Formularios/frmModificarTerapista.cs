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
        private Terapista terapistaMod;
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

            terapistaMod = new Terapista();
            terapistaMod.IdPersona = t.IdPersona;
            terapistaMod.IdTerapista = t.IdTerapista;
            terapistaMod.IdTrabajador = t.IdTrabajador;
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

            terapistaMod.Dni = txtDni.Text;
            terapistaMod.Nombres = txtNombre.Text;
            terapistaMod.ApPaterno = txtApPaterno.Text;
            terapistaMod.ApMaterno = txtApMaterno.Text;
            terapistaMod.Contrasena = txtContrasena.Text;
            terapistaMod.Correo = txtCorreo.Text;
            terapistaMod.Direccion = txtDireccion.Text;
            terapistaMod.Telefono = txtTelefono.Text;
            terapistaMod.FechaNac = dtpFechaNac.Value;
           

            if (rbFemenino.Checked == true)
            {
                terapistaMod.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                terapistaMod.Sexo = 'M';
            }
            terapistaMod.Sueldo = Double.Parse(txtSueldo.Text);


            if (cboEstado.Text.Equals("Activo"))
            {
                terapistaMod.Estado=1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                terapistaMod.Estado = 0;
            }

            if (cboTerapista.Text.Equals("Principal"))
            {
                terapistaMod.Tipo = 0; 
            }

            if (cboTerapista.Text.Equals("Secundario"))
            {
                terapistaMod.Tipo = 1;
            }

            terapistaBL = new TerapistaBL();
            terapistaBL.modificarTerapista(terapistaMod);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el terapista", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
