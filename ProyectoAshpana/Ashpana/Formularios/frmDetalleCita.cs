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
    public partial class frmDetalleCita : Form
    {
        private DetalleCita detalleServicioModificado;
        private Terapista terapistaSeleccionado;
        private int numSesionesTotal = 0; 

        public frmDetalleCita(DetalleCita dt)
        {
            InitializeComponent();
            detalleServicioModificado = new DetalleCita();
            detalleServicioModificado.Servicio = dt.Servicio;
            
            foreach (Sesion s in dt.Sesiones)
            {
                detalleServicioModificado.Sesiones.Add(s);
            }
            dgvDetalleServicio.AutoGenerateColumns = false; 
            dgvDetalleServicio.DataSource = detalleServicioModificado.Sesiones;


            dt.Sesiones.Clear(); 
            foreach(Sesion s in detalleServicioModificado.Sesiones)
            {
               
                dt.Sesiones.Add(s); 
            }
           
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnListarTerapistas_Click(object sender, EventArgs e)
        {
            frmListarTerapistas frmTerapistas = new frmListarTerapistas();
            if (frmTerapistas.ShowDialog() == DialogResult.OK)
            {
                terapistaSeleccionado = frmTerapistas.Terapista;
                txtTerapista.Text= terapistaSeleccionado.Nombres + " " + terapistaSeleccionado.ApPaterno; 
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            if (numSesionesTotal == detalleServicioModificado.Servicio.NumSesiones)
            {
                MessageBox.Show("Ya no puede ingresar más sesiones");
                return; 
            }

            Sesion s = new Sesion();
            s.Terapista = terapistaSeleccionado;
            String horaCita = cboHora.Text + ":" + cboMinuto.Text + ":00";
            TimeSpan hora_E = Convert.ToDateTime(horaCita).TimeOfDay;
            s.Hora = hora_E;
            s.FechaSesion = dtpFecha.Value;
            s.NumDeSesion = numSesionesTotal + 1; 
            detalleServicioModificado.Sesiones.Add(s);
            numSesionesTotal++; 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dgvDetalleServicio.CurrentRow.Index;
            detalleServicioModificado.Sesiones.RemoveAt(indice);
            numSesionesTotal--; 
        }
    }
}
