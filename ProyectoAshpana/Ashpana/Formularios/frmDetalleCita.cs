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
        private int numSesionesTotal;

        public DetalleCita DetalleServicioModificado { get => detalleServicioModificado; set => detalleServicioModificado = value; }

        public frmDetalleCita(DetalleCita dt)
        {
            InitializeComponent();
            DetalleServicioModificado = new DetalleCita();
            DetalleServicioModificado.Servicio = dt.Servicio;
            
            foreach (Sesion s in dt.Sesiones)
            {
                DetalleServicioModificado.Sesiones.Add(s);
            }
            dgvDetalleServicio.AutoGenerateColumns = false; 
            dgvDetalleServicio.DataSource = DetalleServicioModificado.Sesiones;


            dt.Sesiones.Clear(); 
            foreach(Sesion s in DetalleServicioModificado.Sesiones)
            {
               
                dt.Sesiones.Add(s); 
            }
            numSesionesTotal = detalleServicioModificado.Sesiones.Count;



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
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            if (numSesionesTotal == DetalleServicioModificado.Servicio.NumSesiones)
           // if (DetalleServicioModificado.Sesiones.Count==DetalleServicioModificado.Servicio.NumSesiones)
            {
                MessageBox.Show("Ya no puede ingresar más sesiones");
                return; 
            }

            Sesion s = new Sesion();
            Servicio serv = new Servicio();
            serv.IdServicio = detalleServicioModificado.Servicio.IdServicio;

            s.Servicio = serv;
            s.Terapista = terapistaSeleccionado;
            String horaCita = cboHora.Text + ":" + cboMinuto.Text + ":00";
            TimeSpan hora_E = Convert.ToDateTime(horaCita).TimeOfDay;
            s.Hora = hora_E;
            s.FechaSesion = dtpFecha.Value;
            s.NumDeSesion = numSesionesTotal + 1; 
            DetalleServicioModificado.Sesiones.Add(s);
            numSesionesTotal++; 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dgvDetalleServicio.CurrentRow.Index;
            DetalleServicioModificado.Sesiones.RemoveAt(indice);
            numSesionesTotal--; 
        }
    }
}
