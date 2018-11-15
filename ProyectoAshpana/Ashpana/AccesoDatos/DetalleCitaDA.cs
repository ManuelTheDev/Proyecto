using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DetalleCitaDA
    {
        public int registrarDetalleCita(DetalleCita dt, int idCita)
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
                comando.CommandText = "REGISTRAR_DETALLE_CITA";
                comando.Connection = con;
                comando.Parameters.Add("_ID_CITA", MySqlDbType.Int32).Value = idCita;
                comando.Parameters.Add("_ID_SERVICIO", MySqlDbType.VarChar).Value = dt.Servicio.IdServicio;
                comando.Parameters.Add("_ID_DETALLE_CITA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.ExecuteNonQuery();
                con.Close();
                int idDetalleCita = Convert.ToInt32(comando.Parameters["_ID_DETALLE_CITA"].Value);
                return idDetalleCita;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
