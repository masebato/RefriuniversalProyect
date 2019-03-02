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
    public class OrdenServicio
    {

        IDatos con = new Datos();
        
        
        string idORDENSERVICIO { get; set; }
        string descORDENSERVICIO { get; set; }
        string codiORDENSERVICIO { get; set; }
        string fechaORDENSERVICIO { get; set; }
        string estadoORDENSERVICIO { get; set; }
        string clienteORDENSERVICIO { get; set; }
        string tecnicoORDENSERVICIO { get; set; }
        string productoORDENSERVICIO { get; set; }


        public OrdenServicio()
        {

        }

        public OrdenServicio( string descORDENSERVICIO, string codiORDENSERVICIO, string fechaORDENSERVICIO, string estadoORDENSERVICIO, string clienteORDENSERVICIO, string tecnicoORDENSERVICIO)
        {
           
            this.descORDENSERVICIO = descORDENSERVICIO;
            this.codiORDENSERVICIO = codiORDENSERVICIO;
            this.fechaORDENSERVICIO = fechaORDENSERVICIO;
            this.estadoORDENSERVICIO = estadoORDENSERVICIO;
            this.clienteORDENSERVICIO = clienteORDENSERVICIO;
            this.tecnicoORDENSERVICIO = tecnicoORDENSERVICIO;
          

        }




        public bool insertarOrden(OrdenServicio orden)
        {
            return con.OperarDatos("insert into ordenservicio (descORDENSERVICIO,codiORDENSERVICIO,fechaORDENSERVICIO,estadoORDENSERVICIO,CLIENTE_idCLIENTE,TECNICO_idTECNICO) values('" + orden.descORDENSERVICIO+"','"+orden.codiORDENSERVICIO+"', '"+orden.fechaORDENSERVICIO+"','ACTIVO','"+orden.clienteORDENSERVICIO+"','"+orden.tecnicoORDENSERVICIO+"')");
        }

        public  DataTable ConsultarOrden(string codigo)
        {
            return con.ConsultarDatos("SELECT idORDENSERVICIO, descORDENSERVICIO, codiORDENSERVICIO, fechaORDENSERVICIO, estadoORDENSERVICIO, CONCAT(nombCLIENTE,' ',apellCLIENTE) AS nombrecliente, CONCAT(nombTECNICO, ' ', apelTECNICO) AS nombretecnico   FROM ordenservicio INNER JOIN cliente ON ordenservicio.CLIENTE_idCLIENTE = cliente.idCLIENTE INNER JOIN tecnico ON ordenservicio.TECNICO_idTECNICO = tecnico.idTECNICO WHERE ordenservicio.codiORDENSERVICIO='" + codigo+"'");
        }

        public DataTable OrdenPorFecha(string fechaini, string fechafin)
        {
            return con.ConsultarDatos("SELECT idORDENSERVICIO, codiORDENSERVICIO, fechaORDENSERVICIO, CONCAT(nombCLIENTE,' ',apellCLIENTE) AS nombres, estadoORDENSERVICIO FROM ordenservicio INNER JOIN CLIENTE ON ordenservicio.CLIENTE_idCLIENTE= cliente.idCLIENTE WHERE ordenservicio.fechaORDENSERVICIO BETWEEN '" + fechaini + "' AND '" + fechafin + "'");
        }

        public DataTable MaxId()
        {
            return con.ConsultarDatos("select max(idORDENSERVICIO)+1 AS orden  from ordenservicio");
        }

    }
}