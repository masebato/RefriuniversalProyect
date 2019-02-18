using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.AccesoDatos.Interface;
using RefriuniversalProyect.Conexion;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Login
    {

        IDatos con = new Datos();
        string idLOGIN { get; set; }
        string userLOGIN { get; set; }
        string passLOGIN { get; set; }




        public Login(string userLOGIN, string passLOGIN)
        {
            this.userLOGIN = userLOGIN;
            this.passLOGIN = passLOGIN;

        }
        public Login()
        {

        }

        public DataTable ConsultarLoginTecnico(Login log)
        {
            return con.ConsultarDatos("select nombTECNICO, apelTECNICO, nombreROL from tecnico inner join login on tecnico.LOGIN_idLOGIN = rol.idLOGIN inner join rol on login.ROL_idROL = idROL where login.userLOGIN = '" + log.userLOGIN+"' and login.passLOGIN = '"+log.passLOGIN+"'");
        }

        public DataTable consultarLogin(Login log)
        {
            return con.ConsultarDatos("select userLOGIN, nombreROL from login inner join rol on login.ROL_idROL = rol.idROL where login.userLOGIN = '" + log.userLOGIN+"' and login.passLOGIN= '"+log.passLOGIN+"' ");
        }

        public DataTable ConsultarMenu(string rol)
        {
            return con.ConsultarDatos("SELECT menu.idMENU, menu.nombreMENU, menu.rutaMENU FROM menu INNER JOIN permiso ON permiso.MENU_idMENU = menu.idMENU INNER JOIN rol ON permiso.ROL_idROL = rol.idROL WHERE rol.nombreROL = '"+rol+"'");
        }
    }
}