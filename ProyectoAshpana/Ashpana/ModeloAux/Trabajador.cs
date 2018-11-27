using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Trabajador: Persona
    {
        private int idTrabajador;
        private int estado; 
        private string contrasena;
        private double sueldo;
        private int logueado; 

        public Trabajador()
        {

        }
        public Trabajador(int idPersona, int idTrabajador, string dni, string nombres, string apPaterno, string apMaterno,
            string direccion, string telefono, char sexo, string correo, DateTime fechaNac, string contrasena, double sueldo, int logueado) :
            base(idPersona, dni,  nombres,  apPaterno,  apMaterno,
             direccion,  telefono,  sexo,  correo, fechaNac) {
            this.IdTrabajador = idTrabajador; 
            this.Contrasena = contrasena;
            this.Sueldo = sueldo;
            this.Logueado = logueado; 

        }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Estado { get => estado; set => estado = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public int Logueado { get => logueado; set => logueado = value; }
    }
}
