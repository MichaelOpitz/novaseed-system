using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Globalization;

namespace Project.Novaseed
{
    public partial class Clones : System.Web.UI.Page
    {
        private int contFertilidad, contImagen, contCodificado, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            contFertilidad = 0;
            contImagen = 0;
            contCodificado = 0;

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString); 

            if (!Page.IsPostBack)
            {
                this.lblClonesAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvClones.DataSource = cc.GetClones(valorAñoInt32);
                this.gdvClones.DataBind();
            }
        }

        /*
         * Llena la grilla de los clones con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogClones cc = new CatalogClones();
            gdvClones.DataSource = cc.GetClones(valorAñoInt32);
            gdvClones.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW CLONES
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el DropDownList en la fila
                DropDownList ddlClonesFertilidad = (e.Row.FindControl("ddlClonesFertilidad") as DropDownList);
                //Llena el dropdown fertilidad
                CatalogFertilidad cf = new CatalogFertilidad();
                ddlClonesFertilidad.DataSource = cf.getFertilidad();
                ddlClonesFertilidad.DataTextField = "nombre_fertilidad";
                ddlClonesFertilidad.DataValueField = "id_fertilidad";
                ddlClonesFertilidad.DataBind();

                //Selecciona la fertilidad de cada cruzamiento
                int index = cc.GetFertilidadClones(valorAñoInt32, contFertilidad) - 1;
                ddlClonesFertilidad.SelectedIndex = index;
                contFertilidad = contFertilidad + 1;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el CheckBox en la fila
                CheckBox chkClonImagen = (e.Row.FindControl("chkClonImagen") as CheckBox);

                int indexImagen = cc.GetImagenClones(valorAñoInt32, contImagen);

                if (indexImagen == 1)
                    chkClonImagen.Checked = true;
                else
                    chkClonImagen.Checked = false;
                contImagen = contImagen + 1;

            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Ecuentra el CheckBox en la fila
                CheckBox chkEstaCodificado = (e.Row.FindControl("chkEstaCodificado") as CheckBox);

                int indexCodificado = cc.GetEstaCodificado(valorAñoInt32, contCodificado);

                if (indexCodificado == 1)
                    chkEstaCodificado.Checked = true;
                else
                    chkEstaCodificado.Checked = false;
                contCodificado = contCodificado + 1;

            }
        }

        protected void ClonesGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            try
            {
                string id_clones = HttpUtility.HtmlDecode((string)this.gdvClones.Rows[e.RowIndex].Cells[1].Text);

                string posicion_clones = e.NewValues[0].ToString();
                DropDownList ddlClonesFertilidad = (DropDownList)gdvClones.Rows[e.RowIndex].FindControl("ddlClonesFertilidad");
                string id_fertilidad = ddlClonesFertilidad.SelectedValue;

                string azul_clon = e.NewValues[1].ToString();
                string roja_clon = e.NewValues[2].ToString();
                string amarilla_clon = e.NewValues[3].ToString();
                string bicolor_clon = e.NewValues[4].ToString();

                int id_clon = Int32.Parse(id_clones);
                //Reemplaza las comas por los puntos para agregar el valor tipo double en la base de datos
                posicion_clones = posicion_clones.Replace(",",".");
                double posicion = Double.Parse(posicion_clones, CultureInfo.InvariantCulture);
                int id_fertilidadInt32 = Int32.Parse(id_fertilidad);
                int azul = Int32.Parse(azul_clon);
                int roja = Int32.Parse(roja_clon);
                int amarilla = Int32.Parse(amarilla_clon);
                int bicolor = Int32.Parse(bicolor_clon);
                                    

                Project.BusinessRules.Clones clon = new Project.BusinessRules.Clones(id_clon, posicion, id_fertilidadInt32, 
                    azul, roja, amarilla, bicolor);
                cc.UpdateClones(clon);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            this.gdvClones.EditIndex = -1;
            PoblarGrilla();
        }

        protected void ClonesGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvClones.EditIndex = -1;
            PoblarGrilla();
        }

        protected void ClonesGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvClones.EditIndex = e.NewEditIndex;
            PoblarGrilla();
        }

        protected void ClonesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            string id_clones = HttpUtility.HtmlDecode((string)this.gdvClones.Rows[e.RowIndex].Cells[1].Text);
            int valor = cc.DeleteClones(Int32.Parse(id_clones));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el clon!')</script>");

            PoblarGrilla();
        }

        /*
         * Codifica toda la tabla con los colores respectivos de cada clon
         */ 
        protected void btnAgregarCodificacion_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogCodificacion cc = new CatalogCodificacion();
                int valor = cc.AddCodificacion(valorAñoInt32);
                if (valor == 1)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Se agregaron los clones que no tenian codificación!\nEl resto mantienen sus códigos')</script>");
                    Response.Redirect("Codificacion.aspx?valor=" + valorAñoInt32);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Se generó un problema al intentar codificar clones!')</script>");
                    Response.Redirect("Codificacion.aspx?valor=" + valorAñoInt32);
                }
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
        }
    }
}