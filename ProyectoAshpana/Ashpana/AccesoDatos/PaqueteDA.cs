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
    public class PaqueteDA
    {
        public BindingList<Paquete> listarPaquetes()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                     "user=inf282g4;" +
                     "password=GvZf6p;" +
                     "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection conexion = new MySqlConnection(cadena);
            BindingList<Paquete> paquetes = new BindingList<Paquete>();
            try
            {

                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_PAQUETES";
                comando.Connection = conexion;

                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    String nombre = lector.GetString("NOMBRE");
                    double precio = lector.GetDouble("PRECIO");
                    int cantSesiones = lector.GetInt32("NUM_SESIONES");
                    int id = lector.GetInt32("ID_PAQUETE");
                    Paquete paquete = new Paquete();
                    paquete.IdPaquete = id;
                    paquete.NombreServicio = nombre;
                    paquete.PrecioServicio = precio;
                    paquete.NumSesiones = cantSesiones;
                    paquete.IdServicio = lector.GetInt32("ID_SERVICIO_FK");
                    paquetes.Add(paquete);
                }
                conexion.Close();
                return paquetes;

            }
            catch (Exception e)
            {
                return null;
            }
        }


        public int eliminar(Paquete p)
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
                MySqlCommand comPaquete = new MySqlCommand();
                comPaquete.CommandType = System.Data.CommandType.StoredProcedure;
                comPaquete.CommandText = "MODIFICAR_PAQUETE";
                comPaquete.Connection = conexion;
                comPaquete.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = p.IdPaquete;
                comPaquete.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = p.NombreServicio;
                comPaquete.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = p.PrecioServicio;
                comPaquete.Parameters.Add("_NUM_SESIONES", MySqlDbType.Int32).Value = p.NumSesiones;
                comPaquete.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 0;

                comPaquete.ExecuteNonQuery();
                conexion.Close();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public BindingList<Paquete> BuscarPaquete(String busqueda)
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
                BindingList<Paquete> paquetes = new BindingList<Paquete>();
                // Se conecta con la BD
                conexion.Open();
                //Se prepara el query
                MySqlCommand comPaquete = new MySqlCommand("call BUSCAR_PAQUETES(@busqueda);", conexion);
                comPaquete.Parameters.AddWithValue("@busqueda", busqueda);
                comPaquete.Prepare();

                MySqlDataReader lector = comPaquete.ExecuteReader();

                while (lector.Read())
                {
                    String nombre = lector.GetString("NOMBRE");
                    double precio = lector.GetDouble("PRECIO");
                    int cantSesiones = lector.GetInt32("NUM_SESIONES");
                    int id = lector.GetInt32("ID_PAQUETE");
                    Paquete paquete = new Paquete();
                    paquete.IdPaquete = id;
                    paquete.NombreServicio = nombre;
                    paquete.PrecioServicio = precio;
                    paquete.NumSesiones = cantSesiones;
                    paquetes.Add(paquete);
                }
                conexion.Clone();
                return paquetes;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int RegistrarPaquetes(Paquete p)
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
                comando.CommandText = "REGISTRAR_PAQUETE";
                comando.Connection = conexion;
                comando.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = p.NombreServicio;
                comando.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = p.PrecioServicio;
                comando.Parameters.Add("_NUM_SESIONES", MySqlDbType.Int32).Value = p.NumSesiones;
                comando.Parameters.Add("_ID_SERVICIO", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.ExecuteNonQuery();
                conexion.Close();

                return Int32.Parse(comando.Parameters["_ID_PAQUETE"].Value.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int RegistrarPaqueteXTratamiento(int idPaqu, Tratamiento trat)
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
                comando.CommandText = "REGISTRAR_PAQUETE_X_TRATAMIENTO";
                comando.Connection = conexion;
                comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = idPaqu;
                comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = trat.IdTrat;
                comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
                comando.ExecuteNonQuery();
                conexion.Close();

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }



        public int actualizar(Paquete p)
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
                MySqlCommand comPaquete = new MySqlCommand();
                comPaquete.CommandType = System.Data.CommandType.StoredProcedure;
                comPaquete.CommandText = "MODIFICAR_PAQUETE";
                comPaquete.Connection = conexion;
                comPaquete.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = p.IdPaquete;
                comPaquete.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = p.NombreServicio;
                comPaquete.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = p.PrecioServicio;
                comPaquete.Parameters.Add("_NUM_SESIONES", MySqlDbType.Int32).Value = p.NumSesiones;
                comPaquete.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = p.EstadoServicio;

                comPaquete.ExecuteNonQuery();
                conexion.Close();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public BindingList<Tratamiento> listarPaqueteXTratamiento(int idPaquete)
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
            comando.CommandText = "LISTAR_PAQUETE_X_TRATAMIENTO";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = idPaquete;
            MySqlDataReader reader = comando.ExecuteReader();
            BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
            while (reader.Read())
            {
                Tratamiento trat = new Tratamiento();
                trat.NombreServicio = reader.GetString(0);
                trat.PrecioServicio = reader.GetDouble(1);
                trat.DuracionTrat = reader.GetInt32(2);
                trat.TipoTrat = reader.GetInt32(3);
                trat.IdTrat = reader.GetInt32(4);
                tratamientos.Add(trat);
            }
            conexion.Close();
            return tratamientos;
        }

        public void actualizarPaquete_X_Tratamiento(int id_paquete,int id_tratamiento,int estado)
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
            comando.CommandText = "MODIFICAR_TRATAMIENTO_X_PAQUETE";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = id_paquete;
            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = id_tratamiento;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = estado;
            comando.ExecuteNonQuery();
            conexion.Close();
        } 

        public BindingList<Tratamiento> listarTratamientosInactivos(int id_paquete)
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
            comando.CommandText = "LISTAR_TRATAMIENTOS_INACTIVOS";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = id_paquete;
            MySqlDataReader reader = comando.ExecuteReader();
            BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
            while (reader.Read())
            {
                Tratamiento trat = new Tratamiento();
                trat.IdTrat = reader.GetInt32(0);
                tratamientos.Add(trat);
            }
            conexion.Close();
            return tratamientos;
        }
    }
}
