using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;

namespace RefriuniversalProyect.views
{
    public partial class CrearCliente : System.Web.UI.Page
    {
        Clientes clientes_obj;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarCliente(object sender, EventArgs e)
        {
            try
            {
                clientes_obj = new Clientes(
                    nombre.Text,
                    apellido.Text,
                    documento.Text,
                    direccion.Text,
                    correo.Text,
                    "1"                    
                );


                if (clientes_obj.CrearCliente(clientes_obj))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                    nombre.Text = "";
                    apellido.Text = "";
                    documento.Text = "";
                    direccion.Text = "";
                    correo.Text = "";
                }  


            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
            }

        }
    }
}