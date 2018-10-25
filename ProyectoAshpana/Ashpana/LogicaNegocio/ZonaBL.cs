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
    public class ZonaBL
    {
        private ZonaDA zonaDA;
        public ZonaBL()
        {
            zonaDA = new ZonaDA();
        }

        public BindingList<Zona> listarZonas()
        {
            return zonaDA.listarZonas();
        }

        public BindingList<Zona> listarZonas_X_Tratamiento(int id_Tratamiento)
        {
            return zonaDA.listarZonas_X_Tratamiento(id_Tratamiento);
        }
    }
}
