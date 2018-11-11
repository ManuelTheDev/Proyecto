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

            DateTime horaEntrada = t.HoraEntrada;
            DateTime horaSalida = t.HoraSalida;

            String hEntrada = horaEntrada.Hour.ToString();
            String hSalida = horaSalida.Hour.ToString();

            String mEntrada = horaEntrada.Minute.ToString();
            String mSalida = horaSalida.Minute.ToString();

           

            if (Int32.Parse(hEntrada) < 10)
            {
                hEntrada = "0"+ hEntrada;
            } 

            if (Int32.Parse(mEntrada) < 10)
            {
                mEntrada = "0" + mEntrada; 
            }

            if (Int32.Parse(hSalida) < 10)
            {
                hSalida = "0" + hSalida;
            }

            if (Int32.Parse(mSalida) < 10)
            {
                mSalida = "0" + mSalida;
            }

           cboHoraEntrada.Text = hEntrada;
           cboHoraSalida.Text = hSalida;

           cboMinutoEntrada.Text = mEntrada;
           cboMinutoSalida.Text = mSalida;

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

            String horaE = cboHoraEntrada.Text;
            String horaS = cboHoraSalida.Text;

            String minutoE = cboMinutoEntrada.Text;
            String minutoS = cboMinutoSalida.Text;

            terapistaBL.modificarTerapista(terapistaMod, horaE, horaS, minutoE, minutoS);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el terapista", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w]+)((\.(\w){2,3})+)$");
            if (!rgx.IsMatch(txtCorreo.Text)) txtCorreo.ForeColor = Color.Red;
            else txtCorreo.ForeColor = Color.Black;
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

        private void txtHoraEntrada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
