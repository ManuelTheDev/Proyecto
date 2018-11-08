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
using System.Text.RegularExpressions;

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



        private void txtEspalda_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtEspalda.Text)) txtEspalda.ForeColor = Color.Red;
            else txtEspalda.ForeColor = Color.Black;
        }

        private void txtPeso_TextChanged_1(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtPeso.Text)) txtPeso.ForeColor = Color.Red;
            else txtPeso.ForeColor = Color.Black;
        }

        private void txtAbAlto_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtAbAlto.Text)) txtAbAlto.ForeColor = Color.Red;
            else txtAbAlto.ForeColor = Color.Black;

        }

        private void txtAbBajo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtAbBajo.Text)) txtAbBajo.ForeColor = Color.Red;
            else txtAbBajo.ForeColor = Color.Black;
        }

        private void txtCintura_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtCintura.Text)) txtCintura.ForeColor = Color.Red;
            else txtCintura.ForeColor = Color.Black;

        }

        private void txtBrDer_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtBrDer.Text)) txtBrDer.ForeColor = Color.Red;
            else txtBrDer.ForeColor = Color.Black;
        }

        private void txtBrIzq_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtBrIzq.Text)) txtBrIzq.ForeColor = Color.Red;
            else txtBrIzq.ForeColor = Color.Black;
        }

        private void txtGluteos_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtGluteos.Text)) txtGluteos.ForeColor = Color.Red;
            else txtGluteos.ForeColor = Color.Black;
        }

        private void txtPierDer_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtPierDer.Text)) txtPierDer.ForeColor = Color.Red;
            else txtPierDer.ForeColor = Color.Black;
        }

        private void txtIzq_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!rgx.IsMatch(txtIzq.Text)) txtIzq.ForeColor = Color.Red;
            else txtIzq.ForeColor = Color.Black;
        }
    }
}
