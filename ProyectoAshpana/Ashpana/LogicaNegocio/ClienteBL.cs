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
    public class ClienteBL
    {
        private ClienteDA clienteDA;
        private CondicionMedicaDA condicionMedicaDA;

        public ClienteBL()
        {
            clienteDA = new ClienteDA();
        }

        public void registrarCliente(Cliente c)
        {
            int idCliente=0,idPersona=0;
            clienteDA.registrarCliente(c, ref idCliente, ref idPersona);
            condicionMedicaDA = new CondicionMedicaDA();
            foreach(CondicionMedica cm in c.CondicionesMedicas)
            {
                condicionMedicaDA.registrarCondicionMedica_X_Paciente(idCliente, idPersona, cm);
            }
        }

        public BindingList<Cliente> listarClientes()
        {
            return clienteDA.listarClientes();
        }

        public void modificarTerapista(Cliente c)
        {
            clienteDA.modificarCliente(c);
        }
    }
}
