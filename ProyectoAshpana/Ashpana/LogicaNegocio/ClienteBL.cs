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
            condicionMedicaDA = new CondicionMedicaDA();
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
            BindingList<Cliente> clientes = clienteDA.listarClientes();
            foreach(Cliente cli in clientes)
            {
                cli.CondicionesMedicas = condicionMedicaDA.listarCondicionesMedicas_X_Cliente(cli.IdCliente);
            }
            return clientes;
        }

        public int modificarTerapista(Cliente clienteAnt, Cliente clienteMod)
        {
            try
            {
                clienteDA.modificarCliente(clienteMod);
                foreach (CondicionMedica cm in clienteAnt.CondicionesMedicas)
                {
                    if (!clienteMod.CondicionesMedicas.Contains(cm))
                    {
                        clienteDA.modificarCondicionMedica_X_Cliente(clienteMod.IdPersona, clienteMod.IdCliente, cm.IdCondMed, 0);
                    }
                }

                BindingList<CondicionMedica> condicionMedicasInactivas = clienteDA.listarCondicionesMedicasInactivas(clienteMod.IdCliente);
                foreach (CondicionMedica cm in clienteMod.CondicionesMedicas)
                {
                    if (condicionMedicasInactivas.Contains(cm))
                    {
                        clienteDA.modificarCondicionMedica_X_Cliente(clienteMod.IdPersona, clienteMod.IdCliente, cm.IdCondMed, 1);
                    }

                    if (!clienteAnt.CondicionesMedicas.Contains(cm))
                    {
                        condicionMedicaDA.registrarCondicionMedica_X_Paciente(clienteMod.IdCliente, clienteMod.IdPersona, cm);
                    }
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int registrarFichaMedida_X_Cliente(FichaMedida fm, Cliente c)
        {
            ClienteDA clienteDA = new ClienteDA();
            FichaMedidaBL fichaMedidaBL = new FichaMedidaBL();
            int idFichaMedida = fichaMedidaBL.registrarFichaMedida(fm);
            return clienteDA.registrarFichaMedida_X_Cliente(c.IdCliente, c.IdPersona, idFichaMedida);
            
        }

        public object BuscarCliente(string busqueda)
        {
            return clienteDA.BuscarCliente(busqueda);
        }

        public BindingList<Cliente> listarClientesVerificaciones()
        {
            return clienteDA.listarClientesVerificaciones();
        }
    }
}
