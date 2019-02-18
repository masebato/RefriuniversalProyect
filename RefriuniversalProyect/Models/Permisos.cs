using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Permisos
    {
        IDatos con = new Datos();
        string idPERMISO { get; set; }
        string ROL_idROL { get; set; }
        string MENU_idMENU { get; set; }
       

        public Permisos(string rol, string menu)
        {
            this.ROL_idROL = rol;
            this.MENU_idMENU = menu;
        }

        public Permisos()
        {

        }


        public bool InsertarPermiso(Permisos perm)
        {                         
         return  con.OperarDatos("insert into Permiso (ROL_idROL,MENU_idMENU) values ('" + perm.ROL_idROL + "','" + perm.MENU_idMENU + "')");              
        }

        public bool ActualizarPermiso(Permisos perm)
        {
            return con.OperarDatos("delete from Permiso where ROL_idROL = '"+perm.ROL_idROL+ "' and MENU_idMENU= '"+perm.MENU_idMENU+"' ");
        }


        public DataTable ConsultarPermisos(string rol)
        {
          return  con.ConsultarDatos("SELECT menu.idMENU as id, menu.nombreMENU as nombre from permiso inner join rol on permiso.ROL_idROL = rol.idROL INNER JOIN menu ON permiso.MENU_idMENU= menu.idMENU where rol.nombreROL = '"+rol+"'");
        }

    }
}