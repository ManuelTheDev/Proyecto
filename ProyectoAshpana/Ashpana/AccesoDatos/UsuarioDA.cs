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
    public class UsuarioDA
    {
        public BindingList<Superusuario> listarSuperusuarios()
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                      "user=inf282g4;" +
                      "password=GvZf6p;" +
                      "database=inf282g4;" +
                      "port=3306;" +
                      "SslMode=none;";

            BindingList<Superusuario> usuarios = new BindingList<Superusuario>();
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_SUPERUSUARIOS";
            comando.Connection = conexion;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Superusuario s = new Superusuario();
                s.IdPersona = reader.GetInt32("ID_PERSONA");
                s.IdTrabajador = reader.GetInt32("ID_TRABAJADOR");
                s.IdSuperusuario = reader.GetInt32("ID_SUPERUSUARIO"); 
                s.Dni = reader.GetString("DNI");
                s.Nombres = reader.GetString("NOMBRES");
                s.ApPaterno = reader.GetString("APELLIDO_PATERNO");
                s.ApMaterno= reader.GetString("APELLIDO_MATERNO");
                s.Correo = reader.GetString("CORREO");
                s.Direccion = reader.GetString("DIRECCION");
                s.Telefono = reader.GetString("TELEFONO");
                s.Sueldo = reader.GetDouble("SUELDO");
                s.Estado = reader.GetInt32("ESTADO");
                s.Sexo = reader.GetChar("SEXO");
                s.FechaNac = reader.GetDateTime("FECHA_NACIMIENTO");
                s.Contrasena = reader.GetString("CONTRASENIA");
                usuarios.Add(s);
            }
            conexion.Close();
            return usuarios;
        }

        public void registrarSuperusuario (Superusuario s)
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
            comando.CommandText = "REGISTRAR_SUPERUSUARIO";
            comando.Connection = con;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value =s.Nombres;
            comando.Parameters.Add("_APELLIDO_PATERNO", MySqlDbType.VarChar).Value = s.ApPaterno;
            comando.Parameters.Add("_APELLIDO_MATERNO", MySqlDbType.VarChar).Value = s.ApMaterno;
            comando.Parameters.Add("_DIRECCION", MySqlDbType.VarChar).Value = s.Direccion;
            comando.Parameters.Add("_TELEFONO", MySqlDbType.VarChar).Value = s.Telefono;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = s.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = s.Dni;
            comando.Parameters.Add("_CORREO", MySqlDbType.VarChar).Value = s.Correo;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = s.FechaNac;
            comando.Parameters.Add("_CONTRASENIA", MySqlDbType.VarChar).Value = s.Contrasena;
            comando.Parameters.Add("_ESTADO", MySqlDbType.Int32).Value = 1;
            comando.Parameters.Add("_SUELDO", MySqlDbType.Double).Value = s.Sueldo;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void modificarUsuario(Superusuario s)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=inf282g4;" +
                    "password=GvZf6p;" +
                    "database=inf282g4;" +
                     "port=3306;" +
                     "SslMode=none;";

            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comandoAux = new MySqlCommand("SELECT ID_PERSONA FROM PERSONA WHERE DNI = " + s.Dni, con);
            MySqlDataReader reader = null;
            reader = comandoAux.ExecuteReader();
            reader.Read();
            int id_superusuario = reader.GetInt32(0);
            reader.Dispose();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_SUPERUSUARIO";
            comando.Connection = con;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Value = id_superusuario;
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
            comando.ExecuteNonQuery();
            con.Close();
        }

    }
}
