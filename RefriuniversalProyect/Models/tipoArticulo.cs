using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;

namespace RefriuniversalProyect.Models
{
    public class tipoArticulo
    {
        IDatos con = new Datos();
        string nombreTIPOARTICULO { get; set; }
        string estadoTIPOARTICULO { get; set; }


        public DataTable consultarTipoArticulo()
        {
            return con.ConsultarDatos("select * from tipo_articulo");
        }
        
        public bool crearTipo(string nombre)
        {
            return con.OperarDatos("insert into tipo_articulo (nombreTIPOARTICULO, estadoTIPOARTICULO) values ('"+nombre+"','ACTIVO')");
        }

        public bool Actualizartipo(string id, string nombre, string estado)
        {
            return con.OperarDatos("update tipo_articulo set nombreTIPOARTICULO='" + nombre + "', estadoTIPOARTICULO='" + estado + "' where idTIPO_ARTICULO='" + id + "'");
        }

    }
}