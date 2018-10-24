using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Superusuario: Trabajador
    {
        private int idSuperusuario; 
        public Superusuario()
        {

        }
        public Superusuario(int idSuperusuario, int idPersona, int idTrabajador, string dni, string nombres, string apPaterno, string apMaterno,
            string direccion, string telefono, char sexo, string correo, DateTime fechaNa, string contrasena, double sueldo) :
            base(idPersona, idTrabajador, dni, nombres, apPaterno, apMaterno,
             direccion, telefono, sexo, correo, fechaNa, contrasena, sueldo)
        {

            this.idSuperusuario = idSuperusuario; 
        }

        public int IdSuperusuario { get => idSuperusuario; set => idSuperusuario = value; }
    }
}
