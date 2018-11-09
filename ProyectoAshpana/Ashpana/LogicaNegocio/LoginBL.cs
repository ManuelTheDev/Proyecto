﻿using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LoginBL
    {

        private LoginDA loginDA; 

        public LoginBL()
        {
            loginDA = new LoginDA(); 
        }

        public Boolean iniciar_sesion(string usuario, string contrasenia)
        {
            if (loginDA.iniciarSesion(usuario, contrasenia) == 1) return true;
            else return false; 
        }
    }
}