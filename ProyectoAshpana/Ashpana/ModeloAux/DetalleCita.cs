using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleCita
    {
        private int idDetalleCita;
        private Servicio servicio;
        private BindingList<Sesion> sesiones;
        
        public DetalleCita()
        {
            Sesiones = new BindingList<Sesion>(); 
        }
        public DetalleCita(int idDetalleCita, Servicio servicio, BindingList<Sesion> sesiones)
        {
            this.IdDetalleCita = idDetalleCita;
            this.Servicio = servicio;
            this.Sesiones = sesiones;
        }

        public String NombreServicio { get => servicio.NombreServicio; }
        public double Precio { get => servicio.PrecioServicio; }
        public int NumSesiones { get => servicio.NumSesiones; }

        public int IdDetalleCita { get => idDetalleCita; set => idDetalleCita = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public BindingList<Sesion> Sesiones { get => sesiones; set => sesiones = value; }
    }
}
