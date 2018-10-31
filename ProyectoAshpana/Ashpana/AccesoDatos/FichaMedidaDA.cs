using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class FichaMedidaDA
    {
        public BindingList<FichaMedida> listarFichaMedidas()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<FichaMedida> fichasMedidas= new BindingList<FichaMedida>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_FICHA_MEDIDAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                FichaMedida f = new FichaMedida();
                f.Fecha = reader.GetDateTime(1);
                double tipoSom = reader.GetDouble(2);
                if (tipoSom == 1) f.Tipo = "ENDOMORFO";
                if (tipoSom == 2) f.Tipo = "ECTOMORFO";
                if (tipoSom == 3) f.Tipo = "MESOMORFO";
                f.Peso = reader.GetDouble(3);
                f.Espalda = reader.GetDouble(4);
                f.AbdomenAlto= reader.GetDouble(5);
                f.AbdomenBajo = reader.GetDouble(6);
                f.Cintura = reader.GetDouble(7);
                f.BrazoDerecho = reader.GetDouble(8);
                f.BrazoIzquierdo = reader.GetDouble(9);
                f.Gluteos = reader.GetDouble(10);
                f.PiernaIzq = reader.GetDouble(11);
                f.PiernaDer = reader.GetDouble(12);
                fichasMedidas.Add(f);
            }
            conexion.Close();
            return fichasMedidas;
        }

        public BindingList<FichaMedida> listarFichaMedidas_X_Cliente(Cliente c)
        {
           string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
          "user=inf282g4;" +
          "password=GvZf6p;" +
          "database=inf282g4;" +
          "port=3306;" +
          "SslMode=none;";
            BindingList<FichaMedida> fichasMedidas = new BindingList<FichaMedida>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "LISTAR_FICHA_MEDIDAS_X_CLIENTE";
            comando.Connection = conexion;
            comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = c.IdCliente;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                FichaMedida f = new FichaMedida();
                f.IdFichaMedida = reader.GetInt32(0);
                f.Fecha = reader.GetDateTime(1);
                double tipoSom = reader.GetDouble(2);
                if (tipoSom == 1) f.Tipo = "ENDOMORFO";
                if (tipoSom == 2) f.Tipo = "ECTOMORFO";
                if (tipoSom == 3) f.Tipo = "MESOMORFO";
                f.Peso = reader.GetDouble(3);
                f.Espalda = reader.GetDouble(4);
                f.AbdomenAlto = reader.GetDouble(5);
                f.AbdomenBajo = reader.GetDouble(6);
                f.Cintura = reader.GetDouble(7);
                f.BrazoDerecho = reader.GetDouble(8);
                f.BrazoIzquierdo = reader.GetDouble(9);
                f.Gluteos = reader.GetDouble(10);
                f.PiernaIzq = reader.GetDouble(11);
                f.PiernaDer = reader.GetDouble(12);
                fichasMedidas.Add(f);
            }
            conexion.Close();
            return fichasMedidas;
        }

        double tipoFM;
        public int registrarFichaMedida(FichaMedida fm)
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
            comando.CommandText = "REGISTRAR_FICHA_MEDIDA";
            comando.Connection = conexion;
            comando.Parameters.Add("_FECHA_REGISTRO", MySqlDbType.DateTime).Value = fm.Fecha;
            if (fm.Tipo == "ENDOMORFO") tipoFM = 1;
            else if (fm.Tipo == "ECTOMORFO") tipoFM = 2;
            else if (fm.Tipo == "MESOMORFO") tipoFM = 3;
            comando.Parameters.Add("_TIPO_SOMATICO", MySqlDbType.VarChar).Value = tipoFM;
            comando.Parameters.Add("_PESO", MySqlDbType.Double).Value = fm.Peso;
            comando.Parameters.Add("_ESPALDA", MySqlDbType.Double).Value = fm.Espalda;
            comando.Parameters.Add("_ABDOMEN_ALTO", MySqlDbType.Double).Value = fm.AbdomenAlto;
            comando.Parameters.Add("_ABDOMEN_BAJO", MySqlDbType.Double).Value = fm.AbdomenBajo;
            comando.Parameters.Add("_CINTURA", MySqlDbType.Double).Value = fm.Cintura;
            comando.Parameters.Add("_BRAZO_DERECHO", MySqlDbType.Double).Value = fm.BrazoDerecho;
            comando.Parameters.Add("_BRAZO_IZQUIERDO", MySqlDbType.Double).Value = fm.BrazoIzquierdo;
            comando.Parameters.Add("_GLUTEOS", MySqlDbType.Double).Value = fm.Gluteos;
            comando.Parameters.Add("_PIERNA_IZQUIERDA", MySqlDbType.Double).Value = fm.PiernaIzq;
            comando.Parameters.Add("_PIERNA_DERECHA", MySqlDbType.Double).Value = fm.PiernaDer;
            comando.Parameters.Add("_ID_FICHA_MEDIDA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            conexion.Close();
            return Int32.Parse(comando.Parameters["_ID_FICHA_MEDIDA"].Value.ToString());
        }

        double tipoSom;
        public int modificarFichaMedida(FichaMedida fm)
        {
            try
            {
                String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g4;" + "password=GvZf6p;" + "database=inf282g4;" + "port=3306;" + "SslMode=none;";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "MODIFICAR_FICHA_MEDIDA";
                comando.Connection = con;

                comando.Parameters.Add("_ID_FICHA_MEDIDA", MySqlDbType.Int32).Value = fm.IdFichaMedida;
                comando.Parameters.Add("_FECHA_REGISTRO", MySqlDbType.DateTime).Value = fm.Fecha;
                if (fm.Tipo == "ENDOMORFO") tipoSom = 1;
                if (fm.Tipo == "ECTOMORFO") tipoSom = 2;
                if (fm.Tipo == "MESOMORFO") tipoSom = 3;
                comando.Parameters.Add("_TIPO_SOMATICO", MySqlDbType.Double).Value = tipoSom;
                comando.Parameters.Add("_PESO", MySqlDbType.Double).Value = fm.Peso;
                comando.Parameters.Add("_ESPALDA", MySqlDbType.Double).Value = fm.Espalda;
                comando.Parameters.Add("_ABDOMEN_ALTO", MySqlDbType.Double).Value = fm.AbdomenAlto;
                comando.Parameters.Add("_ABDOMEN_BAJO", MySqlDbType.Double).Value = fm.AbdomenBajo;
                comando.Parameters.Add("_CINTURA", MySqlDbType.Double).Value = fm.Cintura;
                comando.Parameters.Add("_BRAZO_DERECHO", MySqlDbType.Double).Value = fm.BrazoDerecho;
                comando.Parameters.Add("_BRAZO_IZQUIERDO", MySqlDbType.Double).Value = fm.BrazoIzquierdo;
                comando.Parameters.Add("_GLUTEOS", MySqlDbType.Double).Value = fm.Gluteos;
                comando.Parameters.Add("_PIERNA_IZQUIERDA", MySqlDbType.Double).Value = fm.PiernaIzq;
                comando.Parameters.Add("_PIERNA_DERECHA", MySqlDbType.Double).Value = fm.PiernaDer;


                comando.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
            
        }
    }
}
