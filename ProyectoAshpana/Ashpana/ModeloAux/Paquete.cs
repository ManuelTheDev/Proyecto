using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Paquete
    {
        private int idPaquete;
        private String nombre;
        private double precio;
        private int estado;
        private BindingList<Tratamiento> tratamientos;
        private int cantSesion;

        private String strTratamientos;

        public Paquete()
        {
            Tratamientos = new BindingList<Tratamiento>();
        }


        public Paquete(int idPaquete, String nombre, double precio, int cantSesion)
        {
            this.idPaquete = idPaquete;
            this.nombre = nombre;
            this.precio = precio;
            this.cantSesion = cantSesion;
            Tratamientos = new BindingList<Tratamiento>();
        }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Estado { get => estado; set => estado = value; }
        public int CantSesion { get => cantSesion; set => cantSesion = value; }
        public BindingList<Tratamiento> Tratamientos { get => tratamientos; set => tratamientos = value; }

        public void addTratamiento(Tratamiento t)
        {
            Tratamientos.Add(t);
        }
    }
}
