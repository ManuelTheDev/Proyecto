using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PaqueteBL
    {
        private PaqueteDA paquetesDA;

        public PaqueteBL()
        {
            paquetesDA = new PaqueteDA();
        }

        public int RegistrarPaquete(Paquete paquete)//, BindingList<Tratamiento> tratamientos)
        {
            return paquetesDA.RegistrarPaquetes(paquete);//, tratamientos);
        }

        public BindingList<Paquete> listarPaquetes()
        {
            return paquetesDA.listarPaquetes();
        }

        public BindingList<Paquete> BuscarPaquete(String busqueda)
        {
            return paquetesDA.BuscarPaquete(busqueda);
        }

        public int actualizar(Paquete p)
        {
            return paquetesDA.actualizar(p);
        }

        public int eliminar(Paquete p)
        {
            return paquetesDA.eliminar(p);
        }
    }
}
