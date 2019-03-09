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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        Clientes obj_clientes;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CargarClientes(object sender, EventArgs e)
        {
            try
            {
                obj_clientes = new Clientes();
                if (documentoCliente.Text=="")
                {
                    clientesList.DataSource = obj_clientes.ConsultarTodosLosClientes();

                }
                else
                {
                    clientesList.DataSource = obj_clientes.Consultarclientes(documentoCliente.Text);
                }

                clientesList.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void clientesList_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                obj_clientes = new Clientes();
                clientesList.EditIndex = e.NewEditIndex;
                Label idCliente = (Label)clientesList.Items[e.NewEditIndex].FindControl("idcliente");

                Response.Redirect("ConsultarOrdenes.aspx?idcliente="+idCliente.Text+"");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}