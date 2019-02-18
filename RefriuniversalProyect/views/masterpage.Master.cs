using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using RefriuniversalProyect.Models;

namespace RefriuniversalProyect.views
{
    public partial class masterpage : System.Web.UI.MasterPage
    {
        private DataTable menu = new DataTable();
        private Models.Login login = new Models.Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CreateMenu();
                nombreSesion.Text = Session["Nombre"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx");

            }
        }
        private void CreateMenu()
        {
            menu = login.ConsultarMenu(Session["Rol"].ToString());

            for (int i = 0; i < menu.Rows.Count; i++)
            {
                HtmlGenericControl tag_li = new HtmlGenericControl("li");
                HtmlGenericControl tag_a = new HtmlGenericControl("a");
                HtmlGenericControl tag_i = new HtmlGenericControl("i");
                HtmlGenericControl tag_p = new HtmlGenericControl("label");

                tag_a = Assign_tag_a(tag_a, menu.Rows[i]["rutaMENU"].ToString());
                tag_p = Assing_tag_p(tag_p, menu.Rows[i]["nombreMENU"].ToString());

                tag_a.Controls.Add(tag_p);
                tag_li.Controls.Add(tag_a);
                MenuGeneral.Controls.Add(tag_li);
            }

        }
        private HtmlGenericControl Assign_tag_a(HtmlGenericControl tag_A, string value)
        {
            tag_A.Attributes.Add("href", value);
            return tag_A;
        }

        private HtmlGenericControl Assign_tag_li(HtmlGenericControl tag_LI, string value)
        {

            return tag_LI;
        }

        private HtmlGenericControl Assing_tag_p(HtmlGenericControl tag_p, string value)
        {
            tag_p.Attributes.Add("style", "text-transform:capitalize;");
            tag_p.InnerText = value;

            return tag_p;
        }



    }
}