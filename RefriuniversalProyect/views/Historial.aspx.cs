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

     

    }
}