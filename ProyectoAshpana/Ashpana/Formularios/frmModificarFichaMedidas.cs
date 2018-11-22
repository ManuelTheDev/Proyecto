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
    public partial class frmModificarFichaMedidas : Form
    {
        public frmModificarFichaMedidas() { }
        private Cliente cliente;
        private FichaMedida ficha2;
        public frmModificarFichaMedidas(FichaMedida fm, Cliente c)
        {
            InitializeComponent();
            cliente = new Cliente();
            ficha2 = new FichaMedida();
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
            //pasar todo de fm a ficha2
            ficha2.AbdomenAlto = fm.AbdomenAlto;
            ficha2.AbdomenBajo = fm.AbdomenBajo;
            ficha2.BrazoDerecho = fm.BrazoDerecho;
            ficha2.BrazoIzquierdo = fm.BrazoIzquierdo;
            ficha2.Cintura = fm.Cintura;
            ficha2.Espalda = fm.Espalda;
            ficha2.Fecha = fm.Fecha;
            ficha2.Gluteos = fm.Gluteos;
            ficha2.IdFichaMedida = fm.IdFichaMedida;
            ficha2.Peso = fm.Peso;
            ficha2.PiernaDer = fm.PiernaDer;
            ficha2.PiernaIzq = fm.PiernaIzq;
            ficha2.Tipo = fm.Tipo;
            ficha2.IdFichaMedida = fm.IdFichaMedida;
            
            lblTxtNombre.Text = c.Nombres + " " + c.ApPaterno + " " + c.ApMaterno;
            dateTimePicker1.Value = fm.Fecha;
            if(fm.Tipo == "ENDOMORFO")
            {
                cboTipoSomatico.Text = "ENDOMORFO";
            }
            if(fm.Tipo == "ECTOMORFO")
            {
                cboTipoSomatico.Text = "ECTOMORFO";
            }
            if(fm.Tipo == "MESOMORFO")
            {
                cboTipoSomatico.Text = "MESOMORFO";
            }

            txtPeso.Text = Convert.ToString(fm.Peso);
            txtEspalda.Text = Convert.ToString(fm.Espalda);
            txtAbAlto.Text = Convert.ToString(fm.AbdomenAlto);
            txtAbBajo.Text = Convert.ToString(fm.AbdomenBajo);
            txtCintura.Text = Convert.ToString(fm.Cintura);
            txtBrDer.Text = Convert.ToString(fm.BrazoDerecho);
            txtBrIzq.Text = Convert.ToString(fm.BrazoIzquierdo);
            txtGluteos.Text = Convert.ToString(fm.Gluteos);
            txtPierDer.Text = Convert.ToString(fm.PiernaDer);
            txtIzq.Text = Convert.ToString(fm.PiernaIzq);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FichaMedida fichamedida = new FichaMedida();
            fichamedida.IdFichaMedida = ficha2.IdFichaMedida;
            if (cboTipoSomatico.Text == "ENDOMORFO")
            {
                fichamedida.Tipo = "ENDOMORFO";
            }
            if (cboTipoSomatico.Text == "ECTOMORFO")
            {
                fichamedida.Tipo = "ECTOMORFO";
            }
            if (cboTipoSomatico.Text == "MESOMORFO")
            {
                fichamedida.Tipo = "MESOMORFO";
            }
            
            if (dateTimePicker1.Value.Year <= 1998)
            {
                MessageBox.Show("La fecha debe ser mayor a 1998", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DateTime.Now.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("La fecha no puede ser futura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            fichamedida.Fecha = dateTimePicker1.Value;

            try
            {
                if (txtPeso.ForeColor == Color.Red)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del peso en kg", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fichamedida.Peso = double.Parse(txtPeso.Text.Trim());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese correctamente la medida del peso en kg", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtEspalda.Text == "")
            {
                fichamedida.Espalda = 0;

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
                    fichamedida.Espalda = double.Parse(txtEspalda.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la espalda en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            

            if (txtAbAlto.Text == "")
            {
                fichamedida.AbdomenAlto = 0;

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
                    fichamedida.AbdomenAlto = double.Parse(txtAbAlto.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen alto en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtAbBajo.Text == "")
            {
                fichamedida.AbdomenBajo = 0;

            }
            else {
                try
                {
                    if (txtAbBajo.ForeColor == Color.Red)
                    {
                        MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen bajo en  cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    fichamedida.AbdomenBajo = double.Parse(txtAbBajo.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del abdomen bajo en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            if (txtCintura.Text == "")
            {
                fichamedida.Cintura = 0;

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
                    fichamedida.Cintura = double.Parse(txtCintura.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la cintura en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtBrDer.Text == "")
            {
                fichamedida.BrazoDerecho = 0;

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
                    fichamedida.BrazoDerecho = double.Parse(txtBrDer.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del brazo derecho en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtCintura.Text == "")
            {
                fichamedida.Cintura = 0;

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
                    fichamedida.Cintura = double.Parse(txtCintura.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la cintura en  en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtBrIzq.Text == "")
            {
                fichamedida.BrazoIzquierdo = 0;

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
                    fichamedida.BrazoIzquierdo = double.Parse(txtBrIzq.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida del brazo izquierdo en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtGluteos.Text == "")
            {
                fichamedida.Gluteos = 0;

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
                    fichamedida.Gluteos = double.Parse(txtGluteos.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de los glúteos en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            if (txtPierDer.Text == "")
            {
                fichamedida.PiernaDer = 0;

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
                    fichamedida.PiernaDer = double.Parse(txtPierDer.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna derecha en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtIzq.Text == "")
            {
                fichamedida.PiernaIzq = 0;

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
                    fichamedida.PiernaIzq = double.Parse(txtIzq.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese correctamente la medida de la pierna izquierda en cm", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            FichaMedidaBL fichaMedidaBL = new FichaMedidaBL();
            int res = fichaMedidaBL.modificarFichaMedida(fichamedida);
            if (res == 1)
                MessageBox.Show("Se modifico correctamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se modifico correctamente", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.OK;

            this.Dispose();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[1-9][0-9]*(\.[0-9]{1,2})?$");//anterior: @"^[0-9]+(\.[0-9]+)?$" 
            if (!rgx.IsMatch(txtPeso.Text)) txtPeso.ForeColor = Color.Red;
            else txtPeso.ForeColor = Color.Black;
        }

        private void txtEspalda_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtEspalda.Text)) txtEspalda.ForeColor = Color.Red;
            else txtEspalda.ForeColor = Color.Black;
        }

        private void txtAbAlto_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtAbAlto.Text)) txtAbAlto.ForeColor = Color.Red;
            else txtAbAlto.ForeColor = Color.Black;
        }

        private void txtAbBajo_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtAbBajo.Text)) txtAbBajo.ForeColor = Color.Red;
            else txtAbBajo.ForeColor = Color.Black;
        }

        private void txtCintura_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtCintura.Text)) txtCintura.ForeColor = Color.Red;
            else txtCintura.ForeColor = Color.Black;
        }

        private void txtBrDer_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtBrDer.Text)) txtBrDer.ForeColor = Color.Red;
            else txtBrDer.ForeColor = Color.Black;
        }

        private void txtBrIzq_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtBrIzq.Text)) txtBrIzq.ForeColor = Color.Red;
            else txtBrIzq.ForeColor = Color.Black;
        }

        private void txtGluteos_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtGluteos.Text)) txtGluteos.ForeColor = Color.Red;
            else txtGluteos.ForeColor = Color.Black;
        }

        private void txtPierDer_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtPierDer.Text)) txtPierDer.ForeColor = Color.Red;
            else txtPierDer.ForeColor = Color.Black;
        }

        private void txtIzq_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
            if (!rgx.IsMatch(txtIzq.Text)) txtIzq.ForeColor = Color.Red;
            else txtIzq.ForeColor = Color.Black;

        }
    }
}
