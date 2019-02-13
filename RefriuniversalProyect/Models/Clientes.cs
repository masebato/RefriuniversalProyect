using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.Conexion;
using System.Data;
using RefriuniversalProyect.AccesoDatos.Interface;

namespace RefriuniversalProyect.Models
{
    public class Clientes
    {
        IDatos con = new Datos(); 

        string nombCLIENTE { get; set; }
        string apelCLIENTE { get; set; }
        string docuCLIENTE { get; set; }
        string direCLIENTE { get; set; }
        string corrCLIENTE { get; set; }
        string teleCLIENTE { get; set; }

        public Clientes()
        {

        }

        public Clientes( string nombCLIENTE, string apelCLIENTE, string docuCLIENTE, string direCLIENTE, string corrCLIENTE, string teleCLIENTE)
        {
            this.nombCLIENTE = nombCLIENTE;
            this.apelCLIENTE = apelCLIENTE;
            this.docuCLIENTE = docuCLIENTE;
            this.direCLIENTE = direCLIENTE;
            this.corrCLIENTE = corrCLIENTE;
            this.teleCLIENTE = teleCLIENTE;
        }


        


       public bool CrearCliente(Clientes cl)
        {
            return con.OperarDatos(" insert into cliente(nombCLIENTE, apellCLIENTE, docuCLIENTE, direCLIENTE, corrCLIENTE, teleCLIENTE) values('"+cl.nombCLIENTE+ "','" + cl.apelCLIENTE + "','" + cl.docuCLIENTE + "','" + cl.direCLIENTE + "','" + cl.corrCLIENTE + "','" + cl.teleCLIENTE + "')");
        }

        public DataTable ConsultarTodosLosClientes()
        {

            return con.ConsultarDatos("select * from cliente");

        }











    }



}