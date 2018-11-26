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

        private Sesion sesionModificada; 
        public frmModificarDetalleSesion(DetalleCita dt)
        {
            InitializeComponent();
            citaBL = new CitaBL(); 

            dgvDetalleServicio.AutoGenerateColumns = false;
            dgvDetalleServicio.DataSource = citaBL.listarSesiones_X_Detalle_Cita(dt.IdDetalleCita);
           
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
    }
}
