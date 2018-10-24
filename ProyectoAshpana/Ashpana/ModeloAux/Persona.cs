using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private int idPersona;
        private string dni;
        private string nombres;
        private string apPaterno;
        private string apMaterno;
        private string direccion;
        private string telefono;
        private char sexo;
        private string correo;
        private DateTime fechaNac;

        public Persona() { }

        public Persona(int idPersona, string dni, string nombres, string apPaterno, string apMaterno, string direccion, string telefono, char sexo, string correo, DateTime fechaNac)
        {
            this.IdPersona = idPersona;
            this.Dni = dni;
            this.Nombres = nombres;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Sexo = sexo;
            this.Correo = correo;
            this.FechaNac = fechaNac;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
