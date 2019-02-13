using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;
using RefriuniversalProyect.Conexion;

namespace RefriuniversalProyect.views
{
    public partial class ordenServicio : System.Web.UI.Page
    {

        Clientes cli = new Clientes();
        Tecnico tec = new Tecnico();
        OrdenServicio orden;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarRegistro(object sender, EventArgs e)
        {
            try
            {
        
             orden = new OrdenServicio(
                 descripcionformulario.InnerText,
                 codigoformulario.Text,
                 fechaformulario.Text,
                 estadoformulario.Text,
                 idclientelabel.Text,
                 idtecnicolabel.Text
             );

                if (orden.insertarOrden(orden))
                {
                    descripcionformulario.InnerHtml = "";
                    codigoformulario.Text = "";
                    fechaformulario.Text = "";
                    idclientelabel.Text = "";
                    idtecnicolabel.Text = "";



                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'REGISTRO ALMACENADO',  '', 'success')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'EL REGISTRO NO FUE ALMACENADO',  '', 'error')", true);
                }
            

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " Swal.fire(  'ERROR EN LA CONEXION',  '', 'error')", true);
            }
     


        }

        protected void CargarClientes(object sender, EventArgs e)
        {
            try
            {
                clientes.DataSource = cli.ConsultarTodosLosClientes();
                clientes.DataBind();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#myModal').modal('show');", true);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        protected void CargarTecnicos(object sender, EventArgs e)

        {
            try
            {
                Tecnicos.DataSource = tec.ConsultarTodosTecnicos();
                Tecnicos.DataBind();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $('#tenicos').modal('show');", true);
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        protected void clientes_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                clientes.EditIndex = e.NewEditIndex;
                Label idcliente = (Label)clientes.Items[e.NewEditIndex].FindControl("idcliente");
                Label NombreCliente = (Label)clientes.Items[e.NewEditIndex].FindControl("nombrecliente");
                Label ApellidoCliente = (Label)clientes.Items[e.NewEditIndex].FindControl("apellidocliente");

                clienteFormulario.Text = NombreCliente.Text;
                idclientelabel.Text = idcliente.Text;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Tecnicos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                Tecnicos.EditIndex = e.NewEditIndex;
                Label idtecnico = (Label)Tecnicos.Items[e.NewEditIndex].FindControl("idtecnico");
                Label Nombretecnico = (Label)Tecnicos.Items[e.NewEditIndex].FindControl("nombretecnico");
                Label Apellidotecnico= (Label)Tecnicos.Items[e.NewEditIndex].FindControl("apellidotecnico");

                tecnicoformulario.Text = Nombretecnico.Text;
                idtecnicolabel.Text = idtecnico.Text;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}