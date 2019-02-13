using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;

namespace RefriuniversalProyect.Models
{

    public class Reportes
    {
        IDatos con = new Datos();
        
        string idREPORTE { get; set; }
        string codiREPORTE { get; set; }
        string descREPORTE { get; set; }
        string fechaREPORTE { get; set; }
        string ordenREPORTE { get; set; }
        string articuloREPORTE { get; set; }


        public Reportes()
        {

        }


        public Reportes(string codireporte, string descreporte, string fechareporte, string ordenreporte)
        {
            this.codiREPORTE = codireporte;
            this.descREPORTE = descreporte;
            this.fechaREPORTE = fechareporte;
            this.ordenREPORTE = ordenreporte;
           


        }

        public bool insertarReporte(Reportes repor)
        {
            return con.OperarDatos("insert into reporte (codiREPORTE, descREPORTE, fechaREPORTE, ORDENSERVICIO_idORDENSERVICIO, ARTICULO_idARTICULO) values ('"+repor.codiREPORTE+"','"+repor.descREPORTE+"','"+repor.fechaREPORTE+"','"+repor.ordenREPORTE+"',(select MAX(idARTICULO) from articulo))");
        }

    }
}