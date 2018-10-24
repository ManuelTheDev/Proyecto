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

        public void modificarTratamiento(Tratamiento tratamiento)
        {
            tratamientoDA.modificarTratamiento(tratamiento);
        }
    }
}
