using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente : Persona
    {
        private int idCliente;
        private int estado;
        private BindingList<CondicionMedica> condicionesMedicas;

        public Cliente() {
            CondicionesMedicas = new BindingList<CondicionMedica>();
        }
        public Cliente(int idCliente, int idPersona, string dni, string nombres, string apPaterno, string apMaterno,
            string direccion, string telefono, char sexo, string correo, DateTime fechaNac) :
            base(idPersona, dni, nombres, apPaterno, apMaterno,
             direccion, telefono, sexo, correo, fechaNac)
        {
            this.idCliente = idCliente; 
        }
        
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int Estado { get => estado; set => estado = value; }
        public BindingList<CondicionMedica> CondicionesMedicas { get => condicionesMedicas; set => condicionesMedicas = value; }
    }
}
