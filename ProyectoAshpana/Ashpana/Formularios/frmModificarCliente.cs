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
    public partial class frmModificarCliente : Form
    {
        private ClienteBL clienteBL;
        private Cliente cliente;
        private Cliente clienteModificado;
        private CondicionMedicaBL condicionMedicaBL;
        private Tratamiento tratamientoSeleccionado;

        public frmModificarCliente(Cliente c)
        {
            InitializeComponent();
            cliente = new Cliente();
            clienteModificado = new Cliente();
            clienteBL = new ClienteBL();

            condicionMedicaBL = new CondicionMedicaBL();

            cliente.IdPersona = c.IdPersona;
            cliente.IdCliente = c.IdCliente;
            cliente.Nombres = c.Nombres;
            cliente.ApMaterno = c.ApMaterno;
            cliente.ApPaterno = c.ApPaterno;
            cliente.Sexo = c.Sexo;
            cliente.Direccion = c.Direccion;
            cliente.Correo = c.Correo;
            cliente.Dni = c.Dni;
            cliente.Estado = cliente.Estado;
            cliente.FechaNac = cliente.FechaNac;
            cliente.Telefono = cliente.Telefono;

            clienteModificado.IdPersona = c.IdPersona;
            clienteModificado.IdCliente = c.IdCliente;
            clienteModificado.Nombres = c.Nombres;
            clienteModificado.ApMaterno = c.ApMaterno;
            clienteModificado.ApPaterno = c.ApPaterno;
            clienteModificado.Sexo = c.Sexo;
            clienteModificado.Direccion = c.Direccion;
            clienteModificado.Correo = c.Correo;
            clienteModificado.Dni = c.Dni;
            clienteModificado.Estado = cliente.Estado;
            clienteModificado.FechaNac = cliente.FechaNac;
            clienteModificado.Telefono = cliente.Telefono;


            txtNombre.Text = c.Nombres;
            txtApPaterno.Text = c.ApPaterno;
            txtApMaterno.Text = c.ApMaterno;
            txtDni.Text = c.Dni;
            txtCorreo.Text = c.Correo;
            txtDireccion.Text = c.Direccion;
            txtTelefono.Text = c.Telefono;
            dtpFechaNac.Value = c.FechaNac;
            if (c.Sexo == 'M')
            {
                rbMasculino.Checked = true;
            }
            if (c.Sexo == 'F')
            {
                rbFemenino.Checked = true;
            }

            if (c.Estado == 0)
            {
                cboEstado.Text = "Inactivo"; 
            }
            if (c.Estado == 1)
            {
                cboEstado.Text = "Activo";
            }

            BindingList<CondicionMedica> condicionesMedicasGenerales = condicionMedicaBL.listarCondicionesMedicas();
            foreach (CondicionMedica cm in condicionesMedicasGenerales)
            {
                clbCondicionesMedicas.Items.Add(cm);
            }


            BindingList<CondicionMedica> condicionMedicasCliente = condicionMedicaBL.listarCondicionesMedicas_X_Cliente(c.IdCliente);

           

            foreach (CondicionMedica cm in condicionMedicasCliente)
            {
                int indice = clbCondicionesMedicas.Items.IndexOf(cm);
                clbCondicionesMedicas.SetItemChecked(indice, true);
            }

            for (int i = 0; i < clbCondicionesMedicas.CheckedIndices.Count; i++)
            {
                cliente.CondicionesMedicas.Add((CondicionMedica)clbCondicionesMedicas.CheckedItems[i]);
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

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            clienteModificado.Dni = txtDni.Text;
            clienteModificado.Nombres = txtNombre.Text;
            clienteModificado.ApPaterno = txtApPaterno.Text;
            clienteModificado.ApMaterno = txtApMaterno.Text;
            clienteModificado.Correo = txtCorreo.Text;
            clienteModificado.Direccion = txtDireccion.Text;
            clienteModificado.Telefono = txtTelefono.Text;
            clienteModificado.FechaNac = dtpFechaNac.Value;
            if (rbFemenino.Checked == true)
            {
                clienteModificado.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                clienteModificado.Sexo = 'M';
            }

            if (cboEstado.Text.Equals("Activo"))
            {
                clienteModificado.Estado = 1;
            }

            if (cboEstado.Text.Equals("Inactivo"))
            {
                clienteModificado.Estado = 0;
            }

            for (int i = 0; i < clbCondicionesMedicas.CheckedIndices.Count; i++)
            {
                clienteModificado.CondicionesMedicas.Add((CondicionMedica)clbCondicionesMedicas.CheckedItems[i]);
            }

            if (clienteBL.modificarTerapista(cliente, clienteModificado) == 1)
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Se ha modificado satisfactoriamente el cliente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("No se ha podido modificar satisfactoriamente el cliente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            //@"^(\w+)\.?(\w*)\-?(\w*)@(\w+)\.\w+([-.])*$"
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w]+)((\.(\w){2,3})+)$"); //@"^[0-9]+\.?[0-9]*$"
            if (!rgx.IsMatch(txtCorreo.Text)) txtCorreo.ForeColor = Color.Red;
            else txtCorreo.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{9}$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;
        }
    }
}
