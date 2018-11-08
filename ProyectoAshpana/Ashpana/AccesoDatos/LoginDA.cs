using MySql.Data.MySqlClient;
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
        public int iniciarSesion(string usuario, string contrasenia)
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
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText= ("SELECT P.DNI, P.APELLIDO_PATERNO, P.NOMBRES, P.APELLIDO_MATERNO FROM TRABAJADOR T, PERSONA P WHERE P.DNI = '" + usuario + "'AND T.CONTRASENIA = '" + contrasenia +"'AND  T.ID_PERSONA_FK= P.ID_PERSONA");
                MySqlDataReader leer = comando.ExecuteReader(); 
                if (leer.Read())
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
            catch (Exception e)
            {
                return 0;
            }

           
        }

    }
}
