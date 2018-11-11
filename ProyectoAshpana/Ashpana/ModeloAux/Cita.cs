using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cita
    {
        private int idCita; 
        private TimeSpan fechaRegistro;
        private BindingList<DetalleCita> detallesCitas;
        private Cliente cliente;


        public Cita()
        {
            detallesCitas = new BindingList<DetalleCita>(); 

        }

        public Cita(int idCita, TimeSpan fechaRegistro, BindingList<DetalleCita> detallesCitas, Cliente cliente)
        {
            this.IdCita = idCita;
            this.FechaRegistro = fechaRegistro;
            this.DetallesCitas = detallesCitas;
            this.Cliente = cliente;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public TimeSpan FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public BindingList<DetalleCita> DetallesCitas { get => detallesCitas; set => detallesCitas = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
