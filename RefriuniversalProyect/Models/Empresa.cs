using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;

namespace RefriuniversalProyect.Models
{
    public class Empresa
    {
        IDatos con = new Datos();
        string nombEMPRESA { get; set; }
        string nitEMPRESA { get; set; }
        string logoEMPRESA { get; set; }

        

        public bool ActualizarEmpresa(string nombre, string nit, string logo)
        {
            return con.OperarDatos("update empresa set nombreEMPRESA='"+nombre+"', nitEMPRESA = '"+nit+"', logoEMPRESA = '"+logo+"' where idEMPRESA=1  ");
        }

        public DataTable ConsultarEmpresa()
        {
            return con.ConsultarDatos("select * from empresa");
        }


        


    }
}