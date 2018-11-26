using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmNuevoCliente : Form
    {
        private Cliente clienteNuevo;
        private CondicionMedicaBL condicionMedicaBL;
        private ClienteBL clienteBL;
        public Cliente ClienteNuevo { get => clienteNuevo; set => clienteNuevo = value; }

        public frmNuevoCliente()
        {
            InitializeComponent();
            clienteNuevo = new Cliente();
            clienteBL = new ClienteBL();
            condicionMedicaBL = new CondicionMedicaBL(); 
            BindingList<CondicionMedica> condicionesMedicas = condicionMedicaBL.listarCondicionesMedicas(); 

            foreach(CondicionMedica cm in condicionesMedicas)
            {
                clbCondicionesMedicas.Items.Add(cm);
            }

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {

        }



        private void lblNuevoCliente_Click(object sender, EventArgs e)
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmGestionPacientes fc = new frmGestionPacientes();
            fc.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente t = new Cliente();

            BindingList<Cliente> clientes = new BindingList<Cliente>();
            clientes = clienteBL.listarClientesVerificaciones();
            foreach(Cliente c in clientes)
            {
                if (c.Dni == txtDni.Text)
                {
                    MessageBox.Show("El DNI ingresado ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (DateTime.Now.Year - dtpFechaNac.Value.Year < 15)
            {
                MessageBox.Show("El cliente debe ser mayor de 15 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Now.Year - dtpFechaNac.Value.Year > 110)
            {
                MessageBox.Show("El cliente no puede ser mayor de 110 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Por favor, ingrese correctamente el Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            //falta validar
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
            t.Direccion = txtDireccion.Text;
           

            for(int i=0; i<clbCondicionesMedicas.CheckedIndices.Count; i++)
            {
                t.CondicionesMedicas.Add((CondicionMedica)clbCondicionesMedicas.CheckedItems[i]); 
            }

            //ClienteBL clienteBL = new ClienteBL();
            clienteBL.registrarCliente(t);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha registrado con exito.",
                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w]+)((\.(\w){2,3})+)$"); //@"^[0-9]+\.?[0-9]*$"
            if (!rgx.IsMatch(txtEmail.Text)) txtEmail.ForeColor = Color.Red;
            else txtEmail.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(\d{7}|9\d{8})$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;

        }
    }
}
