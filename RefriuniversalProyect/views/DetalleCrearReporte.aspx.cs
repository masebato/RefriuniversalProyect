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
    public partial class DetalleCrearReporte : System.Web.UI.Page
    {
        Reportes obj_reportes;
        Producto obj_producto;
        tipoArticulo obj_tipoArticulo;
        Articulo obj_Articulo;
        public static string idOrden;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idOrden = Convert.ToString(Request.QueryString["idorden"]);
                CodigOrden.Text = Convert.ToString(Request.QueryString["codigorden"]);
                NombreCliente.Text = Convert.ToString(Request.QueryString["nombrecliente"]);
                FechaCreacion.Text = Convert.ToString(Request.QueryString["fechaorden"]);
                EstadoOrden.Text = Convert.ToString(Request.QueryString["estado"]);
                generarCodigo(idOrden);
                CargarTipoArticulo();
                divReporte.Visible = false;
                divRepuestos.Visible = false;
                divListaRepuesto.Visible = false;
            }
          

        }

        public void CargarTipoArticulo()
        {
            try
            {
                obj_tipoArticulo = new tipoArticulo();

                tipoArticulo.DataSource = obj_tipoArticulo.consultarTipoArticulo();
                tipoArticulo.DataTextField = "nombreTIPOARTICULO";
                tipoArticulo.DataValueField = "idTIPO_ARTICULO";
                tipoArticulo.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
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
                    codigo.Text = "REP-1-" + idorden;
                }
                else
                {
                    codigo.Text = "REP-" + ids+"-" + idorden;
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        protected void listarespuestos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                listarespuestos.EditIndex = e.NewEditIndex;
                Label idrepuesto = (Label)listarespuestos.Items[e.NewEditIndex].FindControl("id");
                Label nombre = (Label)listarespuestos.Items[e.NewEditIndex].FindControl("nombre");
                id.Text = idrepuesto.Text;
                nombreRepuestoModal.Text = nombre.Text;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#cantidadProducto').modal('show');", true);

            }
            catch (Exception)
            {

                throw;
            }
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

        protected void InsertarRepuesto(object sender, EventArgs e)
        {
            try
            {
                obj_producto = new Producto();
                if (obj_producto.insertarProductoReporte(id.Text, cantidad.Text))
                {
                    cantidad.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                    CargarListaRepuestosReporte();
                    ordenCerrar.Visible = true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarListaRepuestosReporte()
        {
            try
            {
                obj_producto = new Producto();
                repuestosOrden.DataSource = obj_producto.ConsultarProductoReporte(codigo.Text);
                repuestosOrden.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GuardarArticulo(object sender, EventArgs e)
        {
            try
            {
                obj_Articulo = new Articulo(
                    referencia.Text,
                    tipoArticulo.SelectedValue
                    );
                if (obj_Articulo.insertarArticulo(obj_Articulo))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                    referencia.Enabled = false;
                    tipoArticulo.Enabled = false;
                    divReporte.Visible = true;
                    save.Enabled = false;
                    
                        
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
               
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
        }

        protected void CrearReporte(object sender, EventArgs e)
        {
            try
            {
                obj_reportes = new Reportes(
                    codigo.Text,
                    descr.InnerText,
                    fecha.Text,
                    idOrden
                    );

                if (obj_reportes.insertarReporte(obj_reportes))
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                    fecha.Enabled = false;
                    descr.EnableViewState = false;
                    divListaRepuesto.Visible = true;
                    divRepuestos.Visible = true;
                    LinkButton1.Enabled = false;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
        }



        private HtmlGenericControl assign_tag_card_user(HtmlGenericControl tag_card_user, string value)
        {
            tag_card_user.Attributes.Add("style",value);
            return tag_card_user;
        }

        protected void CerrarOrden(object sender, EventArgs e)
        {
            try
            {
                OrdenServicio obj_orden = new OrdenServicio();

                if (obj_orden.ActualizarEstado(idOrden))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                    Response.Redirect("inicio.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
           
        }
    }
}