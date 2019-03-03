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
    public partial class DetalleCrearReporte : System.Web.UI.Page
    {
        Reportes obj_reportes;
        Producto obj_producto;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idOrden = Convert.ToString(Request.QueryString["idorden"]);
            CodigOrden.Text = Convert.ToString(Request.QueryString["codigorden"]);
            NombreCliente.Text = Convert.ToString(Request.QueryString["nombrecliente"]);
            FechaCreacion.Text = Convert.ToString(Request.QueryString["fechaorden"]);
            EstadoOrden.Text = Convert.ToString(Request.QueryString["estado"]);
            generarCodigo(idOrden);

        }

        public void generarCodigo( string idorden)
        {
            try
            {
                DataTable id = new DataTable();
                obj_reportes = new Reportes();

                id = obj_reportes.ReporteMaxid();

                string ids = id.Rows[0]["reporte"].ToString();
                if (ids=="")
                {
                    codigo.Text = "REP-1" + idorden;
                }
                else
                {
                    codigo.Text = "REP-" + ids  + idorden;
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        protected void listarespuestos_ItemEditing(object sender, ListViewEditEventArgs e)
        {

        }

        protected void CrearRepuesto(object sender, EventArgs e)
        {
            try
            {
                obj_producto = new Producto();


                if (obj_producto.CrearProducto(nombreProducto.Text,referencia.Text,marcaProducto.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                }
                
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
            }
        }

        protected void Busqueda(object sender, EventArgs e)
        {
            try
            {
                obj_producto = new Producto();
                listarespuestos.DataSource= obj_producto.BusquedaPrducto(busqueda.Text);
                listarespuestos.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void abrirmodal(object sender, EventArgs e)
        {
            try
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#tenicos').modal('show');", true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}