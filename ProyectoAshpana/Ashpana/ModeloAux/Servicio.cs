using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Servicio
    {

        private int _idServicio;
        private string _nombreServicio;
        private double _precioServicio;
        private int _estadoServicio;


        public Servicio()
        {

        }


       


        public Servicio(int idServicio, string nombreServicio, double precioServicio, int estadoServicio)
        {
            _idServicio = idServicio;
            _nombreServicio = nombreServicio;
            _precioServicio = precioServicio;
            _estadoServicio = estadoServicio;
        }

        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public string NombreServicio { get => _nombreServicio; set => _nombreServicio = value; }
        public double PrecioServicio { get => _precioServicio; set => _precioServicio = value; }
        public int EstadoServicio { get => _estadoServicio; set => _estadoServicio = value; }

    }
}
