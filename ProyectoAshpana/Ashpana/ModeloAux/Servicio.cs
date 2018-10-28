using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Servicio
    {
        private int idServicio;
        private string nombre;
        private double precio;
        private int estado;

        public Servicio()
        {

        }
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
    }
}
