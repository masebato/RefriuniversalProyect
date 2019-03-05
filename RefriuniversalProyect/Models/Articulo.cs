using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;

namespace RefriuniversalProyect.Models
{
    public class Articulo
    {
        IDatos con = new Datos();
        string idARTICULO { get; set; }
        
        string refeARTICULO { get; set; }
        string tipoARTICULO { get; set; }
        



        public Articulo()
        {

        }

        public Articulo( string refeARTICULO, string tipoARTICULO )
        {
           
            this.refeARTICULO = refeARTICULO;
            this.tipoARTICULO = tipoARTICULO;
           
        }

        public bool insertarArticulo(Articulo arti)
        {
            return con.OperarDatos("insert into articulo ( refeARTICULO, TIPO_ARTICULO_idTIPO_ARTICULO) values ('" + arti.refeARTICULO+"','"+arti.tipoARTICULO+"')");
        }


    }
}