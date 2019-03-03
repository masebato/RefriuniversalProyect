using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;

namespace RefriuniversalProyect.views
{
    public partial class CrearReporte : System.Web.UI.Page
    {
        OrdenServicio orden = new OrdenServicio();
        Reportes repor;
        Articulo arti;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsultarOrden(object sender, EventArgs e)
        {

            try
            {
                if (codigoOrden.Text=="")
                {
                    reportes.DataSource = orden.ConsultarOrden();
                    reportes.DataBind();
                }
                else
                {
                    reportes.DataSource = orden.ConsultarOrden(codigoOrden.Text);
                    reportes.DataBind();
                }
                

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR DE CONEXION', '', 'error');", true);
            }
        
        }

        protected void reportes_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                reportes.EditIndex = e.NewEditIndex;
                Label idordenservicio = (Label)reportes.Items[e.NewEditIndex].FindControl("idorden");
                Label codigoorden = (Label)reportes.Items[e.NewEditIndex].FindControl("codigoorden");
                Label nombrecliente = (Label)reportes.Items[e.NewEditIndex].FindControl("nombrecliente");
                Label fecha = (Label)reportes.Items[e.NewEditIndex].FindControl("fechaorden");
                Label estado = (Label)reportes.Items[e.NewEditIndex].FindControl("estadoorden");

                Response.Redirect("DetalleCrearReporte.aspx?idorden=" + idordenservicio.Text+"&codigorden="+codigoorden.Text+"&nombrecliente="+nombrecliente.Text+"&fechaorden="+fecha.Text+"&estado="+estado.Text);
               
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR DE CONEXION', '', 'error');", true);
            }
     
        }

        protected void GuardarReporte(object sender, EventArgs e)
        {
            try
            {
                arti = new Articulo(
               nombreArticulo.Text,
               ReferenciaArticulo.Text,
               tipoarticulo.SelectedValue,
               marcaArticulo.Text

               );

                if (arti.insertarArticulo(arti))
                {
                    repor = new Reportes(

                 codigoreporte.Text,
                 descripcionReporte.InnerHtml,
                 fechaReporte.Text,
                 idordenmodal.Text
                 );
                    if (repor.insertarReporte(repor))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                        codigoreporte.Text = "";
                        descripcionReporte.InnerHtml = "";
                        fechaReporte.Text = "";
                        idordenmodal.Text = "";
                        nombreArticulo.Text = "";
                        ReferenciaArticulo.Text = "";
                        tipoarticulo.SelectedValue = "";
                        marcaArticulo.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO NO ALMACENADO', '', 'error');", true);
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO NO ALMACENADO', '', 'error');", true);
                }

            }
            catch (Exception )
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR DE CONEXION', '', 'error');", true);
            }
           

         
        }
    }
}