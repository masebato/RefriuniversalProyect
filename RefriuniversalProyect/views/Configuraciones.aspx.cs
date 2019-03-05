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
    public partial class Configuraciones : System.Web.UI.Page
    {
        Empresa obj_empr;
        DataTable empresa_data = new DataTable();
        tipoArticulo obj_tipoArticulo;
        TipoDocumento obj_tipoDocumento;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                obj_empr = new Empresa();
                empresa_data = obj_empr.ConsultarEmpresa();
                nombreEmpresa.Text = empresa_data.Rows[0]["nombreEMPRESA"].ToString();
                Nit.Text = empresa_data.Rows[0]["nitEMPRESA"].ToString();
                CargartipoArticulo();
                CargarTipoDocumento();
            }

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                obj_empr = new Empresa();               

                if (obj_empr.ActualizarEmpresa(nombreEmpresa.Text, Nit.Text,  "/views/assets/img/" + cargarlogo.FileName))
                {
                    cargarlogo.SaveAs(Server.MapPath(".") + "/assets/img/" + cargarlogo.FileName);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                }

            }                
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);                
            }
        }

        protected void CargarTipoDocumento()
        {
            try
            {
                obj_tipoDocumento = new TipoDocumento();
                cargartipoDocumento.DataSource= obj_tipoDocumento.consultartipoDdocu();
                cargartipoDocumento.DataBind();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR  DE CONEXION',  '', 'error')", true);

            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                obj_tipoArticulo = new tipoArticulo();
                if (obj_tipoArticulo.crearTipo(nombreTipoArticulo.Text))
                {
                    nombreTipoArticulo.Text = "";
                    CargartipoArticulo();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                    
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
            }
        }

        public void CargartipoArticulo()
        {
            try
            {
                obj_tipoArticulo = new tipoArticulo();
                ListaTipoArticulo.DataSource = obj_tipoArticulo.consultarTipoArticulo();
                ListaTipoArticulo.DataBind();
            }
            catch (Exception)
            {
                  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR  DE CONEXION',  '', 'error')", true);
            }
        }

        protected void ListaTipoArticulo_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                ListaTipoArticulo.EditIndex = e.NewEditIndex;
                Label NombreTipo = (Label)ListaTipoArticulo.Items[e.NewEditIndex].FindControl("nombre");               
                Label idtipo = (Label)ListaTipoArticulo.Items[e.NewEditIndex].FindControl("id");
                ID.Text = idtipo.Text;
                nombreArticulo.Text = NombreTipo.Text;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#tipo').modal('show');", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ActualizarTipo(object sender, EventArgs e)
        {
            try
            {
                obj_tipoArticulo = new tipoArticulo();
                if (obj_tipoArticulo.Actualizartipo(ID.Text, nombreArticulo.Text, estadoTipoArti.SelectedItem.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR DE CONEXION',  '', 'error')", true);
            }


        }

        protected void cargartipoDocumento_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                cargartipoDocumento.EditIndex = e.NewEditIndex;
                Label id = (Label)cargartipoDocumento.Items[e.NewEditIndex].FindControl("id");
                idTipoDocu.Text = id.Text;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#tipo').modal('show');", true);
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR DE CONEXION',  '', 'error')", true);
            }
        }

        protected void ActualizarTipoDocu(object sender, EventArgs e)
        {
            try
            {
                obj_tipoDocumento = new TipoDocumento();
                if (obj_tipoDocumento.ActualizarTipodocu(NombreTipoDocu.Text, idTipoDocu.Text, estadoTipoArti.SelectedItem.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR DE CONEXION',  '', 'error')", true);
            }
        }

        protected void CrearTipoDocumento(object sender, EventArgs e)
        {

        }
    }
}