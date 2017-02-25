using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ReporteVariedadSeleccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CatalogVariedad cv = new CatalogVariedad();
                this.gdvVariedad.DataSource = cv.GetTablaVariedadVariedades("");
                this.DataBind();
            }
        }

        /*
         * Llena la grilla de variedad
         */
        private void PoblarGrilla(string nombre)
        {
            try
            {
                CatalogVariedad cv = new CatalogVariedad();
                this.gdvVariedad.DataSource = cv.GetTablaVariedadVariedades(nombre);
                this.gdvVariedad.DataBind();
            }
            catch (Exception ex)
            {
            }
        }

        protected void gdvVariedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdvVariedad.SelectedIndex;
            string codigo_variedad = HttpUtility.HtmlDecode((string)this.gdvVariedad.Rows[selected].Cells[0].Text);
            string nombre_variedad = HttpUtility.HtmlDecode((string)this.gdvVariedad.Rows[selected].Cells[1].Text);

            Response.Redirect("ReporteVariedad.aspx?codigo_variedad=" + codigo_variedad + "&nombre_variedad=" + nombre_variedad);
        }

        protected void btnVariedadReporteBuscar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtVariedadReporteBuscar.Text;
            PoblarGrilla(nombre);
        }

        protected void VariedadGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvVariedad.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvVariedad.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvVariedad.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvVariedad.PageCount.ToString();
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
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvVariedad.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                string nombre = this.txtVariedadReporteBuscar.Text;
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
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvVariedad.PageIndex = pageList.SelectedIndex;
                string nombre = this.txtVariedadReporteBuscar.Text;
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
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvVariedad.PageIndex = pageList.SelectedIndex + 1;
                string nombre = this.txtVariedadReporteBuscar.Text;
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
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvVariedad.PageIndex = pageList.SelectedIndex - 1;
                string nombre = this.txtVariedadReporteBuscar.Text;
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
                gdvVariedad.PageIndex = 0;
                string nombre = this.txtVariedadReporteBuscar.Text;
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
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvVariedad.PageIndex = pageList.Items.Count;
                string nombre = this.txtVariedadReporteBuscar.Text;
                PoblarGrilla(nombre);
            }
            catch (Exception ex)
            {
            }
        }
        protected void VariedadGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvVariedad.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvVariedad.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvVariedad.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvVariedad.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvVariedad.PageCount.ToString();
                }
                this.gdvVariedad.Controls[0].Controls[this.gdvVariedad.Controls[0].Controls.Count - 1].Visible = true;
                string nombre = this.txtVariedadReporteBuscar.Text;
                PoblarGrilla(nombre);
            }
            catch (Exception ex)
            {
            }
        }
    }
}