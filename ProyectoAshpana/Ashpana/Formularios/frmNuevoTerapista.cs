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
using System.Text.RegularExpressions;

namespace Formularios
{
    public partial class frmNuevoTerapista : Form
    {
        private Terapista t1;
        private TratamientoBL tratamientoBL;
        public Terapista T1 { get => t1; set => t1 = value; }

        public frmNuevoTerapista()
        {
            InitializeComponent();
            T1 = new Terapista();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado satisfactoriamente el terapista", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Terapista t = new Terapista();
            t.Dni = txtDni.Text;
            t.Nombres = txtNombre.Text;
            t.ApPaterno = txtApPaterno.Text;
            t.ApMaterno = txtApMaterno.Text;
            if (rbMasculino.Checked == true)
                t.Sexo = 'M';
            else if (rbFemenino.Checked == true)
                t.Sexo = 'F';
            t.FechaNac = dtpFechaNac.Value;
            t.Correo = txtEmail.Text;
            t.Telefono = txtTelefono.Text;
            t.Direccion = txtDireccion.Text;
            if (cboTerapista.Text.Equals("Principal"))
            {
                t.Tipo = 1;
            }
            else if(cboTerapista.Text.Equals("Secundario"))
            {
                t.Tipo = 2;
            }
            t.Contrasena = txtContrasena.Text;
            t.Sueldo = Convert.ToDouble(txtSueldo.Text);

            String horaE = cboHoraEntrada.Text;
            String horaS = cboHoraSalida.Text;

            String minutoE = cboMinutoEntrada.Text;
            String minutoS = cboMinutoSalida.Text;


    
            TerapistaBL terapistaBL = new TerapistaBL();
            terapistaBL.registrarTerapista(t, horaE, horaS, minutoE, minutoS);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha registrado correctamente al terapista", "RegistroTerapista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{8}$");
            if (!rgx.IsMatch(txtDni.Text)) txtDni.ForeColor = Color.Red;
            else txtDni.ForeColor = Color.Black;
        }

        private void txtApPaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtApPaterno.Text)) txtApPaterno.ForeColor = Color.Red;
            else txtApPaterno.ForeColor = Color.Black;
        }

        private void txtApMaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtApMaterno.Text)) txtApMaterno.ForeColor = Color.Red;
            else txtApMaterno.ForeColor = Color.Black;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'-]+$");
            if (!rgx.IsMatch(txtNombre.Text)) txtNombre.ForeColor = Color.Red;
            else txtNombre.ForeColor = Color.Black;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w]+)((\.(\w){2,3})+)$");
            if (!rgx.IsMatch(txtEmail.Text)) txtEmail.ForeColor = Color.Red;
            else txtEmail.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{9}$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtSueldo.Text)) txtSueldo.ForeColor = Color.Red;
            else txtSueldo.ForeColor = Color.Black;
        }

        private void frmNuevoTerapista_Load(object sender, EventArgs e)
        {

        }
    }
}
