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
        public Cliente ClienteNuevo { get => clienteNuevo; set => clienteNuevo = value; }

        public frmNuevoCliente()
        {
            InitializeComponent();
            clienteNuevo = new Cliente();
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
           

            for(int i=0; i<clbCondicionesMedicas.CheckedIndices.Count; i++)
            {
                t.CondicionesMedicas.Add((CondicionMedica)clbCondicionesMedicas.CheckedItems[i]); 
            }

            ClienteBL clienteBL = new ClienteBL();
            clienteBL.registrarCliente(t);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Se ha registrado con exito.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{8}$");
            if (!rgx.IsMatch(txtDni.Text)) txtDni.ForeColor = Color.Red;
            else txtDni.ForeColor = Color.Black;
        }

        private void txtApPaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtApPaterno.Text)) txtApPaterno.ForeColor = Color.Red;
            else txtApPaterno.ForeColor = Color.Black;
        }

        private void txtApMaterno_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtApMaterno.Text)) txtApMaterno.ForeColor = Color.Red;
            else txtApMaterno.ForeColor = Color.Black;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[A-Z][\p{L}\s'.-]+$");
            if (!rgx.IsMatch(txtNombre.Text)) txtNombre.ForeColor = Color.Red;
            else txtNombre.ForeColor = Color.Black;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(\w+)\.?(\w+)\-?(\w+)@(\w+)\.\w+([-.])*$"); //@"^[0-9]+\.?[0-9]*$"
            if (!rgx.IsMatch(txtEmail.Text)) txtEmail.ForeColor = Color.Red;
            else txtEmail.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^\d{9}$");
            if (!rgx.IsMatch(txtTelefono.Text)) txtTelefono.ForeColor = Color.Red;
            else txtTelefono.ForeColor = Color.Black;

        }
    }
}
