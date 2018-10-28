using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CondicionMedicaDA
    {
        public BindingList<CondicionMedica> listarCondicionMedica()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<CondicionMedica> condicionesMedicas = new BindingList<CondicionMedica>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_CONDICIONES_MEDICAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                CondicionMedica c = new CondicionMedica();
                c.IdCondMed = reader.GetInt32(0);
                c.Nombre = reader.GetString(1);
                c.Descripcion = reader.GetString(2);
                c.EstadoCondMed = reader.GetInt32(3);
                condicionesMedicas.Add(c);
            }
            conexion.Close();
            return condicionesMedicas;
        }

        public void registrarCondicionMedica_X_Paciente(int id_cliente, int idPersona, CondicionMedica cm)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                     "user=inf282g4;" +
                     "password=GvZf6p;" +
                     "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "REGISTRAR_CONDICION_MEDICA_X_CLIENTE";
            comando.Connection = con;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.VarChar).Value =id_cliente;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.VarChar).Value = idPersona;
            comando.Parameters.Add("_ID_CONDICION_MEDICA", MySqlDbType.VarChar).Value = cm.IdCondMed;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void registrarCondicionMedica_X_Tratamiento(int id_tratamiento, CondicionMedica cm)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "REGISTRAR_CONDICION_MEDICA_X_TRATAMIENTO";
            comando.Connection = con;

            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.VarChar).Value = id_tratamiento;
            comando.Parameters.Add("_ID_CONDICION_MEDICA", MySqlDbType.VarChar).Value = cm.IdCondMed;

            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<CondicionMedica> listarCondicionesMedicas_X_Cliente(int id_Cliente)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<CondicionMedica> condicionesMedicas = new BindingList<CondicionMedica>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_CONDICIONES_MEDICAS_X_CLIENTE";
            comando.Connection = conexion;   
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = id_Cliente;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                CondicionMedica c = new CondicionMedica();
                c.IdCondMed = reader.GetInt32(0);
                c.Nombre = reader.GetString(1);
                c.Descripcion = reader.GetString(2);
                c.EstadoCondMed = reader.GetInt32(3);
                condicionesMedicas.Add(c);
            }
            conexion.Close();
            return condicionesMedicas;
        }

        public BindingList<CondicionMedica> listarCondicionesMedicas_X_Tratamiento(int id_Tratamiento)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<CondicionMedica> condicionesMedicas = new BindingList<CondicionMedica>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_CONDICIONES_MEDICAS_X_TRATAMIENTO";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = id_Tratamiento;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                CondicionMedica c = new CondicionMedica();
                c.IdCondMed = reader.GetInt32(0);
                c.Nombre = reader.GetString(1);
                c.Descripcion = reader.GetString(2);
                c.EstadoCondMed = reader.GetInt32(3);
                condicionesMedicas.Add(c);
            }
            conexion.Close();
            return condicionesMedicas;
        }


    }
}
