﻿using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ProduccionFiltrarVariedad : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["ano_produccion"] != null)
                valorAñoString = Request.QueryString["ano_produccion"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblProduccionAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvProduccion.DataSource = cp.GetFiltrarProduccionPorVariedad(valorAñoInt32);
                this.gdvProduccion.DataBind();
            }
        }

        /*
         * Llena la grilla de produccion con el año seleccionado
         */
        private void PoblarGrilla()
        {
            try
            {
                CatalogProduccion cp = new CatalogProduccion();
                this.gdvProduccion.DataSource = cp.GetFiltrarProduccionPorVariedad(valorAñoInt32);
                this.gdvProduccion.DataBind();
            }
            catch (Exception ex)
            {
            }
        }

        //pregunta si la licencia es true para cambiarlo a "si" o false para cambiarlo a "no"
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.Cells[9].Text == "True")
                        e.Row.Cells[9].Text = "Si";
                    else
                        e.Row.Cells[9].Text = "No";
                }
            }
            catch (Exception ex)
            {
            }
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvProduccion.PageIndex = pageList.SelectedIndex;
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvProduccion.PageIndex = pageList.SelectedIndex + 1;
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvProduccion.PageIndex = pageList.SelectedIndex - 1;
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
                gdvProduccion.PageIndex = 0;
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
                GridViewRow pagerRow = gdvProduccion.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvProduccion.PageIndex = pageList.Items.Count;
                PoblarGrilla();
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
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}