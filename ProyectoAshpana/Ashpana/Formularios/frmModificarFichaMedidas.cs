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
            fichamedida.Fecha = dateTimePicker1.Value;
            fichamedida.Peso = Convert.ToDouble(txtPeso.Text);
            fichamedida.Espalda = Convert.ToDouble(txtEspalda.Text);
            fichamedida.AbdomenAlto = Convert.ToDouble(txtAbAlto.Text);
            fichamedida.AbdomenBajo = Convert.ToDouble(txtAbBajo.Text);
            fichamedida.Cintura = Convert.ToDouble(txtCintura.Text);
            fichamedida.BrazoDerecho = Convert.ToDouble(txtBrDer.Text);
            fichamedida.BrazoIzquierdo = Convert.ToDouble(txtBrIzq.Text);
            fichamedida.Gluteos = Convert.ToDouble(txtGluteos.Text);
            fichamedida.PiernaDer = Convert.ToDouble(txtPierDer.Text);
            fichamedida.PiernaIzq = Convert.ToDouble(txtIzq.Text);
            FichaMedidaBL fichaMedidaBL = new FichaMedidaBL();
            int res = fichaMedidaBL.modificarFichaMedida(fichamedida);
            if (res == 1)
                MessageBox.Show("Se modifico correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("No se modifico correctamente", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
