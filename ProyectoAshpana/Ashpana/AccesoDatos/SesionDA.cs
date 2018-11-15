using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SesionDA
    {
        public int registrarSesion(Sesion s, int idDetalleCita, int idCita)
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
                comando.Parameters.Add("_FECHA_SESION", MySqlDbType.Datetime).Value = s.FechaSesion;
                comando.Parameters.Add("_ID_TERAPISTA", MySqlDbType.Int32).Value = s.Terapista.IdTerapista;
                comando.Parameters.Add("_ID_SERVICIO", MySqlDbType.Int32).Value = s.Servicio.IdServicio;
                comando.Parameters.Add("_NUM_SESION", MySqlDbType.Int32).Value = s.NumDeSesion;
                comando.Parameters.Add("_ID_DETALLE_CITA", MySqlDbType.Int32).Value =idDetalleCita ;
                comando.Parameters.Add("_ID_CITA", MySqlDbType.Int32).Value = idCita;
                comando.ExecuteNonQuery();
                con.Close();
              
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
