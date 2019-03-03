using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RefriuniversalProyect.views
{
    public partial class ConsultarDetalleOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idOrden = Convert.ToString(Request.QueryString["idorden"]);
                CodigOrden.Text= Convert.ToString(Request.QueryString["codigorden"]);
                NombreCliente.Text = Convert.ToString(Request.QueryString["nombrecliente"]);
                FechaCreacion.Text = Convert.ToString(Request.QueryString["fechaorden"]);
                EstadoOrden.Text = Convert.ToString(Request.QueryString["estado"]);
                consultarReportes(idOrden);
            }

        }


        public void consultarReportes(string orden)
        {

        }
    }
}