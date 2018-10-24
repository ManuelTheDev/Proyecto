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
        private BindingList<Tratamiento> listaTratamientos;
        private BindingList<Paquete> listaPaquetes;
        private DateTime fechaRegistro;
        private BindingList<BindingList<Sesion>> sesiones;
        private Cliente cliente;

        public Cita()
        {

        }

        public Cita(BindingList<Tratamiento> listaTratamientos, BindingList<Paquete> listaPaquetes, DateTime fechaRegistro, BindingList<BindingList<Sesion>> sesiones, Cliente cliente)
        {
            this.ListaTratamientos = listaTratamientos;
            this.ListaPaquetes = listaPaquetes;
            this.FechaRegistro = fechaRegistro;
            this.Sesiones = sesiones;
            this.Cliente = cliente;
        }

        public BindingList<Tratamiento> ListaTratamientos { get => listaTratamientos; set => listaTratamientos = value; }
        public BindingList<Paquete> ListaPaquetes { get => listaPaquetes; set => listaPaquetes = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public BindingList<BindingList<Sesion>> Sesiones { get => sesiones; set => sesiones = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
