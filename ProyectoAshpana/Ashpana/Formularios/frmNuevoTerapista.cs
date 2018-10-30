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

            //AGREGAR HORA
            //DateTime horaE = Convert.ToDateTime(txtHoraEntrada);
            //DateTime horaS = Convert.ToDateTime(txtHoraSalida);
    
            TerapistaBL terapistaBL = new TerapistaBL();
            terapistaBL.registrarTerapista(t);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha registrado correctamente al terapista", "RegistroTerapista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
