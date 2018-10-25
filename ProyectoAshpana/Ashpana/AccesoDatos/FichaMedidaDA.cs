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
    }
}
