using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmModificarPaquetes : Form
    {

        private PaqueteBL paqueteBL;
        private Paquete paquete;

        public frmModificarPaquetes()
        {
            InitializeComponent();
            paqueteBL = new PaqueteBL();
        }

        public frmModificarPaquetes(Paquete p)
        {
            InitializeComponent();
            paquete = p;
            paqueteBL = new PaqueteBL();
            txtNombre.Text = p.Nombre;
            txtNumSes.Text = p.CantSesion.ToString();
            txtPrecio.Text = p.Precio.ToString();
        }
        private void frmPaquetesModificar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete p = paquete;
                p.Nombre = txtNombre.Text;
                p.Precio = Double.Parse(txtPrecio.Text);
                p.CantSesion = Int32.Parse(txtNumSes.Text);
                if (p.Precio <= 0 || p.CantSesion <= 0)
                {
                    MessageBox.Show("Ingrese Numeros válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paqueteBL.actualizar(p);
                MessageBox.Show("Se ha modificado el elemento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese Datos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
