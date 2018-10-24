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
    }
}
