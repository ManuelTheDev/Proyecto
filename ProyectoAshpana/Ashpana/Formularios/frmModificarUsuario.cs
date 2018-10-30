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
    public partial class frmModificarUsuario : Form
    {
        private Superusuario superUsuarioMod;
        private UsuarioBL usuarioBL; 
        public frmModificarUsuario(Superusuario s)
        {
            InitializeComponent();
            txtNombres.Text = s.Nombres;
            txtApellidoPaterno.Text = s.ApPaterno;
            txtApellidoMaterno.Text = s.ApMaterno;
            txtCorreo.Text = s.Correo;
            txtDireccion.Text = s.Direccion;
            txtDni.Text = s.Dni;
            txtTelefono.Text = s.Telefono;
            dtpFechaNac.Value = s.FechaNac;
            txtContrasenia.Text = s.Contrasena;
            txtSueldo.Text = s.Sueldo.ToString();

            superUsuarioMod = new Superusuario();
            superUsuarioMod.IdPersona = s.IdPersona;
            superUsuarioMod.IdTrabajador = s.IdTrabajador;
            superUsuarioMod.IdSuperusuario = s.IdSuperusuario;

            if (s.Sexo == 'M')
            {
                rbMasculino.Checked = true; 
            }
            if (s.Sexo == 'F')
            {
                rbFemenino.Checked = true; 
            }
            

            if (s.Estado == 1)
            {
                cboEstado.Text = "Activo";
            }

            if (s.Estado == 0)
            {
                cboEstado.Text = "Inactivo";
            }
        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            superUsuarioMod.Dni = txtDni.Text;
            superUsuarioMod.Nombres = txtNombres.Text;
            superUsuarioMod.ApPaterno = txtApellidoPaterno.Text;
            superUsuarioMod.ApMaterno = txtApellidoMaterno.Text;
            superUsuarioMod.Contrasena = txtContrasenia.Text;
            superUsuarioMod.Correo = txtCorreo.Text;
            superUsuarioMod.Direccion = txtDireccion.Text;
            superUsuarioMod.Telefono = txtTelefono.Text;
            superUsuarioMod.FechaNac = dtpFechaNac.Value;
            if (rbFemenino.Checked == true)
            {
                superUsuarioMod.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                superUsuarioMod.Sexo = 'M';
            }
            superUsuarioMod.Sueldo = Double.Parse(txtSueldo.Text);

            if (cboEstado.Text.Equals("Activo"))
            {
                superUsuarioMod.Estado = 1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                superUsuarioMod.Estado = 0;
            }
            usuarioBL = new UsuarioBL();
            usuarioBL.modificarSuperusuario(superUsuarioMod);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el usuario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
