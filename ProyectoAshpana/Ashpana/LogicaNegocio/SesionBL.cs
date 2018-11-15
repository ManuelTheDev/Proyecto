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
    public class SesionBL
    {
        private SesionDA sesionDA;
        public SesionBL()
        {
            sesionDA = new SesionDA();
        }

        public BindingList<Sesion> listarSesiones()
        {
            return sesionDA.listarSesiones();
        }

        public BindingList<Sesion> listarSesionesDelDia()
        {
            return sesionDA.listarSesionesDelDia();
        }
    }
}
