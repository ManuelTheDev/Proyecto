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
    public class ClienteDA
    {
        public BindingList<Cliente> listarClientes()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Cliente> clientes = new BindingList<Cliente>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CLIENTES";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente c = new Cliente();
                c.IdPersona = reader.GetInt32("ID_PERSONA");
                c.IdCliente = reader.GetInt32("ID_CLIENTE");
                c.Dni = reader.GetString("DNI");
                c.Nombres = reader.GetString("NOMBRES");
                c.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                c.ApMaterno = reader.GetString("APELLIDO_MATERNO");
                c.Correo = reader.GetString("CORREO");
                c.Direccion = reader.GetString("DIRECCION");
                c.Telefono = reader.GetString("TELEFONO");
                c.Estado = reader.GetInt32("ESTADO");
                c.Sexo = reader.GetChar("SEXO");
                c.FechaNac = reader.GetDateTime("FECHA_NACIMIENTO");


                clientes.Add(c);
            }
            conexion.Close();
            return clientes;
        }

        public void registrarCliente(Cliente s, ref int idCliente, ref int idPersona)
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
            comando.CommandText = "REGISTRAR_CLIENTE";
            comando.Connection = con;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = s.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = s.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = s.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = s.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = s.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = s.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = s.Dni;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = s.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = s.FechaNac;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output; 
            comando.ExecuteNonQuery();
            con.Close();
            idCliente = Convert.ToInt32(comando.Parameters["_ID_CLIENTE"].Value);
            idPersona = Convert.ToInt32(comando.Parameters["_ID_PERSONA"].Value);
        }

        public void modificarCliente(Cliente s)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comandoAux = new MySqlCommand("SELECT ID_PERSONA FROM PERSONA WHERE DNI = " + s.Dni, con);
            MySqlDataReader reader = null;
            reader = comandoAux.ExecuteReader();
            reader.Read();
            int id_cliente = reader.GetInt32(0);
            reader.Dispose();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_CLIENTE";
            comando.Connection = con;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Value = id_cliente;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = s.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = s.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = s.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = s.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = s.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = s.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = s.Dni;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = s.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = s.FechaNac;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = s.Estado;
            comando.ExecuteNonQuery();
            con.Close();
        }

    }
}
