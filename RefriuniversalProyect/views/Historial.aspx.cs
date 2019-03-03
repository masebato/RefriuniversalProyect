using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RefriuniversalProyect.Models;
using System.Web.UI.HtmlControls;

namespace RefriuniversalProyect.views
{
    public partial class Historial : System.Web.UI.Page
    {
        DataTable table_Orden;
        OrdenServicio obj_orden;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                obj_orden = new OrdenServicio();
                table_Orden = obj_orden.OrdenPorFecha(fechainicio.Value, fechamax.Value);
                ListaORDENES.DataSource = table_Orden;
                ListaORDENES.DataBind();


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ListaORDENES_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                ListaORDENES.EditIndex = e.NewEditIndex;
                Label idordenservicio = (Label)ListaORDENES.Items[e.NewEditIndex].FindControl("idORden");
                Label codigoorden = (Label)ListaORDENES.Items[e.NewEditIndex].FindControl("codigoORDEN");
                Label nombrecliente = (Label)ListaORDENES.Items[e.NewEditIndex].FindControl("NombreCliente");
                Label fecha = (Label)ListaORDENES.Items[e.NewEditIndex].FindControl("Fecha");
                Label estado = (Label)ListaORDENES.Items[e.NewEditIndex].FindControl("Estado");

                Response.Redirect("ConsultarDetalleorden.aspx?idorden=" + idordenservicio.Text + "&codigorden=" + codigoorden.Text + "&nombrecliente=" + nombrecliente.Text + "&fechaorden=" + fecha.Text + "&estado=" + estado.Text);

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR DE CONEXION', '', 'error');", true);
            }
        }
    }
}