using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Rol
    {
        IDatos con = new Datos();

        string idROL { get; set; }
        string nombreROL { get; set; }
        string estadoROL { get; set; }


        public DataTable consultarRoles()
        {
            return con.ConsultarDatos("select * from rol where estadoROL='ACTIVO'");
        }
        

        


    }
}