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

            if (DateTime.Now.Year-dtpFechaNac.Value.Year<15)
            {
                MessageBox.Show("El cliente debe ser mayor de 15 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Now.Year - dtpFechaNac.Value.Year > 110)
            {
                MessageBox.Show("El cliente no puede ser mayor de 110 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtDni.Text.Trim() == "") || (txtDni.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            clienteModificado.Dni = txtDni.Text.Trim();

            if ((txtNombre.Text.Trim() == "") || (txtNombre.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.Nombres = txtNombre.Text.Trim();

            if ((txtApPaterno.Text.Trim() == "") || (txtApPaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Paterno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.ApPaterno = txtApPaterno.Text.Trim();

            if ((txtApMaterno.Text.Trim() == "") || (txtApMaterno.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el Apellido Materno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.ApMaterno = txtApMaterno.Text.Trim();

            if ((txtCorreo.Text.Trim() == "") || (txtCorreo.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el correo electrónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.Correo = txtCorreo.Text.Trim();

            if ((txtDireccion.Text.Trim() == "") || (txtDireccion.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente la Dirección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.Direccion = txtDireccion.Text.Trim();

            if ((txtTelefono.Text.Trim() == "") || (txtTelefono.ForeColor == Color.Red))
            {
                MessageBox.Show("Por favor, ingrese correctamente el número telefónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clienteModificado.Telefono = txtTelefono.Text.Trim();


            clienteModificado.FechaNac = dtpFechaNac.Value;

            if (rbFemenino.Checked == true)
            {
                clienteModificado.Sexo = 'F';
            }
            if (rbMasculino.Checked == true)
            {
                clienteModificado.Sexo = 'M';
            }

            if(rbFemenino.Checked==false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Por favor, seleccione un género", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
                MessageBox.Show("Se ha modificado satisfactoriamente el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("No se ha podido modificar satisfactoriamente el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Regex rgx = new Regex(@"^(\d{7}|9\d{8})$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;
        }
    }
}
