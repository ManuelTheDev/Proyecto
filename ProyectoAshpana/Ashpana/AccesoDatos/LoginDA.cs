﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AccesoDatos
{
    public class LoginDA
    {
        public int iniciarSesion(string usuario, string contrasenia, ref int tipo)
        {
            try
            {
                string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                    "port=3306;" +
                    "SslMode=none;";

                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();
             
                MySqlCommand comando = new MySqlCommand("call INICIAR_SESION(@usuario, @contra);", conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contra", contrasenia);
                comando.Prepare();

                MySqlDataReader lector = comando.ExecuteReader();

                lector.Read();
                try
                {
                    tipo = lector.GetInt32(1);

                    if (tipo != -1)
                    {
                        conexion.Close();
                        return 1;
                    }
                    else
                    {
                        conexion.Close();
                        return 0;
                    }
                }
                catch(Exception ex)
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }

           
        }

        public int cerrarSesion(string usuario)
        {
            try
            {
                string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                    "port=3306;" +
                    "SslMode=none;";

                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();

                MySqlCommand comando = new MySqlCommand("call CERRAR_SESION(@usuario);", conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Prepare();

                comando.ExecuteNonQuery();
                conexion.Close();
                return 1; 
            }
            catch (Exception e)
            {
                return 0;
            }


        }

    }
}
