using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace LogicaNegocio
{
    public class FichaMedidaBL
    {

        public FichaMedidaBL()
        {
            FichaMedidaDA fichaMedidaDA;
        }

        public BindingList<FichaMedida> listarFichaMedidas(Cliente c)
        {
            FichaMedidaDA fichaMedidaDA = new FichaMedidaDA();
            return fichaMedidaDA.listarFichaMedidas_X_Cliente(c);
        }

        public int registrarFichaMedida(FichaMedida fm)
        {
            FichaMedidaDA fichaMedidaDA = new FichaMedidaDA();
            int idFichaMedida = fichaMedidaDA.registrarFichaMedida(fm);
            return idFichaMedida;
        }

        public int modificarFichaMedida(FichaMedida fm)
        {
            FichaMedidaDA fichaMedidaDA = new FichaMedidaDA();
            return fichaMedidaDA.modificarFichaMedida(fm);
        }
    }
}
