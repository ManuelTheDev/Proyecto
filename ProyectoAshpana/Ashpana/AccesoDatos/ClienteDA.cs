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

        public object BuscarCliente(string busqueda)
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
            comando.CommandText = "BUSCAR_CLIENTES";
            comando.Parameters.Add("_BUSQUEDA", MySqlDbType.VarChar).Value = busqueda;
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

        public void modificarCliente(Cliente c)
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
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_CLIENTE";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = c.IdPersona;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = c.IdCliente;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = c.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = c.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = c.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = c.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = c.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = c.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = c.Dni;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = c.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = c.FechaNac;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = c.Estado;
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void modificarCondicionMedica_X_Cliente(int idPersona, int idCliente, int idCondMed, int estado)
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
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_CONDICION_MEDICA_CLIENTE";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = idCliente;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = idPersona;
            comando.Parameters.Add("_ID_CONDICION_MEDICA", MySqlDbType.Int32).Value = idCondMed;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = estado;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

       
        
        public BindingList<CondicionMedica> listarCondicionesMedicasInactivas(int IdCliente)
        {
            BindingList<CondicionMedica> condicionMedicas = new BindingList<CondicionMedica>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                   "user=inf282g4;" +
                   "password=GvZf6p;" +
                   "database=inf282g4;" +
                   "port=3306;" +
                   "SslMode=none;";

            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CONDICIONES_MEDICAS_INACTIVAS";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = IdCliente;
            MySqlDataReader reader = comando.ExecuteReader();
           
            while (reader.Read())
            {
                CondicionMedica cm = new CondicionMedica();
                cm.IdCondMed = reader.GetInt32(0);
                condicionMedicas.Add(cm);
            }
            conexion.Close();
            return condicionMedicas;
        }

        public int registrarFichaMedida_X_Cliente(int idCliente, int idPersona, int idFichaMedida)
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
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "REGISTRAR_FICHA_MEDIDAS_X_CLIENTE";
                comando.Connection = conexion;
                comando.Parameters.Add("_ID_FICHA_MEDIDAS", MySqlDbType.Int32).Value = idFichaMedida;
                comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = idPersona;
                comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = idCliente;

                comando.ExecuteNonQuery();
                conexion.Close();

                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public BindingList<Cliente> listarClientesVerificaciones()
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
            comando.CommandText = "LISTAR_CLIENTES2";
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

    }
}
