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
                if (txtPeso.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del peso en kg", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fm.Peso = double.Parse(txtPeso.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente la medida del peso en kg", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (txtAbAlto.Text == "")
            {
                fm.AbdomenAlto = 0;

            }
            else
            {
                try
                {
                    if (txtAbAlto.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen alto en  cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.AbdomenAlto = double.Parse(txtAbAlto.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen alto en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }



            if (txtAbBajo.Text == "")
            {
                fm.AbdomenBajo = 0;

            }
            else
            {
                try
                {
                    if (txtAbBajo.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen bajo en  cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.AbdomenBajo = double.Parse(txtAbBajo.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen bajo en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }



            if (txtBrDer.Text == "")
            {
                fm.BrazoDerecho = 0;

            }
            else
            {
                try
                {
                    if (txtBrDer.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida del brazo derecho en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.BrazoDerecho = double.Parse(txtBrDer.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del brazo derecho en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }



            if (txtBrIzq.Text == "")
            {
                fm.BrazoIzquierdo = 0;

            }
            else
            {
                try
                {
                    if (txtBrIzq.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida del brazo izquierdo en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.BrazoIzquierdo = double.Parse(txtBrIzq.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del brazo izquierdo en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }



            if (txtCintura.Text == "")
            {
                fm.Cintura = 0;

            }
            else
            {
                try
                {
                    if (txtCintura.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida de la cintura en  cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.Cintura = double.Parse(txtCintura.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la cintura en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            if (txtEspalda.Text == "")
            {
                fm.Espalda = 0;

            }
            else
            {
                try
                {
                    if (txtEspalda.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida de la espalda en  cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.Espalda = double.Parse(txtEspalda.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la espalda en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtGluteos.Text == "")
            {
                fm.Gluteos = 0;

            }
            else
            {
                try
                {
                    if (txtGluteos.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida de los glúteos en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.Gluteos = double.Parse(txtGluteos.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de los glúteos en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtPierDer.Text == "")
            {
                fm.PiernaDer = 0;

            }
            else
            {
                try
                {
                    if (txtPierDer.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna derecha en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.PiernaDer = double.Parse(txtPierDer.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna derecha en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            if (txtIzq.Text == "")
            {
                fm.PiernaIzq = 0;

            }
            else
            {
                try
                {
                    if (txtIzq.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna izquierda en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fm.PiernaIzq = double.Parse(txtIzq.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna izquierda en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
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
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Se ha producido un error", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
