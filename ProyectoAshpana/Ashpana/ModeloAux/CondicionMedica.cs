using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CondicionMedica
    {
        private int _idCondMed;
        private string _nombre;
        private string _descripcion;
        private int _estadoCondMed;

        

        public CondicionMedica() { }

        public CondicionMedica(int idCondMed, string nombre, string descripcion, int estadoCondMed)
        {
            _idCondMed = idCondMed;
            _nombre = nombre;
            _descripcion = descripcion;
            _estadoCondMed = estadoCondMed;
        }

        public int IdCondMed { get => _idCondMed; set => _idCondMed = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int EstadoCondMed { get => _estadoCondMed; set => _estadoCondMed = value; }

        public override bool Equals(object obj)
        {
            if (!(obj is CondicionMedica))
                return false;

            var other = obj as CondicionMedica;

            if (_idCondMed != other.IdCondMed || _nombre != other.Nombre || _descripcion!=other.Descripcion || _estadoCondMed != other.EstadoCondMed)
                return false;

            return true;
        }

        public static bool operator ==(CondicionMedica cm1,CondicionMedica cm2)
        {
            return cm1.Equals(cm2);
        }

        public static bool operator !=(CondicionMedica cm1, CondicionMedica cm2)
        {
            return !(cm1 == cm2);
        }

       

        
        public override string ToString()
        {
            return Nombre;
        }
    }
}
