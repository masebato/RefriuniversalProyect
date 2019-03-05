using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.Conexion;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;

namespace RefriuniversalProyect.Models
{
    public class TipoDocumento
    {
        IDatos con = new Datos();
        string nombreTIPODOCUMENTO { get; set; }
        string estadoTIPODOCUMENTO { get; set; }


        public TipoDocumento()
        {

        }

        public TipoDocumento(string nombre, string estado)
        {
            this.nombreTIPODOCUMENTO = nombre;
            this.estadoTIPODOCUMENTO = estado;
        }

        public DataTable consultartipoDdocu()
        {
            return con.ConsultarDatos("SELECT idTIPODOCUMENTO, nombreTIPODOCUMENTO, estadoTIPODOCUMENTO from tipodocumento"); 
        }

        public bool InsertartipoDocu(string nombre)
        {
            return con.OperarDatos("insert into tipodocumento (nombreTIPODOCUMENTO, estadoTIPODOCUMENTO) values ('" + nombre + "','ACTIVO')");
        }

        public bool ActualizarTipodocu(string nombre, string id, string estado)
        {
            return con.OperarDatos("update tipodocumento set nombreTIPODOCUMENTO='"+nombre+"', estadoTIPODOCUMENTO='"+estado+"' where idTIPODOCUMENTO = '"+id+"'");
        }

    }
}