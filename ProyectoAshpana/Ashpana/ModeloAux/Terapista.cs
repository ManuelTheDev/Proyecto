using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Terapista : Trabajador
    {
        private int idTerapista;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private int tipo;
        private BindingList<Tratamiento> tratamientos;

        
        public int Tipo { get => tipo; set => tipo = value; }
        public BindingList<Tratamiento> Tratamientos { get => tratamientos; set => tratamientos = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public int IdTerapista { get => idTerapista; set => idTerapista = value; }

        public Terapista(int idPersona, int idTrabajador, int idTerapista, int tipo, string dni, string nombres, string apPaterno, string apMaterno,
            string direccion, string telefono, char sexo, string correo, DateTime fechaNac, string contrasena, double sueldo,
            DateTime horaEntrada, DateTime horaSalida, List<Tratamiento> tratamientos) :
            base(idPersona, idTrabajador, dni, nombres, apPaterno, apMaterno, direccion, telefono, sexo, correo, fechaNac, contrasena, sueldo)
        {
            this.IdTerapista = idTerapista; 
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
            this.Tipo = tipo;
            this.Tratamientos = new BindingList<Tratamiento>();
        }

        public Terapista()
        {

        }
    }
}
