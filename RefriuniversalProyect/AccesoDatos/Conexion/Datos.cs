using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;


namespace RefriuniversalProyect.Conexion
{
    public class Datos: Conexion, IDatos
    {
        //Realizar operaciones en la base de datos
        public bool OperarDatos(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, Conectar());
                if (comando.ExecuteNonQuery() > 0)
                {
                    Desconector();
                    return true;
                }
                return false;
            }
            catch
            {
                Desconector();
                return false;
            }
        }

        //Realizar consulta en la base de datos.
        public DataTable ConsultarDatos(string sql)
        {
            DataTable datos = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conectar());
                da.Fill(datos);
                Desconector();
                return datos;
            }
            catch
            {
                Desconector();
                return null;
            }
        }

        
    }
}