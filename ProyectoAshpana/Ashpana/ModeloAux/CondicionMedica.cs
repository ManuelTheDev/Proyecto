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

        public CondicionMedica() { }

        public override bool Equals(object obj)
        {
            if (!(obj is CondicionMedica))
                return false;

            var other = obj as CondicionMedica;

            if (_idCondMed != other.IdCondMed || _nombre != other.Nombre || _descripcion!=other.Descripcion)
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

        public CondicionMedica(int idCondMed, string nombre, string descripcion)
        {
            _idCondMed = idCondMed;
            _nombre = nombre;
            _descripcion = descripcion;
        }

        public int IdCondMed { get => _idCondMed; set => _idCondMed = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
