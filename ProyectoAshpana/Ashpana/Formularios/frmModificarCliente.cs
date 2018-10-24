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
    public partial class frmModificarCliente : Form
    {
        private ClienteBL clienteBL;
        private CondicionMedicaBL condicionMedicaBL; 
        public frmModificarCliente(Cliente t)
        {
            InitializeComponent();
            condicionMedicaBL = new CondicionMedicaBL();
            txtNombre.Text = t.Nombres;
            txtApPaterno.Text = t.ApPaterno;
            txtApMaterno.Text = t.ApMaterno;
            txtDni.Text = t.Dni;
            txtCorreo.Text = t.Correo;
            txtDireccion.Text = t.Direccion;
            txtTelefono.Text = t.Telefono;
            dtpFechaNac.Value = t.FechaNac;
            if (t.Sexo == 'M')
            {
                rbMasculino.Checked = true;
            }
            if (t.Sexo == 'F')
            {
                rbFemenino.Checked = true;
            }

            if (t.Estado == 0)
            {
                cboEstado.Text = "Inactivo"; 
            }
            if (t.Estado == 1)
            {
                cboEstado.Text = "Activo";
            }

            BindingList<CondicionMedica> condicionesMedicasGenerales = condicionMedicaBL.listarCondicionesMedicas();
            foreach (CondicionMedica cm in condicionesMedicasGenerales)
            {
                clbCondicionesMedicas.Items.Add(cm);
            }


            BindingList<CondicionMedica> condicionMedicasCliente = condicionMedicaBL.listarCondicionesMedicas_X_Cliente(t.IdCliente);
            
            


            foreach (CondicionMedica cm in condicionMedicasCliente)
            {
                int indice = clbCondicionesMedicas.Items.IndexOf(cm);
                clbCondicionesMedicas.SetItemChecked(indice, true);
            }
        }

        public frmModificarCliente(object sender, EventArgs e)
        {
           
           

        }

     

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente s = new Cliente();
            s.Dni = txtDni.Text;
            s.Nombres = txtNombre.Text;
            s.ApPaterno = txtApPaterno.Text;
            s.ApMaterno = txtApMaterno.Text;
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

            if (cboEstado.Equals("Activo"))
            {
                s.Estado = 0;
            }

            if (cboEstado.Equals("Inactivo"))
            {
                s.Estado = 1;
            }



            clienteBL = new ClienteBL();
            clienteBL.modificarTerapista(s);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha modifcado satisfactoriamente el cliente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
