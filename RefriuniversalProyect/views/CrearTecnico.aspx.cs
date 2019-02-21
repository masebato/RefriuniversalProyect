using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;
namespace RefriuniversalProyect.views
{
    public partial class CrearTecnico : System.Web.UI.Page
    {
        TipoDocumento Documento_obj;
        Tecnico obj_tecnico;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDocumentos();
            }


        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                obj_tecnico = new Tecnico(
                    nombreTecnico.Text,
                    ApellidoTecnico.Text,
                    DocumentoTecnico.Text,
                    telefonoTecnico.Text,
                    dropdowntipo.SelectedValue.ToString()
                    );

                if (obj_tecnico.InsertarTecnico(obj_tecnico))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                    nombreTecnico.Text = "";
                    ApellidoTecnico.Text = "";
                    DocumentoTecnico.Text = "";
                    telefonoTecnico.Text = "";
                    dropdowntipo.SelectedValue = "0";

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
            }
        }

        public void cargarDocumentos()
        {
            try
            {
                Documento_obj = new TipoDocumento();
                dropdowntipo.DataSource = Documento_obj.consultartipoDdocu();
                dropdowntipo.DataTextField = "nombreTIPODOCUMENTO";
                dropdowntipo.DataValueField = "idTIPODOCUMENTO";
                dropdowntipo.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}