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

            if ((txtDni.Text.Trim() == "") || (txtDni.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Dni = txtDni.Text.Trim();

            if ((txtNombres.Text.Trim() == "") || (txtNombres.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese lun Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Nombres = txtNombres.Text.Trim();

            if ((txtApellidoPaterno.Text.Trim() == "") || (txtApellidoPaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.ApPaterno = txtApellidoPaterno.Text.Trim();

            if ((txtApellidoMaterno.Text.Trim() == "") || (txtApellidoMaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Materno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.ApMaterno = txtApellidoMaterno.Text.Trim();

            if ((txtContrasenia.Text.Trim() == "") || (txtContrasenia.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Contrasena = txtContrasenia.Text.Trim();

            if ((txtCorreo.Text.Trim() == "") || (txtCorreo.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el correo electrónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Correo = txtCorreo.Text.Trim();

            if ((txtDireccion.Text.Trim() == "") || (txtDireccion.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente la Dirección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Direccion = txtDireccion.Text.Trim();

            if ((txtTelefono.Text.Trim() == "") || (txtTelefono.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el número telefónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            s.Telefono = txtTelefono.Text.Trim();
            
            //falta validar fecha nacimiento
            s.FechaNac = dtpFecha_Nac.Value; 

            if (rbFemenino.Checked==true)
            {
                s.Sexo = 'F'; 
            }
            if (rbMasculino.Checked==true)
            {
                s.Sexo = 'M'; 
            }

            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un género", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (txtSueldo.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el sueldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                s.Sueldo = double.Parse(txtSueldo.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el sueldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombres.Text)) txtNombres.ForeColor = Color.Red;
            else txtNombres.ForeColor = Color.Black;
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtApellidoPaterno.Text)) txtApellidoPaterno.ForeColor = Color.Red;
            else txtApellidoPaterno.ForeColor = Color.Black;
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtApellidoMaterno.Text)) txtApellidoMaterno.ForeColor = Color.Red;
            else txtApellidoMaterno.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(\d{7}|\d{9})$");
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
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w]+)((\.(\w){2,3})+)$");
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
