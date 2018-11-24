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
    public class CitaDA
    {

        public int registrarCita(Cita c)
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
                comando.CommandText = "REGISTRAR_CITA";
                comando.Connection = con;
                comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
               // comando.Parameters.Add("_FECHA_REGISTRO", MySqlDbType.VarChar).Value = c.FechaRegistro;
                comando.Parameters.Add("_MONTO", MySqlDbType.Double).Value = c.MontoTotal;
                comando.Parameters.Add("_ID_CLIENTE", MySqlDbType.Int32).Value = c.Cliente.IdCliente;
                comando.Parameters.Add("_ESTADO_PAGO", MySqlDbType.Int32).Value = c.Estado_pago;
                comando.Parameters.Add("_ID_CITA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.ExecuteNonQuery();
                con.Close();
                int idCita = Convert.ToInt32(comando.Parameters["_ID_CITA"].Value);
                return idCita;
            }catch(Exception ex)
            {
                return 0; 
            }
        }

        public BindingList<Cita> listarCitas()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Cita> citas = new BindingList<Cita>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CITAS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cita c = new Cita();
                c.IdCita = reader.GetInt32("ID_CITA");
                c.FechaRegistro= reader.GetDateTime("FECHA_REGISTRO");
                c.Estado_pago = reader.GetInt32("ESTADO_PAGO");
                c.MontoTotal= reader.GetDouble("MONTO");
                c.Estado = reader.GetInt32("ESTADO");
                if (c.Estado_pago == 0)
                {
                    c.TipoEstado_pago = "PENDIENTE";
                }
                else
                {
                    c.TipoEstado_pago = "PAGADO";
                }
                Cliente p = new Cliente();
                p.IdPersona = reader.GetInt32("ID_PERSONA");
                p.IdCliente = reader.GetInt32("ID_CLIENTE");
                p.Nombres = reader.GetString("NOMBRES");
                p.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                p.ApMaterno = reader.GetString("APELLIDO_MATERNO");

                c.Cliente = p;

                citas.Add(c);
            }
            conexion.Close();
            return citas;
        }
    }
}
