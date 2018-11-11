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
        private int idCita; 
        private int idDetalleCita;
        private Servicio servicio;
        private BindingList<Sesion> sesiones;

        public DetalleCita()
        {

        }
        public DetalleCita(int idCita, int idDetalleCita, Servicio servicio, BindingList<Sesion> sesiones)
        {
            this.IdCita = idCita;
            this.IdDetalleCita = idDetalleCita;
            this.Servicio = servicio;
            this.Sesiones = sesiones;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdDetalleCita { get => idDetalleCita; set => idDetalleCita = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public BindingList<Sesion> Sesiones { get => sesiones; set => sesiones = value; }
    }
}
