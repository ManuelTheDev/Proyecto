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
        private double montoTotal; 

        public Cita()
        {
            DetallesCitas = new BindingList<DetalleCita>(); 

        }

        public Cita(int idCita, TimeSpan fechaRegistro, BindingList<DetalleCita> detallesCitas, Cliente cliente, double montoTotal)
        {
            this.idCita = idCita;
            this.fechaRegistro = fechaRegistro;
            this.detallesCitas = detallesCitas;
            this.cliente = cliente;
            this.montoTotal = montoTotal;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public TimeSpan FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public BindingList<DetalleCita> DetallesCitas { get => detallesCitas; set => detallesCitas = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
    }
}
