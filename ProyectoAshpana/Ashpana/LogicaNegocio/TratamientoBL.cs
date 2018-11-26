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
    public class TratamientoBL
    {
        private TratamientoDA tratamientoDA;
        private CondicionMedicaDA condicionMedicaDA;
        private ZonaDA zonasDA;

        public TratamientoBL()
        {
            tratamientoDA = new TratamientoDA();
            condicionMedicaDA = new CondicionMedicaDA();
            zonasDA = new ZonaDA();
        }

        public BindingList<Tratamiento> listarTratamientos()
        {
            return tratamientoDA.listarTratamientos();

        }

        public int registrarTratamiento(Tratamiento t)
        {
            int idTrat = tratamientoDA.registrarTratamiento(t);
            
            foreach (CondicionMedica cm in t.CondicionesMedicas)
            {
                condicionMedicaDA.registrarCondicionMedica_X_Tratamiento(idTrat, cm);
            }

            foreach(Zona z in t.ZonasTratar)
            {
                zonasDA.registrarZona_X_Tratamiento(idTrat, z);
            }
            return idTrat;
        }

        public int modificarTratamiento(Tratamiento tratamiento1)
        {
            try
            {
                tratamientoDA.modificarTratamiento(tratamiento1);
                foreach (CondicionMedica cm in tratamiento1.CondicionesMedicas)
                {
                    condicionMedicaDA.registrarCondicionMedica_X_Tratamiento(tratamiento1.IdTrat, cm);
                }
                foreach (Zona z in tratamiento1.ZonasTratar)
                {
                    zonasDA.registrarZona_X_Tratamiento(tratamiento1.IdTrat, z);
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }

        public void desacativarCondMedicas_X_Tratamiento(int idTrat)
        {
            condicionMedicaDA.desactivarCondMedica_X_Tratamiento(idTrat);
        }

        public void desactivarZonas_X_Tratamiento(int idTrat)
        {
            zonasDA.desactivarZonas_X_Tratamiento(idTrat);
        }

        public BindingList<Tratamiento> BuscarTratamiento(string busqueda)
        {
            return tratamientoDA.BuscarTratamiento(busqueda);
        }

        public void desactivarTratamiento(int idServicio)
        {
            tratamientoDA.desactivarTratamiento(idServicio);
        }
    }
}
