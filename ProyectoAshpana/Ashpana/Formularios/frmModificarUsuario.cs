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
            Superusuario s = new Superusuario();
            s.Dni = txtDni.Text;
            s.Nombres = txtNombres.Text;
            s.ApPaterno = txtApellidoPaterno.Text;
            s.ApMaterno = txtApellidoMaterno.Text;
            s.Contrasena = txtContrasenia.Text;
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

            usuarioBL = new UsuarioBL();
            usuarioBL.modificarSuperusuario(s);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el usuario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
