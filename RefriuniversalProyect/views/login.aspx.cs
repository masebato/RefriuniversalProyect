using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RefriuniversalProyect.Models;

namespace RefriuniversalProyect.views
{
    public partial class login : System.Web.UI.Page
    {

       
        private Models.Login log;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                log = new Models.Login(
                    users.Text,
                    pass.Value
                    );

                DataTable dato = null;
                dato = log.consultarLogin(log);


                if (dato.Rows[0] != null)
                {
                   
                    Session["Nombre"] = dato.Rows[0]["userLOGIN"];
                    Session["Rol"] = dato.Rows[0]["nombreROL"];
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    dato = log.ConsultarLoginTecnico(log);
                    if (dato.Rows[0] != null)
                    {
                        Session["Nombre"] = dato.Rows[0]["nombTECNICO"];
                        Session["Apellido"] = dato.Rows[0]["apelTECNICO"];
                        Session["Rol"] = dato.Rows[0]["NombreROL"];
                        Response.Redirect("Inicio.aspx");
                    }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('usuario no encontrado', '', 'error');", true);

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('CONTRASEÑA INCORRECTA', '', 'error');", true);

            }
        }
    }
}