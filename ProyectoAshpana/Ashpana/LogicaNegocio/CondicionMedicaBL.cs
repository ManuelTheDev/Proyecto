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
    public class CondicionMedicaBL
    {
        private CondicionMedicaDA condicionMedicaDA;
        public CondicionMedicaBL()
        {
            condicionMedicaDA = new CondicionMedicaDA(); 
        }

        public BindingList<CondicionMedica> listarCondicionesMedicas()
        {
            return condicionMedicaDA.listarCondicionMedica(); 
        }
    }
}
