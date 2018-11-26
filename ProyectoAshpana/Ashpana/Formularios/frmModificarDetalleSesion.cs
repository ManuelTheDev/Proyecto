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
    public partial class frmModificarDetalleSesion : Form
    {
        private Terapista terapistaSeleccionado;
        private CitaBL citaBL; 
        private int clickGuardar=0;
        private DetalleCita DetalleCita;
        private BindingList<DateTime> fechasSesiones = new BindingList<DateTime>();
        private Sesion sesionModificada;

        public Terapista TerapistaSeleccionado { get => terapistaSeleccionado; set => terapistaSeleccionado = value; }
        public DetalleCita DetalleCita1 { get => DetalleCita; set => DetalleCita = value; }

        public frmModificarDetalleSesion(DetalleCita dt)
        {
            InitializeComponent();
            citaBL = new CitaBL();
            DetalleCita1 = new DetalleCita();
            DetalleCita1 = dt;

            dgvDetalleServicio.AutoGenerateColumns = false;


            dgvDetalleServicio.DataSource = DetalleCita1.Sesiones;
            foreach(Sesion s in dt.Sesiones)
            {
                fechasSesiones.Add(s.fecha);
            }         
        }

        private void btnListarTerapistas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            if(DetalleCita1.NumSesiones == DetalleCita1.Sesiones.Count)
            {
                MessageBox.Show("Ya no puede ingresar más sesiones");
                return;
            }

            Sesion s = new Sesion();
            
            Servicio serv = new Servicio();
            serv.IdServicio = DetalleCita1.Servicio.IdServicio;

            s.Servicio = serv;
            s.Terapista = TerapistaSeleccionado;

            String horaCita = cboHora.Text + ":" + cboMinuto.Text + ":00";
            TimeSpan hora_E = Convert.ToDateTime(horaCita).TimeOfDay;

            if (dtpFecha.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Seleccione una fecha posterior a la del día de hoy");
                return;
            }
            if (dtpFecha.Value.Date == DateTime.Now.Date && hora_E < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Seleccione una hora posterior a la hora actual");
                return;
            }
            foreach (DateTime dt in fechasSesiones)
            {
                if (dt.Date == dtpFecha.Value.Date)
                {
                    MessageBox.Show("Seleccione una fecha diferente a las ingresadas anteriormente");
                    return;
                }
            }
            s.Hora = hora_E;
            s.FechaSesion = dtpFecha.Value;

            s.NumDeSesion = DetalleCita1.Sesiones.Count + 1;
            DetalleCita1.Sesiones.Add(s);
        }

        private void btnListarTerapistas_Click_1(object sender, EventArgs e)
        {
            frmListarTerapistas frmTerapistas = new frmListarTerapistas(DetalleCita1.Servicio.IdServicio, DetalleCita1.Servicio.NumSesiones);
            if (frmTerapistas.ShowDialog() == DialogResult.OK)
            {
                TerapistaSeleccionado = frmTerapistas.Terapista;
                txtTerapista.Text = TerapistaSeleccionado.Nombres + " " + TerapistaSeleccionado.ApPaterno;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dgvDetalleServicio.CurrentRow.Index;
            DetalleCita1.Sesiones.RemoveAt(indice);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
