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
        private TerapistaBL terapistaBL;
        public Terapista T1 { get => t1; set => t1 = value; }

        public frmNuevoTerapista()
        {
            InitializeComponent();
            T1 = new Terapista();
            terapistaBL = new TerapistaBL();
           
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

            BindingList<Terapista> terapistas = new BindingList<Terapista>();
            terapistas = terapistaBL.listarTerapistaVerificaciones();
            foreach (Terapista c in terapistas)
            {
                if (c.Dni == txtDni.Text)
                {
                    MessageBox.Show("El DNI ingresado ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (DateTime.Now.Year - dtpFechaNac.Value.Year < 15)
            {
                MessageBox.Show("El terapista debe ser mayor de 15 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Now.Year - dtpFechaNac.Value.Year > 110)
            {
                MessageBox.Show("El terapista no puede ser mayor de 110 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            t.FechaNac = dtpFechaNac.Value;

            if ((txtDni.Text.Trim() == "") || (txtDni.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Dni = txtDni.Text.Trim();

            if ((txtNombre.Text.Trim() == "") || (txtNombre.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Nombres = txtNombre.Text.Trim();

            if ((txtApPaterno.Text.Trim() == "") || (txtApPaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.ApPaterno = txtApPaterno.Text.Trim();

            if ((txtApMaterno.Text.Trim() == "") || (txtApMaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Materno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.ApMaterno = txtApMaterno.Text.Trim();

            if (rbMasculino.Checked == true)
                t.Sexo = 'M';
            else if (rbFemenino.Checked == true)
                t.Sexo = 'F';

            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un género", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //falta validación de fecha de nacimiento
            t.FechaNac = dtpFechaNac.Value;

            if ((txtEmail.Text.Trim() == "") || (txtEmail.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el correo electrónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Correo = txtEmail.Text.Trim();

            if ((txtTelefono.Text.Trim() == "") || (txtTelefono.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el número telefónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Telefono = txtTelefono.Text.Trim();

            if ((txtDireccion.Text.Trim() == "") || (txtDireccion.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente la Dirección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Direccion = txtDireccion.Text.Trim();

            if (cboTerapista.Text.Equals("Principal"))
            {
                t.Tipo = 1;
            }
            else if(cboTerapista.Text.Equals("Secundario"))
            {
                t.Tipo = 2;
            }
            if (cboTerapista.Text == "")
            {
                MessageBox.Show("Por favor, elija un tipo de terapista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtContrasena.Text.Trim() == "") || (txtContrasena.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            t.Contrasena = txtContrasena.Text.Trim();

            try
            {
                if (txtSueldo.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente el sueldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                t.Sueldo = double.Parse(txtSueldo.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el sueldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            
            //falta validar para hora de entrada y salida
            String horaE = cboHoraEntrada.Text;
            String horaS = cboHoraSalida.Text;

            String minutoE = cboMinutoEntrada.Text;
            String minutoS = cboMinutoSalida.Text;

            if (cboHoraEntrada.Text == "" || cboMinutoEntrada.Text=="" || cboHoraSalida.Text=="" || cboMinutoSalida.Text == "")
            {
                MessageBox.Show("Por favor, ingrese correctamente las horas de entrada y salida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
    
            
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
            Regex rgx = new Regex(@"^(\d{7}|9\d{8})$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtSueldo.Text)) txtSueldo.ForeColor = Color.Red;
            else txtSueldo.ForeColor = Color.Black;
        }

        private void frmNuevoTerapista_Load(object sender, EventArgs e)
        {

        }
    }
}
