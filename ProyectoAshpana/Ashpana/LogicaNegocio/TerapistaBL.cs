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
    public class TerapistaBL
    {
        private TerapistaDA terapistaDA;

        public TerapistaBL()
        {
            terapistaDA = new TerapistaDA();
        }

        public void registrarTerapista(Terapista t)
        {
            terapistaDA.registrarTerapista(t);
        }

        public BindingList<Terapista> listarTerapistas()
        {
            return terapistaDA.listarTerapistas();
        }

        public void modificarTerapista(Terapista t)
        {
            terapistaDA.modificarTerapista(t);
        }
    }
}
