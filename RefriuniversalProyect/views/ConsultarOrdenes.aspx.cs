using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;
using System.Data;
using System.Web.UI.HtmlControls;

namespace RefriuniversalProyect.views
{
    public partial class ConsultarOrdenes : System.Web.UI.Page
    {
        Clientes obj_clientes;
        public static string idcliente;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                idcliente = Convert.ToString(Request.QueryString["idcliente"]);
                CargarDatos(idcliente);
            }

        }

        public void CargarDatos(string idcliente)
        {
            try
            {
                obj_clientes = new Clientes();

                OrdenesCliente.DataSource = obj_clientes.consultarOrdenCliente(idcliente);
                OrdenesCliente.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void OrdenesCliente_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                OrdenesCliente.EditIndex = e.NewEditIndex;

                Label idorden = (Label)OrdenesCliente.Items[e.NewEditIndex].FindControl("idorden");
                Label nombre = (Label)OrdenesCliente.Items[e.NewEditIndex].FindControl("nombre");
                Label codigo = (Label)OrdenesCliente.Items[e.NewEditIndex].FindControl("codigo");
                Label fecha = (Label)OrdenesCliente.Items[e.NewEditIndex].FindControl("fecha");
                Label estado = (Label)OrdenesCliente.Items[e.NewEditIndex].FindControl("estado");

                Response.Redirect("ConsultarDetalleOrden.aspx?idorden=" + idorden.Text + "&codigorden=" + codigo.Text + "&nombrecliente=" + nombre.Text + "&fechaorden=" + fecha.Text + "&estado=" + estado.Text + " ");


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}