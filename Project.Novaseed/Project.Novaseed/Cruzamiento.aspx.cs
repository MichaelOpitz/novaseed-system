using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.ComponentModel;

namespace Project.Novaseed
{
    public partial class Cruzamiento : System.Web.UI.Page
    {
        private int contFertilidad, contFlor;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            contFertilidad = 0;
            contFlor = 0;

            if (!Page.IsPostBack)
            {
                this.gdvCruzamiento.DataSource = cc.GetCruzamiento(2016);
                this.gdvCruzamiento.DataBind();
            }
        }

        private void PoblarGrilla()
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            gdvCruzamiento.DataSource = cc.GetCruzamiento(2016);
            gdvCruzamiento.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW CRUZAMIENTO
         */ 
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el DropDownList en la fila
                DropDownList ddlCruzamientoFertilidad = (e.Row.FindControl("ddlCruzamientoFertilidad") as DropDownList);
                //Llena el dropdown fertilidad
                CatalogFertilidad cf = new CatalogFertilidad();
                ddlCruzamientoFertilidad.DataSource = cf.getFertilidad();
                ddlCruzamientoFertilidad.DataTextField = "nombre_fertilidad";
                ddlCruzamientoFertilidad.DataValueField = "id_fertilidad";
                ddlCruzamientoFertilidad.DataBind();
                
                //Selecciona la fertilidad de cada cruzamiento
                int index = cc.GetFertilidadCruzamiento(2016, contFertilidad) - 1;
                ddlCruzamientoFertilidad.SelectedIndex = index;
                contFertilidad = contFertilidad + 1;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el DropDownList en la fila
                CheckBox chkCruzamientoFlor = (e.Row.FindControl("chkCruzamientoFlor") as CheckBox);

                bool indexFlor = cc.GetFlorCruzamiento(2016, contFlor);

                if (indexFlor == true)
                    chkCruzamientoFlor.Checked = true;
                else
                    chkCruzamientoFlor.Checked = false;
                contFlor = contFlor + 1;

            }
        }

        protected void CruzamientoGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();           
            string id_cruzamiento = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[1].Text);
            string codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[2].Text);
            string pad_codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[3].Text);

            string ubicacion_madre = e.NewValues[0].ToString();
            string ubicacion_padre = e.NewValues[1].ToString();
            DropDownList ddlCruzamientoFertilidad = (DropDownList)gdvCruzamiento.Rows[e.RowIndex].FindControl("ddlCruzamientoFertilidad");
            string id_fertilidad = ddlCruzamientoFertilidad.SelectedValue;
            CheckBox chkCruzamientoFlor = (CheckBox)gdvCruzamiento.Rows[e.RowIndex].FindControl("chkCruzamientoFlor");
            bool flor;
            if (chkCruzamientoFlor.Checked)
                flor = true;
            else
                flor = false;
            string bayas = e.NewValues[2].ToString();
            Project.BusinessRules.Cruzamiento cruzamiento = new Project.BusinessRules.Cruzamiento(Int32.Parse(id_cruzamiento),
                codigo_variedad, pad_codigo_variedad, ubicacion_madre, ubicacion_padre, Int32.Parse(id_fertilidad),
                flor, Int32.Parse(bayas));
            cc.UpdateCruzamiento(cruzamiento);

            gdvCruzamiento.EditIndex = -1;
            PoblarGrilla();            
        }

        protected void CruzamientoGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvCruzamiento.EditIndex = -1;
            PoblarGrilla();
        }

        protected void CruzamientoGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvCruzamiento.EditIndex = e.NewEditIndex;
            PoblarGrilla();
        }

        protected void CruzamientoGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            string id_cruzamiento = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[1].Text);
            cc.DeleteCruzamiento(Int32.Parse(id_cruzamiento));

            PoblarGrilla();
        }
    }
}