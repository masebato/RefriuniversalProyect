using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;


namespace RefriuniversalProyect.Conexion
{
    public class Conexion
    {
        private static MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        
        //Metodo de conexión con mysql
        protected static MySqlConnection Conectar()
        {
            try
            {
                conexion.Open();
            }
            catch
            {
                conexion.Close();
                conexion.Open();
            }
            return conexion;
        }

        //Metodo de desconectar MySql
        protected static void Desconector()
        {
            conexion.Close();
        }


    }
}