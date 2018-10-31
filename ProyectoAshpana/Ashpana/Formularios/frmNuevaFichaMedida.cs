using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;

namespace Formularios
{
    public partial class frmNuevaFichaMedida : Form
    {

        public frmNuevaFichaMedida() { }
        private Cliente cliente;
        public frmNuevaFichaMedida(Cliente c)
        {
            InitializeComponent();
            cliente = new Cliente();
            cliente.ApMaterno = c.ApMaterno;
            cliente.ApPaterno = c.ApPaterno;
            cliente.CondicionesMedicas = c.CondicionesMedicas;
            cliente.Correo = c.Correo;
            cliente.Direccion = c.Direccion;
            cliente.Dni = c.Dni;
            cliente.Estado = c.Estado;
            cliente.FechaNac = c.FechaNac;
            cliente.IdCliente = c.IdCliente;
            cliente.IdPersona = c.IdPersona;
            cliente.Nombres = c.Nombres;
            cliente.Sexo = c.Sexo;
            cliente.Telefono = c.Telefono;
            lblTxtNombre.Text = c.Nombres + " " + c.ApPaterno + " " + c.ApMaterno;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FichaMedida fm = new FichaMedida();
            try
            {
                fm.AbdomenAlto = Convert.ToDouble(txtAbAlto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese la medida del abdomen alto", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                fm.AbdomenBajo = Convert.ToDouble(txtAbBajo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida del abdomen bajo", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                fm.BrazoDerecho = Convert.ToDouble(txtBrDer.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese la medida del brazo derecho", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                fm.BrazoIzquierdo = Convert.ToDouble(txtBrIzq.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida del brazo izquierdo", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                fm.Cintura = Convert.ToDouble(txtCintura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese la medida de la cintura", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                fm.Espalda = Convert.ToDouble(txtEspalda.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida de la espalda", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                fm.Gluteos = Convert.ToDouble(txtGluteos.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida de los gluteos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                fm.Peso = Convert.ToDouble(txtPeso.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida del peso", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                fm.PiernaDer = Convert.ToDouble(txtPierDer.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida de la pierna derecha",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                fm.PiernaIzq = Convert.ToDouble(txtIzq.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese la medida de la pierna izquierda",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (cboTipoSomatico.Text.Equals("ENDOMORFO")) fm.Tipo = "ENDOMORFO";
            else if (cboTipoSomatico.Text.Equals("ECTOMORFO")) fm.Tipo = "ECTOMORFO";
            else if (cboTipoSomatico.Text.Equals("MESOMORFO")) fm.Tipo = "MESOMORFO";
            fm.Fecha = dateTimePicker1.Value;

            ClienteBL clienteBL = new ClienteBL();
            int res = clienteBL.registrarFichaMedida_X_Cliente(fm, cliente);
            this.DialogResult = DialogResult.OK;
            if (res == 1)
                MessageBox.Show("Se ha registrado correctamente la ficha de medida",
                    "RegistroFichaMedida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Se ha producido un error", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmNuevaFichaMedida_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
