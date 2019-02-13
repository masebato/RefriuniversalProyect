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
        string nombARTICULO { get; set; }
        string refeARTICULO { get; set; }
        string tipoARTICULO { get; set; }
        string marcaARTICULO { get; set; }



        public Articulo()
        {

        }

        public Articulo(string nombARTICULO, string refeARTICULO, string tipoARTICULO, string marcaARTICULO )
        {
            this.nombARTICULO = nombARTICULO;
            this.refeARTICULO = refeARTICULO;
            this.tipoARTICULO = tipoARTICULO;
            this.marcaARTICULO = marcaARTICULO;
        }

        public bool insertarArticulo(Articulo arti)
        {
            return con.OperarDatos("insert into articulo (nombARTICULO, refeARTICULO, tipoARTICULO, marcaARTICULO) values ('"+arti.nombARTICULO+"','"+arti.refeARTICULO+"','"+arti.tipoARTICULO+"','"+arti.marcaARTICULO+"')");
        }


    }
}