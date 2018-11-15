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
        private CondicionMedicaDA condicionMedicaDA;

        public PaqueteBL()
        {
            paquetesDA = new PaqueteDA();
            condicionMedicaDA = new CondicionMedicaDA();
        }

        public int RegistrarPaquete(Paquete paquete)
        {
            int idPaqu = paquetesDA.RegistrarPaquetes(paquete);

            foreach (Tratamiento trat in paquete.Tratamientos)
            {
                paquetesDA.RegistrarPaqueteXTratamiento(idPaqu, trat);
            }

            return idPaqu;
        }

        public BindingList<Paquete> listarPaquetes()
        {
            BindingList<Paquete> paquetes =  paquetesDA.listarPaquetes();
            foreach(Paquete paq in paquetes)
            {
                paq.Tratamientos = paquetesDA.listarPaqueteXTratamiento(paq.IdPaquete);
                foreach(Tratamiento trat in paq.Tratamientos)
                {
                    trat.CondicionesMedicas = condicionMedicaDA.listarCondicionesMedicas_X_Tratamiento(trat.IdTrat);
                }
            }
            return paquetes;
        }

        public BindingList<Paquete> BuscarPaquete(String busqueda)
        {
            return paquetesDA.BuscarPaquete(busqueda);
        }

        public int actualizar(Paquete paqueteAnt,Paquete paqueteMod)
        {
            paquetesDA.actualizar(paqueteMod);
            foreach(Tratamiento trat in paqueteAnt.Tratamientos)
            {
                if (!paqueteMod.Tratamientos.Contains(trat))
                {
                    paquetesDA.actualizarPaquete_X_Tratamiento(paqueteMod.IdPaquete, trat.IdTrat, 0);
                }
            }
            BindingList<Tratamiento> tratamientosInactivos = paquetesDA.listarTratamientosInactivos(paqueteMod.IdPaquete);
            foreach(Tratamiento trat in paqueteMod.Tratamientos)
            {
                if (tratamientosInactivos.Contains(trat))
                {
                    paquetesDA.actualizarPaquete_X_Tratamiento(paqueteMod.IdPaquete, trat.IdTrat, 1);
                }
                if (!paqueteAnt.Tratamientos.Contains(trat))
                {
                    paquetesDA.RegistrarPaqueteXTratamiento(paqueteMod.IdPaquete, trat);
                }
            }
            return 1;
        }

        public int eliminar(Paquete p)
        {
            return paquetesDA.eliminar(p);
        }
    }
}
