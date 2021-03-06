﻿using System;
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
        private Cliente cliente; 

        public String NomCliente { get => Cliente.Nombres + " " + Cliente.ApPaterno; }
        public String NomTerapista { get => Terapista.Nombres + " " + Terapista.ApPaterno; }
        public String NomServicio { get => Servicio.NombreServicio; }
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

        public override bool Equals(object obj)
        {
            if (!(obj is Sesion))
                return false;

            var other = obj as Sesion;

            if (this.idSesion != other.idSesion)
                return false;

            return true;
        }

        public static bool operator ==(Sesion cm1, Sesion cm2)
        {
            return cm1.Equals(cm2);
        }

        public static bool operator !=(Sesion cm1, Sesion cm2)
        {
            return !(cm1 == cm2);
        }


        public int IdSesion { get => idSesion; set => idSesion = value; }
        public DateTime FechaSesion { get => fechaSesion; set => fechaSesion = value; }

        public DateTime fecha { get => fechaSesion.Date; }
        public Terapista Terapista { get => terapista; set => terapista = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public int NumDeSesion { get => numDeSesion; set => numDeSesion = value; }
        public string NombreTerapista { get => terapista.Nombres + " " + terapista.ApPaterno; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
