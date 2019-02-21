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
            return con.ConsultarDatos("SELECT tipodocumento.idTIPODOCUMENTO, tipodocumento.nombreTIPODOCUMENTO from tipodocumento"); 
        }


        
    }
}