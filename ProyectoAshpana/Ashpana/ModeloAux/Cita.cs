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
        private DateTime fechaRegistro;
        private BindingList<DetalleCita> detallesCitas;
        private Cliente cliente;
        private double montoTotal;
        private int estado_pago;
        private int estado;
        private string tipoEstado_pago;
        public Cita()
        {
            DetallesCitas = new BindingList<DetalleCita>(); 

        }

        public Cita(int idCita, BindingList<DetalleCita> detallesCitas, Cliente cliente, double montoTotal)
        {
            this.idCita = idCita;
           // this.fechaRegistro = fechaRegistro;
            this.detallesCitas = detallesCitas;
            this.cliente = cliente;
            this.montoTotal = montoTotal;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public BindingList<DetalleCita> DetallesCitas { get => detallesCitas; set => detallesCitas = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int Estado_pago { get => estado_pago; set => estado_pago = value; }
        public int Estado { get => estado; set => estado = value; }
        public String NombPersona { get => cliente.Nombres + " " + cliente.ApPaterno + " " + cliente.ApMaterno; }
        public DateTime FechaUnica { get => FechaRegistro.Date;  }
        public string TipoEstado_pago { get => tipoEstado_pago; set => tipoEstado_pago = value; }
    }
}
