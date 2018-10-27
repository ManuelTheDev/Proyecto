using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Zona
    {
        private int _idZona;
        private String _nombreZona;
        private String _descripicionZona;
        private int _estadoZona;

        public Zona()
        {

        }

        public Zona(int idZona, string nombreZona, string descripicionZona, int estadoZona)
        {
            _idZona = idZona;
            _nombreZona = nombreZona;
            _descripicionZona = descripicionZona;
            _estadoZona = estadoZona;
        }

        public int IdZona { get => _idZona; set => _idZona = value; }
        public string NombreZona { get => _nombreZona; set => _nombreZona = value; }
        public string DescripicionZona { get => _descripicionZona; set => _descripicionZona = value; }
        public int EstadoZona { get => _estadoZona; set => _estadoZona = value; }

        

        public override bool Equals(object obj)
        {
            if (!(obj is Zona))
                return false;

            var other = obj as Zona;

            if (_idZona != other.IdZona || _nombreZona != other.NombreZona || _descripicionZona != other.DescripicionZona || _estadoZona != other.EstadoZona)
                return false;

            return true;
        }

        public static bool operator !=(Zona cm1, Zona cm2)
        {
            return !(cm1 == cm2);
        }
        public static bool operator ==(Zona cm1, Zona cm2)
        {
            return cm1.Equals(cm2);
        }
       
        public override string ToString()
        {
            return NombreZona;
        }


       

        

    }
}
