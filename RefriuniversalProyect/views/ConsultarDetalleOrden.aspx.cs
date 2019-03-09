using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;
using System.Data;

namespace RefriuniversalProyect.views
{
    public partial class ConsultarDetalleOrden : System.Web.UI.Page
    {
        Reportes obj_reporte;
        DataTable table_reportes;
        public static string idOrden;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idOrden = Convert.ToString(Request.QueryString["idorden"]);
                CodigOrden.Text= Convert.ToString(Request.QueryString["codigorden"]);
                NombreCliente.Text = Convert.ToString(Request.QueryString["nombrecliente"]);
                FechaCreacion.Text = Convert.ToString(Request.QueryString["fechaorden"]);
                EstadoOrden.Text = Convert.ToString(Request.QueryString["estado"]);
                consultarReportes(idOrden);
            }

        }


        public void consultarReportes(string orden)
        {
            try
            {
                obj_reporte = new Reportes();
                table_reportes = new DataTable();

                table_reportes= obj_reporte.ConsultarArticulosReportes(idOrden);
                ReportesList.DataSource = table_reportes;
                ArticulosList.DataSource = table_reportes;
                ReportesList.DataBind();
                ArticulosList.DataBind();


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ReportesList_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                DataTable repuestosDescrip = new DataTable();
                obj_reporte = new Reportes();
                ReportesList.EditIndex = e.NewEditIndex;

                TextBox codigoReporte = (TextBox)ReportesList.Items[e.NewEditIndex].FindControl("codigo");
                repuestosDescrip = obj_reporte.consultarrepuestosorden(codigoReporte.Text);
                repuestosReporte.DataSource = repuestosDescrip;
                descripcionarea.InnerText= repuestosDescrip.Rows[0]["descREPORTE"].ToString();
                repuestosReporte.DataBind();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#cantidadProducto').modal('show');", true);
            }
            catch (Exception)
            {

             
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("DetalleCrearReporte.aspx?idorden=" + idOrden + "&codigorden=" + CodigOrden.Text + "&nombrecliente=" + NombreCliente.Text + "&fechaorden=" + FechaCreacion.Text + "&estado=" + EstadoOrden.Text);
            }
            catch (Exception)
            {

              
            }
        }
    }
}