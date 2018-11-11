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
        private DetalleCita dtModificado; 

        public frmDetalleCita(DetalleCita dt)
        {
            InitializeComponent();
            dtModificado = new DetalleCita();
            dtModificado.Servicio = dt.Servicio;
            dt.Servicio = dt.Servicio;
            dt = dtModificado;
            dtModificado.Sesiones = new BindingList<Sesion>();
            dt.Sesiones = new BindingList<Sesion>(); 

            //MODIFICAMOS EL DT MODIFICADO
            if (dt.Servicio.NumSesiones == 1) //si es tratamiento
            {
                Sesion sesion = new Sesion();
                sesion.NumDeSesion = 1;
             
                dtModificado.Sesiones.Add(sesion);
               

                this.dgvDetalleServicio.Rows.Insert(0, 1, "", "", "");
            } 
            else // si es paquete
            {
                for (int i=0; i<dt.Servicio.NumSesiones; i++)
                {
                    Sesion sesion = new Sesion();
                    sesion.NumDeSesion = i+1; 
                    dtModificado.Sesiones.Add(sesion);
                    this.dgvDetalleServicio.Rows.Insert(i, i + 1, "", "", "", ""); 
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = dgvDetalleServicio.CurrentRow.Index;
            frmDetalleSesion frmVerDetalleCita = new frmDetalleSesion(dtModificado.Sesiones[indice], dtModificado.Servicio);
            if (frmVerDetalleCita.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
