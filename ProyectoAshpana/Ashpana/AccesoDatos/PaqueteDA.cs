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
                    int cantSesiones = lector.GetInt32("CANTIDAD_SESIONES");
                    int id = lector.GetInt32("ID_PAQUETE");
                    Paquete paquete = new Paquete();
                    paquete.IdPaquete = id;
                    paquete.Nombre = nombre;
                    paquete.Precio = precio;
                    paquete.CantSesion = cantSesiones;
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
                MySqlCommand comPaquete = new MySqlCommand("call EliminarPaquete(@id);", conexion);
                comPaquete.Parameters.AddWithValue("@id", p.IdPaquete);
                comPaquete.Prepare();
                comPaquete.ExecuteNonQuery();
                conexion.Clone();
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
                MySqlCommand comPaquete = new MySqlCommand("call BuscarPaquetes(@busqueda);", conexion);
                comPaquete.Parameters.AddWithValue("@busqueda", busqueda);
                comPaquete.Prepare();

                MySqlDataReader lector = comPaquete.ExecuteReader();

                while (lector.Read())
                {
                    String nombre = lector.GetString("NOMBRE");
                    double precio = lector.GetDouble("PRECIO");
                    int cantSesiones = lector.GetInt32("CANTIDAD_SESIONES");
                    int id = lector.GetInt32("ID_PAQUETE");
                    Paquete paquete = new Paquete();
                    paquete.IdPaquete = id;
                    paquete.Nombre = nombre;
                    paquete.Precio = precio;
                    paquete.CantSesion = cantSesiones;
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

        public int RegistrarPaquetes(Paquete p) //, BindingList<Tratamiento> tratamientos)
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
                comando.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = p.Nombre;
                comando.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = p.Precio;
                comando.Parameters.Add("_NUM_SESIONES", MySqlDbType.Int32).Value = p.CantSesion;
                comando.Parameters.Add("_ID", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                conexion.Close();

                return Int32.Parse(comando.Parameters["_ID"].Value.ToString());
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
                //Se conecta con la BD
                conexion.Open();
                //Se prepara el query

                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "REGISTRAR_PAQUETE_X_TRATAMIENTO";
                comando.Connection = conexion;
                comando.Parameters.Add("_ID_PAQUETE", MySqlDbType.Int32).Value = idPaqu;
                comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = trat.IdTrat;
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
                // Se conecta con la BD
                conexion.Open();
                //Se prepara el query
                MySqlCommand comPaquete = new MySqlCommand("call ActualizarPaquete(@id,@Nombre,@Precio,@CantSesion);", conexion);
                comPaquete.Parameters.AddWithValue("@id", p.IdPaquete);
                comPaquete.Parameters.AddWithValue("@Nombre", p.Nombre);
                comPaquete.Parameters.AddWithValue("@Precio", p.Precio);
                comPaquete.Parameters.AddWithValue("@CantSesion", p.CantSesion);
                comPaquete.Prepare();

                comPaquete.ExecuteNonQuery();
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
