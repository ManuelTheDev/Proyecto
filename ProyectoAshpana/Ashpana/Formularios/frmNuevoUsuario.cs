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
    }
}
