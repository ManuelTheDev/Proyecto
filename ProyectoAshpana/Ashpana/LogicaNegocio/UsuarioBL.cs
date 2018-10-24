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
    public class UsuarioBL
    {
        private UsuarioDA usuarioDA; 

        public UsuarioBL()
        {
            usuarioDA = new UsuarioDA(); 
        }

        public void registrarSuperusuario(Superusuario s)
        {
            usuarioDA.registrarSuperusuario(s);
        }

        public BindingList<Superusuario> listarSuperusuarios()
        {
            return usuarioDA.listarSuperusuarios(); 
        }

        public void modificarSuperusuario(Superusuario s)
        {
            usuarioDA.modificarUsuario(s);
        }
    }
}
