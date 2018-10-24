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

        public Zona()
        {

        }

        public Zona(int idZona, string nombreZona, string descripicionZona)
        {
            _idZona = idZona;
            _nombreZona = nombreZona;
            _descripicionZona = descripicionZona;
        }

        public int IdZona { get => _idZona; set => _idZona = value; }
        public string NombreZona { get => _nombreZona; set => _nombreZona = value; }
        public string DescripicionZona { get => _descripicionZona; set => _descripicionZona = value; }
        public override string ToString()
        {
            return NombreZona;
        }
    }
}
