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

        public DataTable consultarArticulos(string busqueda)
        {
            return con.ConsultarDatos("SELECT codiREPORTE, descREPORTE, fechaREPORTE, codiORDENSERVICIO, fechaORDENSERVICIO, refeARTICULO, nombreTIPOARTICULO, nombPRODUCTO, cantidadREPORTE_PRODUCTO FROM ordenservicio INNER JOIN REPORTE ON reporte.ORDENSERVICIO_idORDENSERVICIO= ordenservicio.idORDENSERVICIO INNER JOIN reporte_PRODUCTO ON reporte_producto.REPORTE_idREPORTE =reporte.idREPORTE INNER JOIN producto ON reporte_producto.PRODUCTO_idPRODUCTO = producto.idPRODUCTO INNER JOIN articulo ON reporte.ARTICULO_idARTICULO = articulo.idARTICULO INNER JOIN tipo_articulo ON articulo.TIPO_ARTICULO_idTIPO_ARTICULO = tipo_articulo.idTIPO_ARTICULO WHERE articulo.refeARTICULO  LIKE '%"+busqueda+ "%';");
        }

    }
}