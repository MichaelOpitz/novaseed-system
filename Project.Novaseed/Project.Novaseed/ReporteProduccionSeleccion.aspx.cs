using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ReporteProduccionSeleccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CatalogProduccion cp = new CatalogProduccion();
                this.gdvProduccion.DataSource = cp.GetTablaProduccionVariedades("");
                this.DataBind();
            }
        }

        /*
         * Llena la grilla de producción
         */
        private void PoblarGrilla(string nombre)
        {
            try
            {
                CatalogProduccion cp = new CatalogProduccion();
                this.gdvProduccion.DataSource = cp.GetTablaProduccionVariedades(nombre);
                this.gdvProduccion.DataBind();
            }
            catch(Exception ex)
            {
            }
        }

        protected void gdvProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdvProduccion.SelectedIndex;
                string id_produccion = HttpUtility.HtmlDecode((string)this.gdvProduccion.Rows[selected].Cells[0].Text);
                string nombre_produccion = HttpUtility.HtmlDecode((string)this.gdvProduccion.Rows[selected].Cells[1].Text);

                Response.Redirect("ReporteProduccion.aspx?id_produccion=" + id_produccion + "&nombre_produccion=" + nombre_produccion);
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnProduccionReporteBuscar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtProduccionReporteBuscar.Text;
            PoblarGrilla(nombre);
        }

        protected void ProduccionGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvProduccion.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvProduccion.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvProduccion.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvProduccion.PageCount.ToString();
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvProduccion.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvProduccion.PageIndex = pageList.SelectedIndex;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvProduccion.PageIndex = pageList.SelectedIndex + 1;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvProduccion.PageIndex = pageList.SelectedIndex - 1;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
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
                gdvProduccion.PageIndex = 0;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvProduccion.PageIndex = pageList.Items.Count;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
            }
            catch (Exception ex)
            {
            }
        }
        protected void ProduccionGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvProduccion.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvProduccion.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvProduccion.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvProduccion.PageCount.ToString();
                }
                this.gdvProduccion.Controls[0].Controls[this.gdvProduccion.Controls[0].Controls.Count - 1].Visible = true;
                string nombre = this.txtProduccionReporteBuscar.Text;
                PoblarGrilla(nombre);
            }
            catch (Exception ex)
            {
            }
        }
    }
}