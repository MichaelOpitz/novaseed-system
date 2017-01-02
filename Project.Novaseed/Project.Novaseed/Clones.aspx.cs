using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Globalization;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class Clones : System.Web.UI.Page
    {
        private int contFertilidad, contImagen, contClonesCodificacion, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            contFertilidad = 0;
            contImagen = 0;
            contClonesCodificacion = 0;

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            this.lblClonesError.Visible = false;
            this.lblClonesError.Text = "";
            if (!Page.IsPostBack)
            {
                this.lblClonesAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvClones.DataSource = cc.GetClones(valorAñoInt32);
                this.gdvClones.DataBind();
            }
        }

        /*
         * Verifica si es un entero
         */
        public bool EsNumero(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        /*
         * Llena la grilla de los clones con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogClones cc = new CatalogClones();
            this.gdvClones.DataSource = cc.GetClones(valorAñoInt32);
            this.gdvClones.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW CLONES
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
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
                    int indexClonesCodificacion = cc.GetClonesEstaCodificado(valorAñoInt32, contClonesCodificacion);

                    if (indexClonesCodificacion == 1)
                        e.Row.BackColor = Color.LightGreen;
                    else
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                    contClonesCodificacion = contClonesCodificacion + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void ClonesGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogClones cc = new CatalogClones();
            try
            {
                this.lblClonesError.Visible = true;
                string id_clones = HttpUtility.HtmlDecode((string)this.gdvClones.Rows[e.RowIndex].Cells[1].Text);
                
                DropDownList ddlClonesFertilidad = (DropDownList)gdvClones.Rows[e.RowIndex].FindControl("ddlClonesFertilidad");
                string id_fertilidad = ddlClonesFertilidad.SelectedValue;

                string azul_clon = e.NewValues[1].ToString();
                if (EsNumero(azul_clon) == false)
                    this.lblClonesError.Text += "Las azules deben ser un número. ";
                string roja_clon = e.NewValues[2].ToString();
                if (EsNumero(roja_clon) == false)
                    this.lblClonesError.Text += "Las rojas deben ser un número. ";
                string amarilla_clon = e.NewValues[3].ToString();
                if (EsNumero(amarilla_clon) == false)
                    this.lblClonesError.Text += "Las amarillas deben ser un número. ";
                string bicolor_clon = e.NewValues[4].ToString();
                if (EsNumero(bicolor_clon) == false)
                    this.lblClonesError.Text += "Las bicolores deben ser un número. ";

                int id_clon = Int32.Parse(id_clones);
                if (EsNumero(azul_clon) == true && EsNumero(roja_clon) == true && EsNumero(amarilla_clon) == true && 
                    EsNumero(bicolor_clon) == true)
                {
                    int id_fertilidadInt32 = Int32.Parse(id_fertilidad);
                    int azul = Int32.Parse(azul_clon);
                    if (azul < 0)
                    {
                        azul = 0;
                        this.lblClonesError.Text += "Las azules deben ser un número positivo. ";
                    }
                    int roja = Int32.Parse(roja_clon);
                    if (roja < 0)
                    {
                        roja = 0;
                        this.lblClonesError.Text += "Las rojas deben ser un número positivo. ";
                    }
                    int amarilla = Int32.Parse(amarilla_clon);
                    if (amarilla < 0)
                    {
                        amarilla = 0;
                        this.lblClonesError.Text += "Las amarillas deben ser un número positivo. ";
                    }
                    int bicolor = Int32.Parse(bicolor_clon);
                    if (bicolor < 0)
                    {
                        bicolor = 0;
                        this.lblClonesError.Text += "Las bicolores deben ser un número positivo. ";
                    }

                    Project.BusinessRules.Clones clon = new Project.BusinessRules.Clones(id_clon, id_fertilidadInt32,
                        azul, roja, amarilla, bicolor);
                    cc.UpdateClones(clon);
                }
                this.gdvClones.EditIndex = -1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }            
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
            try
            {
                CatalogClones cc = new CatalogClones();
                string id_clones = HttpUtility.HtmlDecode((string)this.gdvClones.Rows[e.RowIndex].Cells[1].Text);
                int valor = cc.DeleteClones(Int32.Parse(id_clones));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar el clon')</script>");

                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
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
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Se agregaron los clones que no tenian codificación! El resto mantienen sus códigos')</script>");
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

        protected void ClonesGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvClones.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvClones.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvClones.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvClones.PageCount.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvClones.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvClones.PageIndex = pageList.SelectedIndex;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Siguiente página
        protected void NextLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvClones.PageIndex = pageList.SelectedIndex + 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página anterior
        protected void PrevLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvClones.PageIndex = pageList.SelectedIndex - 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página inicio
        protected void FirstLB_Click(object sender, EventArgs e)
        {
            try
            {
                gdvClones.PageIndex = 0;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página final
        protected void LastLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvClones.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void ClonesGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvClones.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvClones.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvClones.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvClones.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvClones.PageCount.ToString();
                }
                this.gdvClones.Controls[0].Controls[this.gdvClones.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}