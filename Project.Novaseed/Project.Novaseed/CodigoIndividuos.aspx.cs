using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class CodigoIndividuos : System.Web.UI.Page
    {
        private int valorAñoInt32, contCodificacionCosecha;
        private string valorAñoString, codigo_variedad, pad_codigo_variedad;

        protected void Page_Load(object sender, EventArgs e)
        {
            contCodificacionCosecha = 0;
            CatalogCodificacion cc = new CatalogCodificacion();

            if (Request.QueryString["valorMadre"] != null && Request.QueryString["valorPadre"] != null && Request.QueryString["ano_codificacion"] != null)
            {
                codigo_variedad = Request.QueryString["valorMadre"];
                pad_codigo_variedad = Request.QueryString["valorPadre"];
                valorAñoString = Request.QueryString["ano_codificacion"];
                this.txtCodificacionMadre.Text = codigo_variedad;
                this.txtCodificacionPadre.Text = pad_codigo_variedad;
                this.txtCodificacionAño.Text = valorAñoString;
            }
            else
            {
                codigo_variedad = "0";
                pad_codigo_variedad = "0";
                valorAñoString = "0";
            }
            valorAñoInt32 = Int32.Parse(valorAñoString);

            this.lblCodificacionError.Visible = false;
            this.lblCodificacionError.Text = "";
            if (!Page.IsPostBack)
            {
                this.gdvCodigoIndividuos.DataSource = cc.GetCodificacion(codigo_variedad, pad_codigo_variedad, valorAñoInt32);
                this.gdvCodigoIndividuos.DataBind();                
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
        * Llena la grilla de los individuos codificados en el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            this.gdvCodigoIndividuos.DataSource = cc.GetCodificacion(codigo_variedad, pad_codigo_variedad, valorAñoInt32);
            this.gdvCodigoIndividuos.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW CODIFICACION
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CatalogCodificacion cc = new CatalogCodificacion();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    string codigo_variedad = this.txtCodificacionMadre.Text;
                    string pad_codigo_variedad = this.txtCodificacionPadre.Text;
                    int indexCodificacionCosecha = cc.GetCodificacionEstaEnCosecha(codigo_variedad, pad_codigo_variedad,
                        valorAñoInt32, contCodificacionCosecha);

                    //Ecuentra el CheckBox en la fila
                    CheckBox chkAgregar6Papas = (e.Row.FindControl("chkAgregar6Papas") as CheckBox);
                    //Ecuentra el Button en la fila
                    Button btnEdit = (e.Row.FindControl("btnEdit") as Button);
                    if (indexCodificacionCosecha == 1)
                    {
                        e.Row.BackColor = Color.LightGreen;
                        chkAgregar6Papas.Enabled = false;
                        btnEdit.Enabled = false;
                    }
                    else
                    {
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                        chkAgregar6Papas.Enabled = true;
                    }
                    contCodificacionCosecha = contCodificacionCosecha + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void CodigoIndividuosGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            try
            {
                this.lblCodificacionError.Visible = true;
                string id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[e.RowIndex].Cells[1].Text);
                string codigo_individuo = e.NewValues[0].ToString().ToLower();

                //azul
                string c = codigo_individuo.Substring(0,1);
                string b = codigo_individuo.Substring(1,1);
                //roja
                string r = codigo_individuo.Substring(1,1);
                //amarilla
                string t = codigo_individuo.Substring(0,1);
                string y = codigo_individuo.Substring(1,1);
                //bicolor
                string bi = codigo_individuo.Substring(0,1);
                string ci = codigo_individuo.Substring(1,1);
                //año
                bool año = EsNumero(codigo_individuo.Substring(2,4));
                //guion
                string guion = codigo_individuo.Substring(6,1);
                //número de color
                bool num_color1 = EsNumero(codigo_individuo.Substring(7));

                bool error = false;
                //if código azul
                if ((!codigo_individuo.Equals("") && c.Equals("c") && b.Equals("b")) &&
                    (año != true || !guion.Equals("-") || num_color1!=true))
                {
                    this.lblCodificacionError.Text += "Código color azul incorrecto, Ejemplo: 'cb2016-001'. ";
                    error = true;                                    
                }
                //if código rojo
                if ((!codigo_individuo.Equals("") && c.Equals("c") && r.Equals("r")) &&
                    (año != true || !guion.Equals("-") || num_color1 != true))
                {
                    this.lblCodificacionError.Text += "Código color rojo incorrecto, Ejemplo: 'cr2016-001'. ";
                    error = true;
                }
                //if código amarilla
                if ((!codigo_individuo.Equals("") && t.Equals("t") && y.Equals("y")) &&
                    (año != true || !guion.Equals("-") || num_color1 != true))
                {
                    this.lblCodificacionError.Text += "Código color amarillo incorrecto, Ejemplo: 'ty2016-001'. ";
                    error = true;
                }
                //if código bicolor
                if ((!codigo_individuo.Equals("") && bi.Equals("b") && ci.Equals("c")) &&
                    (año != true || !guion.Equals("-") || num_color1 != true))
                {
                    this.lblCodificacionError.Text += "Código bicolor incorrecto, Ejemplo: 'bc2016-001'. ";
                    error = true;
                }
                //if otro código
                if (!codigo_individuo.Equals("") &&
                    (!c.Equals("c") || !b.Equals("b")) &&
                    (!c.Equals("c") || !r.Equals("r")) &&
                    (!t.Equals("t") || !y.Equals("y")) &&
                    (!bi.Equals("b") || !ci.Equals("c")))
                {
                    this.lblCodificacionError.Text += "Código incorrecto. ";
                    error = true;
                }                  

                if (error == false)
                {
                    string año1 = codigo_individuo.Substring(2,1);
                    string año2 = codigo_individuo.Substring(3,1);
                    string año3 = codigo_individuo.Substring(4,1);
                    string año4 = codigo_individuo.Substring(5,1);
                    string añoConcatenado = año1 + año2 + año3 + año4;
                    //pregunta si el año seleccionado es el mismo al año del codigo
                    if (!añoConcatenado.Equals(valorAñoString))
                        this.lblCodificacionError.Text += "Año incorrecto, debe ser el mismo seleccionado. ";
                    else
                    {
                        Project.BusinessRules.Codificacion cod = new Project.BusinessRules.Codificacion(Int32.Parse(id_codificacion), codigo_individuo);
                        int valor = cc.UpdateCodificacion(cod);

                        if (valor == 0)
                            Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡No se pudo modificar debido a que el código escrito ya existe en el año!')</script>");
                    }
                }
                this.gdvCodigoIndividuos.EditIndex = -1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }            
        }

        protected void CodigoIndividuosGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvCodigoIndividuos.EditIndex = -1;
            PoblarGrilla();
        }

        protected void CodigoIndividuosGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvCodigoIndividuos.EditIndex = e.NewEditIndex;
            PoblarGrilla();   
        }

        protected void CodigoIndividuosGridView_PageIndexChanging(Object sender, GridViewPageEventArgs e)
        {
            this.gdvCodigoIndividuos.PageIndex = e.NewPageIndex;
            PoblarGrilla();
        }        

        protected void CodigoIndividuosGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogCodificacion cc = new CatalogCodificacion();
                string id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[e.RowIndex].Cells[1].Text);
                int valor = cc.DeleteCodificacion(Int32.Parse(id_codificacion));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar el código')</script>");

                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnAgregar6papas_Click(object sender, EventArgs e)
        {
            try
            {
                int agrego = 0;
                string id_codificacion = "";
                foreach (GridViewRow row in gdvCodigoIndividuos.Rows)
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkAgregar6Papas = (row.Cells[3].FindControl("chkAgregar6Papas") as CheckBox);

                        if (chkAgregar6Papas != null)
                        {
                            if (chkAgregar6Papas.Checked)
                            {
                                id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[row.RowIndex].Cells[1].Text);

                                CatalogCosecha cc = new CatalogCosecha();
                                int existe_6papas = cc.AddCosecha6papas(Int32.Parse(id_codificacion));
                                if (existe_6papas == 0)
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
                else
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La codificacion con ID: " + id_codificacion + " seleccionado ya está en temporada de 6 papas')</script>");
            }
            catch (Exception ex)
            {
            }
        }

        protected void CodigoIndividuosGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvCodigoIndividuos.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCodigoIndividuos.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvCodigoIndividuos.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCodigoIndividuos.PageCount.ToString();
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
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvCodigoIndividuos.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
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
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvCodigoIndividuos.PageIndex = pageList.SelectedIndex;
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
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvCodigoIndividuos.PageIndex = pageList.SelectedIndex + 1;
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
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvCodigoIndividuos.PageIndex = pageList.SelectedIndex - 1;
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
                gdvCodigoIndividuos.PageIndex = 0;
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
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvCodigoIndividuos.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void CodigoIndividuosGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCodigoIndividuos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvCodigoIndividuos.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCodigoIndividuos.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvCodigoIndividuos.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCodigoIndividuos.PageCount.ToString();
                }
                this.gdvCodigoIndividuos.Controls[0].Controls[this.gdvCodigoIndividuos.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}