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
    public partial class frmNuevoUsuario : Form
    {
        private UsuarioBL usuarioBL; 

        public frmNuevoUsuario()
        {
            InitializeComponent();
            usuarioBL = new UsuarioBL(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
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
            s.FechaNac = dtpFecha_Nac.Value; 
            if (rbFemenino.Checked==true)
            {
                s.Sexo = 'F'; 
            }
            if (rbMasculino.Checked==true)
            {
                s.Sexo = 'M'; 
            }
            s.Sueldo = Double.Parse(txtSueldo.Text);

            usuarioBL = new UsuarioBL();
            usuarioBL.registrarSuperusuario(s);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha creado satisfactoriamente el usuario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtNombres.Text)) txtNombres.ForeColor = Color.Red;
            else txtNombres.ForeColor = Color.Black;
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtApellidoPaterno.Text)) txtApellidoPaterno.ForeColor = Color.Red;
            else txtApellidoPaterno.ForeColor = Color.Black;
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtApellidoMaterno.Text)) txtApellidoMaterno.ForeColor = Color.Red;
            else txtApellidoMaterno.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{9}$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{8}$");
            if (!rgx.IsMatch(txtDni.Text)) txtDni.ForeColor = Color.Red;
            else txtDni.ForeColor = Color.Black;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(\w+)\.?(\w+)\-?(\w+)@(\w+)\.\w+([-.])*$");
            if (!rgx.IsMatch(txtCorreo.Text)) txtCorreo.ForeColor = Color.Red;
            else txtCorreo.ForeColor = Color.Black;
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtSueldo.Text)) txtSueldo.ForeColor = Color.Red;
            else txtSueldo.ForeColor = Color.Black;
        }
    }
}
