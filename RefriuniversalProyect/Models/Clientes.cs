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
        string tipoDocuCLIENTE { get; set; }
        

        public Clientes()
        {

        }

        public Clientes( string nombCLIENTE, string apelCLIENTE, string docuCLIENTE, string direCLIENTE, string corrCLIENTE, string teleCLIENTE, string docu)
        {
            this.nombCLIENTE = nombCLIENTE;
            this.apelCLIENTE = apelCLIENTE;
            this.docuCLIENTE = docuCLIENTE;
            this.direCLIENTE = direCLIENTE;
            this.corrCLIENTE = corrCLIENTE;
            this.teleCLIENTE = teleCLIENTE;
            this.tipoDocuCLIENTE = docu;
        }


        


       public bool CrearCliente(Clientes cl)
        {
            return con.OperarDatos(" insert into cliente(nombCLIENTE, apellCLIENTE, docuCLIENTE, direCLIENTE, corrCLIENTE, teleCLIENTE, TIPODOCUMENTO_idTIPODOCUMENTO) values('" + cl.nombCLIENTE+ "','" + cl.apelCLIENTE + "','" + cl.docuCLIENTE + "','" + cl.direCLIENTE + "','" + cl.corrCLIENTE + "','" + cl.teleCLIENTE + "', '"+cl.tipoDocuCLIENTE+"')");
        }

        public DataTable ConsultarTodosLosClientes()
        {

            return con.ConsultarDatos("select * from cliente");

        }

        public DataTable Consultarclientes(string valor)
        {
            return con.ConsultarDatos("select * from cliente WHERE cliente.nombCLIENTE like '%" + valor + "%' OR cliente.docuCLIENTE like '%" + valor + "%' ");
        }


        public DataTable ConsultarOrdenDETALLECliente(string idcliente)
        {
            return con.ConsultarDatos("SELECT CONCAT(nombCLIENTE,' ', apellCLIENTE) AS nombre, codiREPORTE, descREPORTE, fechaREPORTE, codiORDENSERVICIO, fechaORDENSERVICIO, refeARTICULO, nombreTIPOARTICULO, nombPRODUCTO, cantidadREPORTE_PRODUCTO FROM ordenservicio INNER JOIN REPORTE ON reporte.ORDENSERVICIO_idORDENSERVICIO= ordenservicio.idORDENSERVICIO INNER JOIN reporte_PRODUCTO ON reporte_producto.REPORTE_idREPORTE =reporte.idREPORTE INNER JOIN producto ON reporte_producto.PRODUCTO_idPRODUCTO = producto.idPRODUCTO INNER JOIN articulo ON reporte.ARTICULO_idARTICULO = articulo.idARTICULO INNER JOIN tipo_articulo ON articulo.TIPO_ARTICULO_idTIPO_ARTICULO = tipo_articulo.idTIPO_ARTICULO inner join cliente on ordenservicio.CLIENTE_idCLIENTE =cliente.idCLIENTE where cliente.idCLIENTE = '" + idcliente + " ' group by idORDENSERVICIO");
        }


        public DataTable consultarOrdenCliente(string id)
        {
            return con.ConsultarDatos("SELECT codiORDENSERVICIO, idORDENSERVICIO, CONCAT(nombCLIENTE, ' ', apellCLIENTE) AS NOmbres, fechaORDENSERVICIO, estadoORDENSERVICIO, descORDENSERVICIO, idORDENSERVICIO FROM reporte INNER JOIN ordenservicio ON reporte.ORDENSERVICIO_idORDENSERVICIO = ordenservicio.idORDENSERVICIO INNER JOIN cliente ON ordenservicio.CLIENTE_idCLIENTE = cliente.idCLIENTE WHERE cliente.idcliente ='"+id+"' GROUP BY idORDENSERVICIO");
        }



    }



}