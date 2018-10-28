using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Servicio
    {
<<<<<<< HEAD
        private int idServicio;
        private string nombre;
        private double precio;
        private int estado;
=======
        private int _idServicio;
        private string _nombreServicio;
        private double _precioServicio;
        private int _estadoServicio;
>>>>>>> 1fa5ac468c3315a644d04610eb55da57a9f16445

        public Servicio()
        {

        }
<<<<<<< HEAD
        public Servicio(int idServicio, string nombre, double precio, int estado)
        {
            this.IdServicio = idServicio;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Estado = estado;
        }

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Estado { get => estado; set => estado = value; }
=======

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
>>>>>>> 1fa5ac468c3315a644d04610eb55da57a9f16445
    }
}
