using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class Vasos : System.Web.UI.Page
    {
        private int contFertilidad, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            contFertilidad = 0;

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);            

            if (!Page.IsPostBack)
            {
                this.txtCantidadTotalVasos.Text = cv.GetCantidadTotalVasos_fn(valorAñoInt32).ToString() + " Vasos";
                this.lblVasosAño.Text += "("+valorAñoInt32.ToString()+")";
                this.gdvVasos.DataSource = cv.GetVasos(valorAñoInt32);
                this.gdvVasos.DataBind();
            }                            
        }

        /*
         * Llena la grilla de los vasos con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogVasos cv = new CatalogVasos();
            this.gdvVasos.DataSource = cv.GetVasos(valorAñoInt32);
            this.gdvVasos.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW VASOS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el DropDownList en la fila
                DropDownList ddlVasosFertilidad = (e.Row.FindControl("ddlVasosFertilidad") as DropDownList);
                //Llena el dropdown fertilidad
                CatalogFertilidad cf = new CatalogFertilidad();
                ddlVasosFertilidad.DataSource = cf.getFertilidad();
                ddlVasosFertilidad.DataTextField = "nombre_fertilidad";
                ddlVasosFertilidad.DataValueField = "id_fertilidad";
                ddlVasosFertilidad.DataBind();

                //Selecciona la fertilidad de cada vaso
                int index = cv.GetFertilidadVasos(valorAñoInt32, contFertilidad) - 1;
                ddlVasosFertilidad.SelectedIndex = index;
                contFertilidad = contFertilidad + 1;
            }
        }

        protected void VasosGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            try
            {                
                string id_vasos = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[e.RowIndex].Cells[2].Text);

                string ubicacion_vasos = e.NewValues[0].ToString();
                string cantidad_vasos = e.NewValues[1].ToString();
                DropDownList ddlVasosFertilidad = (DropDownList)gdvVasos.Rows[e.RowIndex].FindControl("ddlVasosFertilidad");
                string id_fertilidad = ddlVasosFertilidad.SelectedValue;

                string azul_vasos = e.NewValues[2].ToString();
                string roja_vasos = e.NewValues[3].ToString();
                string amarilla_vasos = e.NewValues[4].ToString();
                string bicolor_vasos = e.NewValues[5].ToString();

                int cantidad = Int32.Parse(cantidad_vasos);
                int azul = Int32.Parse(azul_vasos);
                int roja = Int32.Parse(roja_vasos);
                int amarilla = Int32.Parse(amarilla_vasos);
                int bicolor = Int32.Parse(bicolor_vasos);
                int suma = azul + roja + amarilla + bicolor;
                if (suma > cantidad)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La suma de azules, rojas, amarillas y bicolores("+suma+") no debe ser mayor a la cantidad total("+cantidad+") del vaso')</script>");

                Project.BusinessRules.Vasos vasos = new Project.BusinessRules.Vasos(Int32.Parse(id_vasos),
                        ubicacion_vasos, cantidad, Int32.Parse(id_fertilidad),
                        azul, roja, amarilla, bicolor);
                cv.UpdateVasos(vasos);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            gdvVasos.EditIndex = -1;
            this.txtCantidadTotalVasos.Text = cv.GetCantidadTotalVasos_fn(valorAñoInt32).ToString() + " Vasos";
            PoblarGrilla();
        }

        protected void VasosGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvVasos.EditIndex = -1;
            PoblarGrilla();
        }

        protected void VasosGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvVasos.EditIndex = e.NewEditIndex;
            PoblarGrilla();
        }

        protected void VasosGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            string id_vasos = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[e.RowIndex].Cells[2].Text);
            int valor = cv.DeleteVasos(Int32.Parse(id_vasos));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el vaso!')</script>");

            this.txtCantidadTotalVasos.Text = cv.GetCantidadTotalVasos_fn(valorAñoInt32).ToString() + " Vasos";
            PoblarGrilla();
        }

        /*
         * Recorre todos los CheckBox del GridView para ver los activos y agregarlos a Clones
         */
        protected void btnAgregarClones_Click(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdvVasos.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkClonesAgregar = (row.Cells[0].FindControl("chkClonesAgregar") as CheckBox);

                    if (chkClonesAgregar != null)
                    {
                        if (chkClonesAgregar.Checked)
                        {
                            string id_vasos = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[row.RowIndex].Cells[2].Text);
                            string codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[row.RowIndex].Cells[3].Text);
                            string pad_codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[row.RowIndex].Cells[5].Text);

                            CatalogClones cc = new CatalogClones();                            
                            int existe_clon = cc.AddClones(Int32.Parse(id_vasos), codigo_variedad, pad_codigo_variedad);
                            if (existe_clon == 1)
                                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('El vaso con ID: " + id_vasos + " seleccionado ya tiene un vaso asignado o la cantidad del vaso es igual a 0')</script>");
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