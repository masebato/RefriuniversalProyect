using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefriuniversalProyect.Conexion;
using RefriuniversalProyect.AccesoDatos.Interface;
using System.Data;

namespace RefriuniversalProyect.Models
{
    public class Tecnico
    {
        IDatos con = new Datos();

        string idTECNICO { get; set; }
        string nombTECNICO { get; set; }
        string apelTECNICO { get; set; }
        string documentoTECNICO { get; set; }
        string telefonoTECNICO { get; set; }
        string tipodocuTECNICO { get; set; }


        public Tecnico()
        {

        }
        public Tecnico( string nombreTecnico, string apellidoTecnico, string documentoTecnico, string telofnoTecnico, string tipodocu)
        {
            this.nombTECNICO = nombreTecnico;
            this.apelTECNICO = apellidoTecnico;
            this.documentoTECNICO = documentoTecnico;
            this.telefonoTECNICO = telofnoTecnico;
            this.tipodocuTECNICO = tipodocu;




        }

        public DataTable ConsultarTodosTecnicos()
        {
            return con.ConsultarDatos("select * from tecnico");
        }

        public bool InsertarTecnico(Tecnico tec)
        {
            return con.OperarDatos("insert into tecnico (nombTECNICO, apelTECNICO,TIPODOCUMENTO_idTIPODOCUMENTO,documentoTECNICO,telefonoTECNICO ) values ('" + tec.nombTECNICO + "','" + tec.apelTECNICO + "','" + tec.tipodocuTECNICO + "','" + tec.documentoTECNICO + "','" + tec.telefonoTECNICO + "' ) ");

        }
    }
}