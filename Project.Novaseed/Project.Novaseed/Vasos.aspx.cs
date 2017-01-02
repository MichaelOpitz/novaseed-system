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
    public partial class Vasos : System.Web.UI.Page
    {
        private int contFertilidad, contVasosClones, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            contFertilidad = 0;
            contVasosClones = 0;

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            this.lblVasosError.Visible = false;
            this.lblVasosError.Text = "";
            if (!Page.IsPostBack)
            {
                this.txtCantidadTotalVasos.Text = cv.GetCantidadTotalVasos_fn(valorAñoInt32).ToString() + " Vasos";
                this.lblVasosAño.Text += "("+valorAñoInt32.ToString()+")";
                this.gdvVasos.DataSource = cv.GetVasos(valorAñoInt32);
                this.gdvVasos.DataBind();
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
            try
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

                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    int indexVasosClones = cv.GetVasosEstaEnClones(valorAñoInt32, contVasosClones);

                    //Ecuentra el CheckBox en la fila
                    CheckBox chkClonesAgregar = (e.Row.FindControl("chkClonesAgregar") as CheckBox);
                    if (indexVasosClones == 1)
                    {
                        e.Row.BackColor = Color.LightGreen;
                        chkClonesAgregar.Enabled = false;
                    }
                    else
                    {
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                        chkClonesAgregar.Enabled = true;
                    }
                    contVasosClones = contVasosClones + 1;
                }
            }
            catch (Exception ex) 
            { 
            }
        }

        protected void VasosGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogVasos cv = new CatalogVasos();
            try
            {
                this.lblVasosError.Visible = true;
                int invalido = 0;
                string id_vasos = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[e.RowIndex].Cells[2].Text);

                //ubicacion
                string ubicacion_vasos = e.NewValues[0].ToString();
                if (ubicacion_vasos.Length == 3)
                {
                    string uvPrimero = ubicacion_vasos.Substring(0, 1);
                    string uvSegundo = ubicacion_vasos.Substring(1, 1);
                    string uvTercero = ubicacion_vasos.Substring(2, 1);
                    if (EsNumero(uvPrimero) == false || EsNumero(uvSegundo) == true || EsNumero(uvTercero) == false)
                    {
                        this.lblVasosError.Text += "Ubicación incorrecta, Ejemplo '1D1' o '1I1'.<br/>";
                        invalido = 1;
                    }
                }
                else
                {
                    this.lblVasosError.Text += "Ubicación incorrecta, Ejemplo '1D1' o '1I1'.<br/>";
                    invalido = 1;
                }

                //cantidad papas
                int cantidad = 0;
                string cantidad_vasos = e.NewValues[1].ToString();
                if ((EsNumero(cantidad_vasos) == true && (Int32.Parse(cantidad_vasos) < 0 || Int32.Parse(cantidad_vasos) > 999)) || (EsNumero(cantidad_vasos) == false))
                {
                    this.lblVasosError.Text += "La cantidad de vasos debe ser un número positivo menor a 999.<br/>";
                    invalido = 1;
                }
                else
                    cantidad = Int32.Parse(cantidad_vasos);
                
                //fertilidad
                DropDownList ddlVasosFertilidad = (DropDownList)gdvVasos.Rows[e.RowIndex].FindControl("ddlVasosFertilidad");
                string id_fertilidad = ddlVasosFertilidad.SelectedValue;

                //azules
                int azul=0;
                string azul_vasos = e.NewValues[2].ToString();
                if ((EsNumero(azul_vasos) == true && (Int32.Parse(azul_vasos) < 0 || Int32.Parse(azul_vasos) > 15)) || (EsNumero(azul_vasos) == false))
                {
                    this.lblVasosError.Text += "Las azules deben ser un número positivo menor a 15.<br/>";
                    invalido = 1;
                }
                else
                    azul = Int32.Parse(azul_vasos);

                //rojas
                int roja = 0;
                string roja_vasos = e.NewValues[3].ToString();
                if ((EsNumero(roja_vasos) == true && (Int32.Parse(roja_vasos) < 0 || Int32.Parse(roja_vasos) > 15)) || (EsNumero(roja_vasos) == false))
                {
                    this.lblVasosError.Text += "Las rojas deben ser un número positivo menor a 15.<br/>";
                    invalido = 1;
                }
                else
                    roja = Int32.Parse(roja_vasos);

                //amarillas
                int amarilla = 0;
                string amarilla_vasos = e.NewValues[4].ToString();
                if ((EsNumero(amarilla_vasos) == true && (Int32.Parse(amarilla_vasos) < 0 || Int32.Parse(amarilla_vasos) > 15)) || (EsNumero(amarilla_vasos) == false))
                {
                    this.lblVasosError.Text += "Las amarillas deben ser un número positivo menor a 15.<br/>";
                    invalido = 1;
                }
                else
                    amarilla = Int32.Parse(amarilla_vasos);

                //bicolores
                int bicolor = 0;
                string bicolor_vasos = e.NewValues[5].ToString();
                if ((EsNumero(bicolor_vasos) == true && (Int32.Parse(bicolor_vasos) < 0 || Int32.Parse(bicolor_vasos) > 15)) || (EsNumero(bicolor_vasos) == false))
                {
                    this.lblVasosError.Text += "Las bicolores deben ser un número positivo menor a 15.<br/>";
                    invalido = 1;
                }
                else
                    bicolor = Int32.Parse(bicolor_vasos);

                if (invalido == 0)
                {
                    int suma = azul + roja + amarilla + bicolor;
                    if (suma > cantidad)
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La suma de azules, rojas, amarillas y bicolores(" + suma + ") no debe ser mayor a la cantidad total(" + cantidad + ") del vaso')</script>");

                    Project.BusinessRules.Vasos vasos = new Project.BusinessRules.Vasos(Int32.Parse(id_vasos),
                            ubicacion_vasos, cantidad, Int32.Parse(id_fertilidad),
                            azul, roja, amarilla, bicolor);
                    cv.UpdateVasos(vasos);
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar, repare los parámetros que ingresó!')</script>");
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
            try
            {
                CatalogVasos cv = new CatalogVasos();
                string id_vasos = HttpUtility.HtmlDecode((string)this.gdvVasos.Rows[e.RowIndex].Cells[2].Text);
                int valor = cv.DeleteVasos(Int32.Parse(id_vasos));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar el vaso')</script>");

                this.txtCantidadTotalVasos.Text = cv.GetCantidadTotalVasos_fn(valorAñoInt32).ToString() + " Vasos";
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
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

        protected void VasosGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvVasos.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvVasos.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvVasos.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvVasos.PageCount.ToString();
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
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvVasos.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
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
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvVasos.PageIndex = pageList.SelectedIndex;
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
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvVasos.PageIndex = pageList.SelectedIndex + 1;
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
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvVasos.PageIndex = pageList.SelectedIndex - 1;
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
                gdvVasos.PageIndex = 0;
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
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvVasos.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void VasosGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvVasos.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvVasos.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvVasos.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvVasos.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvVasos.PageCount.ToString();
                }
                this.gdvVasos.Controls[0].Controls[this.gdvVasos.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}