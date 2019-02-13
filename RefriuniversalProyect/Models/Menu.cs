using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;


namespace RefriuniversalProyect.Models
{
    public class Menu
    {
        IDatos con = new Datos();
        string idMENU { get; set; }
        string nombreMENU { get; set; }
        string rutaMENU { get; set; }


        public DataTable ConsultarMenu()
        {
            return con.ConsultarDatos("select idMenu as menuid, nombreMENU as menunombre from menu");
        }





    }
}