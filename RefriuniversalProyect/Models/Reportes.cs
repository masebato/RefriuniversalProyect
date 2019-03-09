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

        public DataTable ReporteMaxid()
        {
            return con.ConsultarDatos("select max(idREPORTE)+1 AS reporte  from reporte");
        }

        public DataTable ConsultarArticulosReportes(string idorden)
        {
            return con.ConsultarDatos("SELECT codiREPORTE, fechaREPORTE,nombreTIPOARTICULO, refeARTICULO FROM ORdenservicio INNER JOIN reporte ON reporte.ORDENSERVICIO_idORDENSERVICIO = ordenservicio.idORDENSERVICIO INNER JOIN articulo ON reporte.ARTICULO_idARTICULO = articulo.idARTICULO INNER JOIN tipo_articulo ON articulo.TIPO_ARTICULO_idTIPO_ARTICULO= tipo_articulo.idTIPO_ARTICULO WHERE idORDENSERVICIO='"+idorden+"'");
        }

         public DataTable consultarrepuestosorden(string codireporte)
        {
            return con.ConsultarDatos("SELECT descREPORTE, NombPRODUCTO, cantidadREPORTE_PRODUCTO FROM REPORTE INNER JOIN reporte_producto ON reporte_producto.REPORTE_idREPORTE = reporte.idREPORTE INNER JOIN producto ON reporte_producto.PRODUCTO_idPRODUCTO = producto.idPRODUCTO WHERE codireporte = '" + codireporte + "'");
        }
    }
}