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
       

        public bool InsertarPermiso(List<Permisos> list_permisos)
        {
            try
            {
                foreach (var item in list_permisos)
                {
                    con.OperarDatos("insert into Permisos (ROL_idROL,MENU_idMENU) values ('" + item.ROL_idROL + "','" + item.MENU_idMENU + "')");
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
          
            
            
        }


        public DataTable ConsultarPermisos(string rol)
        {
          return  con.ConsultarDatos("SELECT menu.idMENU as id, menu.nombreMENU as nombre from permiso inner join rol on permiso.ROL_idROL = rol.idROL INNER JOIN menu ON permiso.MENU_idMENU= menu.idMENU where rol.nombreROL = '"+rol+"'");
        }

    }
}