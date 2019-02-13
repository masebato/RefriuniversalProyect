using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.Conexion;
using RefriuniversalProyect.AccesoDatos.Interface;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Tecnico
    {
        IDatos con = new Datos();

        string idTECNICO { get; set; }
        string nombTECNICO { get; set; }
        string apelTECNICO { get; set; }


        public Tecnico()
        {

        }

        public DataTable ConsultarTodosTecnicos()
        {
            return con.ConsultarDatos("select * from tecnico");
        }




    }
}