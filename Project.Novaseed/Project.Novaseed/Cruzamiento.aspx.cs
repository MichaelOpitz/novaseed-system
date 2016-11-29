using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.ComponentModel;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class Cruzamiento : System.Web.UI.Page
    {
        private int contFertilidad, contFlor, contCruzamientoVasos, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            contFertilidad = 0;
            contFlor = 0;
            contCruzamientoVasos = 0;
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblCruzamientoAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvCruzamiento.DataSource = cc.GetCruzamiento(valorAñoInt32);
                this.gdvCruzamiento.DataBind();
            }
        }

        /*
         * Llena la grilla del cruzamiento con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            gdvCruzamiento.DataSource = cc.GetCruzamiento(valorAñoInt32);
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
                int index = cc.GetFertilidadCruzamiento(valorAñoInt32, contFertilidad) - 1;
                ddlCruzamientoFertilidad.SelectedIndex = index;
                contFertilidad = contFertilidad + 1;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el DropDownList en la fila
                CheckBox chkCruzamientoFlor = (e.Row.FindControl("chkCruzamientoFlor") as CheckBox);

                bool indexFlor = cc.GetFlorCruzamiento(valorAñoInt32, contFlor);

                if (indexFlor == true)
                    chkCruzamientoFlor.Checked = true;
                else
                    chkCruzamientoFlor.Checked = false;
                contFlor = contFlor + 1;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int indexCruzamientoVasos = cc.GetCruzamientoEstaEnVasos(valorAñoInt32, contCruzamientoVasos);

                //Ecuentra el CheckBox en la fila
                CheckBox chkVasosAgregar = (e.Row.FindControl("chkVasosAgregar") as CheckBox);
                if (indexCruzamientoVasos == 1)
                {
                    e.Row.BackColor = Color.LightGreen;
                    chkVasosAgregar.Enabled = false;
                }
                else
                {
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                    chkVasosAgregar.Enabled = true;
                }
                contCruzamientoVasos = contCruzamientoVasos + 1;
            }
        }

        protected void CruzamientoGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                CatalogCruzamiento cc = new CatalogCruzamiento();
                string id_cruzamiento = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[2].Text);
                string codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[3].Text);
                string pad_codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[5].Text);

                string ubicacion_cruzamiento = e.NewValues[0].ToString();
                DropDownList ddlCruzamientoFertilidad = (DropDownList)gdvCruzamiento.Rows[e.RowIndex].FindControl("ddlCruzamientoFertilidad");
                string id_fertilidad = ddlCruzamientoFertilidad.SelectedValue;
                CheckBox chkCruzamientoFlor = (CheckBox)gdvCruzamiento.Rows[e.RowIndex].FindControl("chkCruzamientoFlor");
                bool flor;
                if (chkCruzamientoFlor.Checked)
                    flor = true;
                else
                {
                    flor = false;
                    string bayasCantidad = e.NewValues[1].ToString();
                    if (!bayasCantidad.Equals(""))
                    {
                        int bc = Int32.Parse(bayasCantidad);
                        if (bc > 0)
                            Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡No puede haber bayas si no hay flores!')</script>");
                    }
                }
                string bayas = e.NewValues[1].ToString();
                Project.BusinessRules.Cruzamiento cruzamiento = new Project.BusinessRules.Cruzamiento(Int32.Parse(id_cruzamiento),
                  codigo_variedad, pad_codigo_variedad, ubicacion_cruzamiento, Int32.Parse(id_fertilidad), flor, Int32.Parse(bayas));
                cc.UpdateCruzamiento(cruzamiento);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }

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
            string id_cruzamiento = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[e.RowIndex].Cells[2].Text);
            int valor = cc.DeleteCruzamiento(Int32.Parse(id_cruzamiento));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el cruzamiento!')</script>");

            PoblarGrilla();
        }

        /*
         * Recorre todos los CheckBox del GridView para ver los activos y agregarlos a Vasos
         */ 
        protected void btnAgregarVasos_Click(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdvCruzamiento.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkVasosAgregar = (row.Cells[0].FindControl("chkVasosAgregar") as CheckBox);

                    if (chkVasosAgregar != null)
                    {
                        if (chkVasosAgregar.Checked)
                        {
                            string id_cruzamiento = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[row.RowIndex].Cells[2].Text);
                            string codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[row.RowIndex].Cells[3].Text);
                            string pad_codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvCruzamiento.Rows[row.RowIndex].Cells[5].Text);

                            CatalogVasos cv = new CatalogVasos();                            
                            int existe_vaso = cv.AddVasos(Int32.Parse(id_cruzamiento), codigo_variedad, pad_codigo_variedad);
                            if (existe_vaso == 1)
                                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('El cruzamiento con ID: " + id_cruzamiento + " seleccionado ya tiene un vaso asignado o no tiene bayas')</script>");
                            else
                                agrego = 1;
                        }
                    }
                }
            //1 para agregar, 0 cuando no se agrega
            if (agrego == 1)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Agregado Correctamente!')</script>");
                Response.Redirect("MenuGeneracion.aspx");
            }
        }
    }
}