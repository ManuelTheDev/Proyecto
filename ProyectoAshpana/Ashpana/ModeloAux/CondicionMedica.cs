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
