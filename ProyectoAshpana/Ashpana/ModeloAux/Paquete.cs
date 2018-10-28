using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Paquete : Servicio
    {
        private int idPaquete;
        private BindingList<Tratamiento> tratamientos;
        private int cantSesion;

        private String strTratamientos;

        public Paquete()
        {
            tratamientos = new BindingList<Tratamiento>();
        }


        public Paquete(int idPaquete, String nombre, double precio, int cantSesion)
        {
            this.idPaquete = idPaquete;
            this.NombreServicio = nombre;
            this.PrecioServicio = precio;
            this.cantSesion = cantSesion;
            Tratamientos = new BindingList<Tratamiento>();
        }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        public int CantSesion { get => cantSesion; set => cantSesion = value; }
        public BindingList<Tratamiento> Tratamientos { get => tratamientos; set => tratamientos = value; }
        public string Nombre { get => NombreServicio; }
        public double Precio { get => PrecioServicio; }
        public void addTratamiento(Tratamiento t)
        {
            Tratamientos.Add(t);
        }
    }
}
