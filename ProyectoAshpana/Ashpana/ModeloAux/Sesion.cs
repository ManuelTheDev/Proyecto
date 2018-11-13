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
        private TimeSpan hora;
        private Servicio servicio;
        private int numDeSesion;
     
        public Sesion()
        {

        }

        public Sesion( int idSesion, DateTime fechaSesion, Terapista terapista, TimeSpan hora, Servicio servicio)
        {
           
            this.IdSesion = idSesion;
            this.FechaSesion = fechaSesion;
            this.Terapista = terapista;
            this.Hora = hora;
            this.Servicio = servicio;
        }

      
      
        public int IdSesion { get => idSesion; set => idSesion = value; }
        public DateTime FechaSesion { get => fechaSesion; set => fechaSesion = value; }
        public Terapista Terapista { get => terapista; set => terapista = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public int NumDeSesion { get => numDeSesion; set => numDeSesion = value; }
        public string NombreTerapista { get => terapista.Nombres + " " + terapista.ApPaterno; }
    }
}
