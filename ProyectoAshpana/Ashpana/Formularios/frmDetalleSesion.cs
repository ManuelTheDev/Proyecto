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
    public partial class frmDetalleSesion : Form
    {
        private Terapista terapistaSeleccionado;
        private int clickGuardar=0; 

        private Sesion sesionModificada; 
        public frmDetalleSesion(Sesion s, Servicio servicio)
        {
            InitializeComponent();
            txtNombreServicio.Text = servicio.NombreServicio;
            txtNumSesiones.Text = s.NumDeSesion.ToString();
            sesionModificada = new Sesion();
           
            if (clickGuardar == 1)
            {
                s.Hora = sesionModificada.Hora;
                s.Terapista = sesionModificada.Terapista;
                s.FechaSesion = sesionModificada.FechaSesion; 
            }
           
        }

        private void btnListarTerapistas_Click(object sender, EventArgs e)
        {
            frmListarTerapistas frmTerapistas = new frmListarTerapistas();
            if (frmTerapistas.ShowDialog() == DialogResult.OK)
            {
                terapistaSeleccionado = frmTerapistas.Terapista;
                txtNombreTerapista.Text = terapistaSeleccionado.Nombres + " " + terapistaSeleccionado.ApPaterno + " " + terapistaSeleccionado.ApMaterno;
                
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            sesionModificada.FechaSesion = dtpSesion.Value;

            String horaE = cboHora.Text;
            String minutoE = cboMinuto.Text;

            String horaEntrada = horaE + ":" + minutoE + ":00";
            sesionModificada.Hora = Convert.ToDateTime(horaEntrada).TimeOfDay;

            sesionModificada.Terapista = terapistaSeleccionado;
            clickGuardar = 1; 
        }
    }
}
