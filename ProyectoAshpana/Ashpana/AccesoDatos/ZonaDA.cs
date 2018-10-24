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
    public class ZonaDA
    {
        public BindingList<Zona> listarZonas()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Zona> zonas = new BindingList<Zona>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_ZONAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Zona z = new Zona();
                z.IdZona= reader.GetInt32(0);
                z.NombreZona = reader.GetString(1);
                z.DescripicionZona = reader.GetString(2);
                zonas.Add(z);
            }
            conexion.Close();
            return zonas;
        }

        public void registrarZona_X_Tratamiento(int id_tratamiento, Zona z)
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
            comando.CommandText = "REGISTRAR_ZONA_X_TRATAMIENTO";
            comando.Connection = con;
            comando.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.VarChar).Value = id_tratamiento;
            comando.Parameters.Add("_ID_ZONA", MySqlDbType.VarChar).Value = z.IdZona;
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
