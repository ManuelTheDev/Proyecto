using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class TerapistaDA
    {
        public BindingList<Terapista> listarTerapistas()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;" +
                      "Convert Zero Datetime=True;";

            BindingList<Terapista> terapistas = new BindingList<Terapista>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TERAPISTAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Terapista t = new Terapista();
                t.IdPersona = reader.GetInt32("ID_PERSONA");
                t.IdTrabajador = reader.GetInt32("ID_TRABAJADOR");
                t.IdTerapista = reader.GetInt32("ID_TERAPISTA");
                t.Dni = reader.GetString("DNI");
                t.Nombres = reader.GetString("NOMBRES");
                t.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                t.ApMaterno = reader.GetString("APELLIDO_MATERNO");
                t.Correo = reader.GetString("CORREO");
                t.Direccion = reader.GetString("DIRECCION");
                t.Telefono = reader.GetString("TELEFONO");
                t.Sueldo = reader.GetDouble("SUELDO");
                t.Estado = reader.GetInt32("ESTADO");
                t.Sexo = reader.GetChar("SEXO");
                TimeSpan horaEntradaAux = reader.GetTimeSpan("HORA_ENTRADA");
                DateTime dt = new DateTime(2012, 01, 01);
                t.HoraEntrada = dt + horaEntradaAux;
                TimeSpan horaSalidaAux = reader.GetTimeSpan("HORA_SALIDA");
                t.HoraSalida = dt + horaSalidaAux; 
                t.FechaNac = reader.GetDateTime("FECHA_NACIMIENTO");
                t.Contrasena = reader.GetString("CONTRASENIA");
                terapistas.Add(t);
            }
            conexion.Close();
            return terapistas;
        }

        public void registrarTerapista(Terapista t, string horaE, string horaS, string minutoE, string minutoS)
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
            comando.CommandText = "REGISTRAR_TERAPISTA";
            comando.Connection = con;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = t.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = t.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = t.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = t.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = t.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = t.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value =t.Dni;
            comando.Parameters.Add("_TIPO_TERAPISTA", MySqlDbType.Int32).Value = t.Tipo;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = t.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = t.FechaNac;
            comando.Parameters.Add("_CONTRASENIA", MySqlDbType.VarChar).Value = t.Contrasena;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.Parameters.Add("_SUELDO", MySqlDbType.Double).Value = t.Sueldo;
            String horaEntrada = horaE + ":" + minutoE + ":00";
            TimeSpan hora_E = Convert.ToDateTime(horaEntrada).TimeOfDay;
            comando.Parameters.Add("_HORA_ENTRADA", MySqlDbType.Time).Value = hora_E;
            String horaSalida = horaS + ":" + minutoS + ":00";
            TimeSpan hora_S = Convert.ToDateTime(horaSalida).TimeOfDay;
            comando.Parameters.Add("_HORA_SALIDA", MySqlDbType.Time).Value = hora_S;
            comando.Parameters.Add("_ID3", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void modificarTerapista(Terapista s, string horaE, string horaS, string minutoE, string minutoS)
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
            comando.CommandText = "MODIFICAR_TERAPISTA";
            comando.Connection = con;
            comando.Parameters.Add("_ID_TRABAJADOR", MySqlDbType.Int32).Value = s.IdTrabajador;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = s.IdPersona;
            comando.Parameters.Add("_ID_TERAPISTA", MySqlDbType.Int32).Value = s.IdTerapista;

            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = s.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = s.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = s.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = s.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = s.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = s.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = s.Dni;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = s.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = s.FechaNac;
            comando.Parameters.Add("_CONTRASENIA", MySqlDbType.VarChar).Value = s.Contrasena;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = s.Estado;
            comando.Parameters.Add("_SUELDO", MySqlDbType.Double).Value = s.Sueldo;
            comando.Parameters.Add("_TIPO_TERAPISTA", MySqlDbType.Int32).Value = s.Tipo;
            String horaEntrada = horaE + ":" + minutoE + ":00";
            TimeSpan hora_E = Convert.ToDateTime(horaEntrada).TimeOfDay;
            comando.Parameters.Add("_HORA_ENTRADA", MySqlDbType.Time).Value = hora_E;
            String horaSalida = horaS + ":" + minutoS + ":00";
            TimeSpan hora_S = Convert.ToDateTime(horaSalida).TimeOfDay;
            comando.Parameters.Add("_HORA_SALIDA", MySqlDbType.Time).Value = hora_S;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void registrarTratamiento_X_terapista(Terapista t, Tratamiento trat)
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
            comando.CommandText = "REGISTRAR_TRATAMIENTO_X_TERAPISTA";
            comando.Connection = con;
            comando.Parameters.Add("_ID_TERAPISTA", MySqlDbType.Int32).Value = t.IdTerapista;
            comando.Parameters.Add("_ID_TRABAJADOR", MySqlDbType.Int32).Value = t.IdTrabajador;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = t.IdPersona;
            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = trat.IdTrat;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Tratamiento> listarTratamientos_X_Terapista(int IdTerapista)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TRATAMIENTO_X_TERAPISTA";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Value = IdTerapista;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Tratamiento t = new Tratamiento();
                t.IdTrat = reader.GetInt32("ID_TRATAMIENTO");
                t.NombreServicio = reader.GetString("NOMBRE");
                t.PrecioServicio = reader.GetDouble("PRECIO");
                t.DuracionTrat = reader.GetDouble("DURACION");
                tratamientos.Add(t);
            }
            conexion.Close();
            return tratamientos;
        }

       public BindingList<Terapista> listarTerapistas_X_Tratamiento(int idTratamiento)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Terapista> terapistas = new BindingList<Terapista>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TERAPISTAS_X_TRATAMIENTO";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Value = idTratamiento;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Terapista t = new Terapista();
                t.IdTerapista = reader.GetInt32("ID_TERAPISTA");
                t.Nombres = reader.GetString("NOMBRES");
                t.ApMaterno = reader.GetString("APELLIDO_MATERNO");
                t.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                terapistas.Add(t);
            }
            conexion.Close();
            return terapistas;
        }

        public void modificarTerapista_X_Tratamiento(int id_tratamiento, int id_terapista, int id_trab, int id_per,int estado)
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
            comando.CommandText = "MODIFICAR_TRATAMIENTO_X_TERAPISTA";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_PERSONA_FK", MySqlDbType.Int32).Value = id_per;
            comando.Parameters.Add("_ID_TRABAJADOR_FK", MySqlDbType.Int32).Value = id_trab;
            comando.Parameters.Add("_ID_TERAPISTA_FK", MySqlDbType.Int32).Value = id_terapista;
            comando.Parameters.Add("_ID_TRATAMIENTO_FK", MySqlDbType.Int32).Value = id_tratamiento;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = estado;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public BindingList<Tratamiento> listarTratamientosInactivos(int id_terapista)
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
            comando.CommandText = "LISTAR_TRATAMIENTOS_INACTIVOS_TERAPISTA";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_TERAPISTA_FK", MySqlDbType.Int32).Value = id_terapista;
            MySqlDataReader reader = comando.ExecuteReader();
            BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
            while (reader.Read())
            {
                Tratamiento trat = new Tratamiento();
                trat.IdTrat = reader.GetInt32("ID_TRATAMIENTO_FK");
                tratamientos.Add(trat);
            }
            conexion.Close();
            return tratamientos;
        }

    }
}
