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
        private int _numSesiones; 

        public Servicio()
        {

        }

        public Servicio(int idServicio, string nombreServicio, double precioServicio, int estadoServicio, int numSesiones)
        {
            IdServicio = idServicio;
            NombreServicio = nombreServicio;
            PrecioServicio = precioServicio;
            EstadoServicio = estadoServicio;
            NumSesiones = numSesiones;
        }

        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public string NombreServicio { get => _nombreServicio; set => _nombreServicio = value; }
        public double PrecioServicio { get => _precioServicio; set => _precioServicio = value; }
        public int EstadoServicio { get => _estadoServicio; set => _estadoServicio = value; }
        public int NumSesiones { get => _numSesiones; set => _numSesiones = value; }
    }
}
