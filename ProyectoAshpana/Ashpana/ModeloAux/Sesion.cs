using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sesion
    {
        private int idSesion;
        private DateTime fechaSesion;
        private Terapista terapista;
        private Hora hora;
        private Tratamiento tratamiento;
        private Paquete paquete;
        private int numSesion; 
        public Sesion()
        {

        }

        public Sesion(int idSesion, DateTime fechaSesion, Terapista terapista, Hora hora)
        {
            this.idSesion = idSesion;
            this.fechaSesion = fechaSesion;
            this.terapista = terapista;
            this.hora = hora;
        }

        public int IdSesion { get => idSesion; set => idSesion = value; }
        public DateTime FechaSesion { get => fechaSesion; set => fechaSesion = value; }
        internal Terapista Terapista { get => terapista; set => terapista = value; }
        internal Hora Hora { get => hora; set => hora = value; }
    }
}
