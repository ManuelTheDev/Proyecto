﻿using AccesoDatos;
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

        public BindingList<CondicionMedica> listarCondicionesMedicas_X_Cliente(int id_Cliente)
        {
            return condicionMedicaDA.listarCondicionesMedicas_X_Cliente(id_Cliente);
        }

        public BindingList<CondicionMedica> listarCondicionesMedicas_X_Tratamiento(int id_Tratamiento)
        {
            return condicionMedicaDA.listarCondicionesMedicas_X_Tratamiento(id_Tratamiento);
        }
    }

}
