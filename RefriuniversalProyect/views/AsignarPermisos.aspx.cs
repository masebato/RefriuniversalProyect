using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefriuniversalProyect.Models;
using System.Data;

namespace RefriuniversalProyect.views.Parametricas
{
    public partial class AsignarRol : System.Web.UI.Page
    {

        DataTable Roles = new DataTable();
        DataTable Table_menu = new DataTable();
        DataTable Table_permisos = new DataTable();
        Rol obj_rol = new Rol();
        Permisos obj_permisos = new Permisos();
        Permisos obj_permisos2;
        Models.Menu obj_menu = new Models.Menu();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
              
                if (!IsPostBack)
                {
                    consultarRolesListView();
                }              
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void consultarRolesListView()
        {
            try
            {
                Roles = obj_rol.consultarRoles();
                dropdownRoles.DataSource = Roles;
                dropdownRoles.DataTextField = "nombreROL";
                dropdownRoles.DataValueField = "idROL";
                dropdownRoles.DataBind();
            }
            catch (Exception)
            {

                throw;
            }           
        }

        protected void dropdownRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable diferencias = new DataTable();
                Table_menu =  obj_menu.ConsultarMenu();

                Table_permisos = obj_permisos.ConsultarPermisos(dropdownRoles.SelectedItem.Text);

                diferencias = DiferenciasTablas(Table_menu, Table_permisos);


                if (Table_permisos.Rows.Count==0)
                {
                    listaPermisos.DataSource = null;
                    listaPermisos.DataBind();
                    permisosno.DataSource = diferencias;
                    permisosno.DataBind();
                }
                else
                {
                    listaPermisos.DataSource = Table_permisos;
                    permisosno.DataSource = diferencias;
                    listaPermisos.DataBind();
                    permisosno.DataBind();
                }                                                
            }
            catch (Exception)
            {
                throw;
            }

        }


        public DataTable DiferenciasTablas( DataTable primeraTabla, DataTable segundaTabla)
        {
            DataTable Diferencias = new DataTable("Diferencias");

            #region DIFERENCIA DE DATATABLES

            
            using (DataSet ds = new DataSet())
            {

                ds.Tables.AddRange(new DataTable[] { primeraTabla.Copy(), segundaTabla.Copy() });

                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];

                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);


                for (int i = 0; i < primeraTabla.Columns.Count; i++)
                {
                    Diferencias.Columns.Add(primeraTabla.Columns[i].ColumnName, primeraTabla.Columns[i].DataType);
                }

                Diferencias.BeginLoadData();
                foreach (DataRow parentrow in ds.Tables[0].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r1);
                    if (childrows == null || childrows.Length==0)

                    {
                        Diferencias.LoadDataRow(parentrow.ItemArray, true);
                    }
                }

                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                        Diferencias.LoadDataRow(parentrow.ItemArray, true);
                }

                Diferencias.EndLoadData();
            }
            #endregion

            return Diferencias;

        }

       

        protected void permisosno_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                permisosno.EditIndex = e.NewEditIndex;
                Label menu = (Label)permisosno.Items[e.NewEditIndex].FindControl("idMENUlist");
               
                obj_permisos = new Permisos(
                    dropdownRoles.SelectedValue,
                    menu.Text
                    );

                if (obj_permisos.InsertarPermiso(obj_permisos))
                {
                   
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
                string currentPage = this.Page.Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect(currentPage);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
          



        }

        protected void listaPermisos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                listaPermisos.EditIndex = e.NewEditIndex;
                Label menu = (Label)listaPermisos.Items[e.NewEditIndex].FindControl("idMENUlist");
                obj_permisos2 = new Permisos(
                 
                    dropdownRoles.SelectedValue,
                       menu.Text

                    );
                if (obj_permisos2.ActualizarPermiso(obj_permisos2))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                  
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
                string currentPage = this.Page.Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect(currentPage);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }


        }
    }
}