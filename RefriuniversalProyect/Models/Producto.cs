using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.Models;
using RefriuniversalProyect.Conexion;
using RefriuniversalProyect.AccesoDatos.Interface;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Producto
    {


        IDatos con = new Datos();

        string nombPRODUCTO { get; set; }
        string marcPRODUCTO { get;set; }
        string refePRODUCTO { get; set; }

       

        public bool CrearProducto(string nombre, string referencia, string marca)
        {
            return con.OperarDatos("insert into producto (marcPRODUCTO, nombPRODUCTO, refePRODUCTO) values ('"+marca+"','"+nombre+"','"+referencia+"')");
        }

        public DataTable BusquedaPrducto(string busqueda)
        {
            return con.ConsultarDatos("select * from producto WHERE producto.nombPRODUCTO like '%" + busqueda+"%' ");
        }
        
        public DataTable ConsultarProductoReporte(string codReporte)
        {
            return con.ConsultarDatos("SELECT nombPRODUCTO, refePRODUCTO, marcPRODUCTO FROM reporte INNER JOIN reporte_producto ON reporte_producto.REPORTE_idREPORTE = reporte.idREPORTE INNER JOIN producto ON reporte_producto.PRODUCTO_idPRODUCTO= producto.idPRODUCTO WHERE reporte.codiREPORTE ='" + codReporte + "' ");
        }
        
    }

}