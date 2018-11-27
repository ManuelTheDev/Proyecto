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
            terapistaMod.Logueado = t.Logueado;

            
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

            terapistaMod.FechaNac = dtpFechaNac.Value;

            if ((txtDni.Text.Trim() == "") || (txtDni.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.Dni = txtDni.Text.Trim();

            if ((txtNombre.Text.Trim() == "") || (txtNombre.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese un Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.Nombres = txtNombre.Text.Trim();

            if ((txtApPaterno.Text.Trim() == "") || (txtApPaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.ApPaterno = txtApPaterno.Text.Trim();

            if ((txtApMaterno.Text.Trim() == "") || (txtApMaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Materno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.ApMaterno = txtApMaterno.Text.Trim();

            if ((txtContrasena.Text.Trim() == "") || (txtContrasena.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese una contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            terapistaMod.Contrasena = txtContrasena.Text.Trim();

            if ((txtCorreo.Text.Trim() == "") || (txtCorreo.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el correo electrónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.Correo = txtCorreo.Text.Trim();

            if ((txtDireccion.Text.Trim() == "") || (txtDireccion.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente la Dirección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.Direccion = txtDireccion.Text.Trim();

            if ((txtTelefono.Text.Trim() == "") || (txtTelefono.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el número telefónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            terapistaMod.Telefono = txtTelefono.Text.Trim();

            terapistaMod.FechaNac = dtpFechaNac.Value;
           

            if (rbFemenino.Checked == true)
            {
                terapistaMod.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                terapistaMod.Sexo = 'M';
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
                terapistaMod.Sueldo = double.Parse(txtSueldo.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente el sueldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (cboEstado.Text.Equals("Activo"))
            {
                terapistaMod.Estado=1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                if (terapistaMod.Logueado == 1)
                {
                    MessageBox.Show("No puede elimarse, pues el trabajador está logueado ", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                terapistaMod.Estado = 0;
            }else

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
            MessageBox.Show("Se ha modifcado satisfactoriamente el terapista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtHoraEntrada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
