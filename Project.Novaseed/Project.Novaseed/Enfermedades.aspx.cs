using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class Enfermedades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogEnfermedades ce = new CatalogEnfermedades();
            this.lblEnfermedadesError.Visible = false;
            this.lblEnfermedadesError.Text = "";
            if (!Page.IsPostBack)
            {                
                this.gdvEnfermedades.DataSource = ce.GetEnfermedades();
                this.gdvEnfermedades.DataBind();
            }
        }

        /*
         * Llena la grilla de enfermedades
         */
        private void PoblarGrilla()
        {
            CatalogEnfermedades ce = new CatalogEnfermedades();
            gdvEnfermedades.DataSource = ce.GetEnfermedades();
            gdvEnfermedades.DataBind();
        }

        protected void btnEnfermedadesGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblEnfermedadesError.Visible = true;                
                string nombre_enfermedad = this.txtEnfermedades.Text;
                if (nombre_enfermedad.Length > 1 && nombre_enfermedad.Length < 100)
                {
                    CatalogEnfermedades ce = new CatalogEnfermedades();
                    ce.AddEnfermedad(nombre_enfermedad);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblEnfermedadesError.Text += "Error al ingresar una enfermedad, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW ENFERMEDADES
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CatalogCodificacion cc = new CatalogCodificacion();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    Button btnEdit = (e.Row.FindControl("btnEdit") as Button);
                    Button btnDelete = (e.Row.FindControl("btnDelete") as Button);


                    if (e.Row.Cells[1].Text.Equals("1"))
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void EnfermedadesGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                this.lblEnfermedadesError.Visible = true;
                CatalogEnfermedades ce = new CatalogEnfermedades();
                string id_enfermedad = HttpUtility.HtmlDecode((string)this.gdvEnfermedades.Rows[e.RowIndex].Cells[1].Text);
                string nombre_enfermedad = e.NewValues[0].ToString();

                if (nombre_enfermedad.Length > 1 && nombre_enfermedad.Length < 100)
                    ce.UpdateEnfermedad(Int32.Parse(id_enfermedad), nombre_enfermedad);
                else
                    this.lblEnfermedadesError.Text += "El rango de caracteres del nombre debe ser entre 2 y 99";
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar, repare el parámetro que ingresó!')</script>");
            }

            gdvEnfermedades.EditIndex = -1;
            PoblarGrilla();
        }

        protected void EnfermedadesGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvEnfermedades.EditIndex = -1;
            PoblarGrilla();
        }

        protected void EnfermedadesGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvEnfermedades.EditIndex = e.NewEditIndex;
            PoblarGrilla();
        }

        protected void EnfermedadesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                this.lblEnfermedadesError.Visible = true;
                CatalogEnfermedades ce = new CatalogEnfermedades();
                string id_enfermedad = HttpUtility.HtmlDecode((string)this.gdvEnfermedades.Rows[e.RowIndex].Cells[1].Text);
                int valor = ce.DeleteEnfermedad(Int32.Parse(id_enfermedad));
                if (valor == 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la enfermedad!')</script>");
                    this.lblEnfermedadesError.Text += "No se pudo eliminar, La enfermedad está presente en alguna cosecha.<br/>";
                }

                PoblarGrilla();
            }
            catch (Exception ex)
            {

            }
        }

        protected void EnfermedadesGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvEnfermedades.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvEnfermedades.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvEnfermedades.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvEnfermedades.PageCount.ToString();
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
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvEnfermedades.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
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
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvEnfermedades.PageIndex = pageList.SelectedIndex;
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
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvEnfermedades.PageIndex = pageList.SelectedIndex + 1;
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
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvEnfermedades.PageIndex = pageList.SelectedIndex - 1;
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
                gdvEnfermedades.PageIndex = 0;
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
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvEnfermedades.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void EnfermedadesGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvEnfermedades.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvEnfermedades.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvEnfermedades.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvEnfermedades.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvEnfermedades.PageCount.ToString();
                }
                this.gdvEnfermedades.Controls[0].Controls[this.gdvEnfermedades.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}