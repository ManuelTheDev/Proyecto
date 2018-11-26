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
    public class SesionDA
    {
        public int registrarSesion(Sesion s, int idDetalleCita, int idCita,int idCliente)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                     "user=inf282g4;" +
                     "password=GvZf6p;" +
                     "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            try
            {
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand();

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "REGISTRAR_SESION";
                comando.Connection = con;
                comando.Parameters.Add("_FECHA_SESION", MySqlDbType.DateTime).Value = s.FechaSesion;
                comando.Parameters.Add("_ID_TERAPISTA", MySqlDbType.Int32).Value = s.Terapista.IdTerapista;
                comando.Parameters.Add("_ID_SERVICIO", MySqlDbType.Int32).Value = s.Servicio.IdServicio;
                comando.Parameters.Add("_NUM_SESION", MySqlDbType.Int32).Value = s.NumDeSesion;
                comando.Parameters.Add("_ID_DETALLE_CITA", MySqlDbType.Int32).Value =idDetalleCita ;
                comando.Parameters.Add("_ID_CITA", MySqlDbType.Int32).Value = idCita;
                comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = idCliente;
                comando.Parameters.Add("_HORA", MySqlDbType.Time).Value = s.Hora;
                comando.ExecuteNonQuery();
                con.Close();
              
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public BindingList<Sesion> listarSesiones()
        {
            BindingList<Sesion> sesiones = new BindingList<Sesion>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;" +
                      "Convert Zero Datetime=True;";

            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_SESIONES";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Sesion s = new Sesion();
                s.IdSesion= reader.GetInt32("ID_SESION");
                s.FechaSesion = reader.GetDateTime("FECHA_SESION");
                s.NumDeSesion = reader.GetInt32("NUM_SESION");
                Servicio servicio = new Servicio();
                servicio.NombreServicio= reader.GetString("NOMBRE_SERVICIO");
                s.Servicio = servicio; 
                s.Hora = reader.GetTimeSpan("HORA");
                //cliente
                Cliente cliente = new Cliente();
                cliente.Nombres = reader.GetString("NOMBRES");
                cliente.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                s.Cliente = cliente;
                //terapista
                reader.Read();
                Terapista terapista = new Terapista(); 
                terapista.Nombres = reader.GetString("NOMBRES");
                terapista.ApPaterno = reader.GetString("APELLIDO_PATERNO");

                s.Terapista = terapista; 

                sesiones.Add(s);
            }
            conexion.Close();

            return sesiones;
        }

        public BindingList<Sesion> listarSesionesDelDia()
        {
            BindingList<Sesion> sesiones = new BindingList<Sesion>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;" +
                      "Convert Zero Datetime=True;";

            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CITAS_DEL_DIA";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Sesion s = new Sesion();
                s.IdSesion = reader.GetInt32("ID_SESION");
                s.FechaSesion = reader.GetDateTime("FECHA_SESION");
                s.NumDeSesion = reader.GetInt32("NUM_SESION");
                Servicio servicio = new Servicio();
                servicio.NombreServicio = reader.GetString("NOMBRE_SERVICIO");
                s.Servicio = servicio;
                s.Hora = reader.GetTimeSpan("HORA");

                //terapista
                Terapista terapista = new Terapista();
                terapista.Nombres = reader.GetString("NOMBRES");
                terapista.ApPaterno = reader.GetString("APELLIDO_PATERNO");

                //cliente
                reader.Read();
                Cliente cliente = new Cliente();
                cliente.Nombres = reader.GetString("NOMBRES");
                cliente.ApPaterno = reader.GetString("APELLIDO_PATERNO");

                s.Cliente = cliente;

                s.Terapista = terapista;

                sesiones.Add(s);
            }
            conexion.Close();

            return sesiones;
        }

        public void eliminarSesion(int id_sesion)
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
            comando.CommandText = "ELIMINAR_SESION";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_SESION", MySqlDbType.Int32).Value = id_sesion;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void actualizarNumeroSesion(int id_sesion,int numero_sesion)
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
            comando.CommandText = "ACTUALIZAR_NUMERO_SESION";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_SESION", MySqlDbType.Int32).Value = id_sesion;
            comando.Parameters.Add("_NUMERO_SESION", MySqlDbType.Int32).Value = numero_sesion;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
