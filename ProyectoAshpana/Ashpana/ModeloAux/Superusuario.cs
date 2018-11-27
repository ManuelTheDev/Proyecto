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
       

        public int IdSuperusuario { get => idSuperusuario; set => idSuperusuario = value; }
    }
}
