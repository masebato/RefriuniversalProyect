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
    public partial class ConsultarArticulo : System.Web.UI.Page
    {
        Articulo obj_articulo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                obj_articulo = new Articulo();
                listaArticulo.DataSource = obj_articulo.consultarArticulos(referencia.Text);
                listaArticulo.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}