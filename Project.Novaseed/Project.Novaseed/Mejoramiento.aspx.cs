﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class Mejoramiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogTamaño ct = new CatalogTamaño();
            List<Project.BusinessRules.Tamaño> tamaño = ct.GetTamaño();
            CatalogMadurez cm = new CatalogMadurez();
            List<Project.BusinessRules.Madurez> madurez = cm.GetMadurez();
            CatalogFormaTuberculos cft = new CatalogFormaTuberculos();
            List<Project.BusinessRules.FormaTuberculos> forma = cft.GetFormaTuberculos();
            CatalogDistribucionCalibre cdc = new CatalogDistribucionCalibre();
            List<Project.BusinessRules.DistribucionCalibre> distribucion = cdc.GetDistribucionCalibre();
            CatalogProfundidadOjo cpo = new CatalogProfundidadOjo();
            List<Project.BusinessRules.ProfundidadOjo> profundidad = cpo.GetProfundidadOjo();
            CatalogRegularidad cr = new CatalogRegularidad();
            List<Project.BusinessRules.Regularidad> regularidad = cr.GetRegularidad();
            CatalogBrotacion cb = new CatalogBrotacion();
            List<Project.BusinessRules.Brotacion> brotacion = cb.GetBrotacion();
            CatalogEmergencia ce = new CatalogEmergencia();
            List<Project.BusinessRules.Emergencia> emergencia = ce.GetEmergencia();

            CatalogEmergencia40Dias ce40 = new CatalogEmergencia40Dias();
            List<Project.BusinessRules.Emergencia40Dias> emergencia40 = ce40.GetEmergencia40Dias();
            CatalogMetribuzina cmet = new CatalogMetribuzina();
            List<Project.BusinessRules.Metribuzina> metribuzina = cmet.GetMetribuzina();
            CatalogTuberculosVerdes ctv = new CatalogTuberculosVerdes();
            List<Project.BusinessRules.TuberculosVerdes> verdes = ctv.GetTuberculosVerdes();
            CatalogTizonTardioFollaje cttf = new CatalogTizonTardioFollaje();
            List<Project.BusinessRules.TizonTardioFollaje> tizon_follaje = cttf.GetTizonTardioFollaje();
            CatalogTizonTardioTuberculo cttt = new CatalogTizonTardioTuberculo();
            List<Project.BusinessRules.TizonTardioTuberculo> tizon_tuberculo = cttt.GetTizonTardioTuberculo();
            CatalogNumeroTuberculos cnt = new CatalogNumeroTuberculos();
            List<Project.BusinessRules.NumeroTuberculos> numero = cnt.GetNumeroTuberculos();
            CatalogFertilidad cf = new CatalogFertilidad();
            List<Project.BusinessRules.Fertilidad> fertilidad = cf.GetFertilidad();
            CatalogDestino cd = new CatalogDestino();
            List<Project.BusinessRules.Destino> destino = cd.GetDestino();

            this.gdvCaracteristicaMadre.Visible = true;
            this.gdvCaracteristicaPadre.Visible = true;            

            if (!Page.IsPostBack)
            {
                this.ddlMejoramientoTamaño.DataValueField = "id_tamaño";
                this.ddlMejoramientoTamaño.DataTextField = "nombre_tamaño";
                this.ddlMejoramientoTamaño.DataSource = tamaño;
                this.ddlMejoramientoMadurez.DataValueField = "id_madurez";
                this.ddlMejoramientoMadurez.DataTextField = "nombre_madurez";
                this.ddlMejoramientoMadurez.DataSource = madurez;
                this.ddlMejoramientoForma.DataValueField = "id_forma";
                this.ddlMejoramientoForma.DataTextField = "nombre_forma";
                this.ddlMejoramientoForma.DataSource = forma;
                this.ddlMejoramientoDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddlMejoramientoDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddlMejoramientoDistribucion.DataSource = distribucion;
                this.ddlMejoramientoProfundidad.DataValueField = "id_profundidad";
                this.ddlMejoramientoProfundidad.DataTextField = "profundidad_ojo";
                this.ddlMejoramientoProfundidad.DataSource = profundidad;
                this.ddlMejoramientoRegularidad.DataValueField = "id_regularidad";
                this.ddlMejoramientoRegularidad.DataTextField = "nombre_regularidad";
                this.ddlMejoramientoRegularidad.DataSource = regularidad;
                this.ddlMejoramientoBrotacion.DataValueField = "id_brotacion";
                this.ddlMejoramientoBrotacion.DataTextField = "nombre_brotacion";
                this.ddlMejoramientoBrotacion.DataSource = brotacion;
                this.ddlMejoramientoEmergencia.DataValueField = "id_emergencia";
                this.ddlMejoramientoEmergencia.DataTextField = "nombre_emergencia";
                this.ddlMejoramientoEmergencia.DataSource = emergencia;

                this.ddlMejoramientoEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddlMejoramientoEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddlMejoramientoEmergencia40.DataSource = emergencia40;
                this.ddlMejoramientoMetribuzina.DataValueField = "id_metribuzina";
                this.ddlMejoramientoMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddlMejoramientoMetribuzina.DataSource = metribuzina;
                this.ddlMejoramientoTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddlMejoramientoTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddlMejoramientoTuberculosVerdes.DataSource = verdes;
                this.ddlMejoramientoTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddlMejoramientoTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddlMejoramientoTizonFollaje.DataSource = tizon_follaje;
                this.ddlMejoramientoTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddlMejoramientoTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddlMejoramientoTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddlMejoramientoNumero.DataValueField = "id_numero_tuberculos";
                this.ddlMejoramientoNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddlMejoramientoNumero.DataSource = numero;
                this.ddlMejoramientoFertilidad.DataValueField = "id_fertilidad";
                this.ddlMejoramientoFertilidad.DataTextField = "nombre_fertilidad";
                this.ddlMejoramientoFertilidad.DataSource = fertilidad;
                this.ddlMejoramientoDestino.DataValueField = "id_destino";
                this.ddlMejoramientoDestino.DataTextField = "nombre_destino";
                this.ddlMejoramientoDestino.DataSource = destino;
                this.DataBind();
            }
        }

        /*
         * METODO QUE PINTA DE COLOR EL DROPDOWNLIST SELECCIONADO
         */ 
        private void SeleccionDropDown()
        {
            if (this.ddlMejoramientoTamaño.SelectedIndex > 0)
                this.ddlMejoramientoTamaño.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTamaño.BackColor = Color.Transparent;
            if (this.ddlMejoramientoMadurez.SelectedIndex > 0)
                this.ddlMejoramientoMadurez.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoMadurez.BackColor = Color.Transparent;
            if (this.ddlMejoramientoForma.SelectedIndex > 0)
                this.ddlMejoramientoForma.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoForma.BackColor = Color.Transparent;
            if (this.ddlMejoramientoDistribucion.SelectedIndex > 0)
                this.ddlMejoramientoDistribucion.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoDistribucion.BackColor = Color.Transparent;
            if (this.ddlMejoramientoProfundidad.SelectedIndex > 0)
                this.ddlMejoramientoProfundidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoProfundidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoRegularidad.SelectedIndex > 0)
                this.ddlMejoramientoRegularidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoRegularidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoBrotacion.SelectedIndex > 0)
                this.ddlMejoramientoBrotacion.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoBrotacion.BackColor = Color.Transparent;
            if (this.ddlMejoramientoEmergencia.SelectedIndex > 0)
                this.ddlMejoramientoEmergencia.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoEmergencia.BackColor = Color.Transparent;
            if (this.ddlMejoramientoEmergencia40.SelectedIndex > 0)
                this.ddlMejoramientoEmergencia40.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoEmergencia40.BackColor = Color.Transparent;
            if (this.ddlMejoramientoMetribuzina.SelectedIndex > 0)
                this.ddlMejoramientoMetribuzina.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoMetribuzina.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTuberculosVerdes.SelectedIndex > 0)
                this.ddlMejoramientoTuberculosVerdes.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTuberculosVerdes.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTizonFollaje.SelectedIndex > 0)
                this.ddlMejoramientoTizonFollaje.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTizonFollaje.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTizonTuberculo.SelectedIndex > 0)
                this.ddlMejoramientoTizonTuberculo.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTizonTuberculo.BackColor = Color.Transparent;
            if (this.ddlMejoramientoNumero.SelectedIndex > 0)
                this.ddlMejoramientoNumero.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoNumero.BackColor = Color.Transparent;
            if (this.ddlMejoramientoFertilidad.SelectedIndex > 0)
                this.ddlMejoramientoFertilidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoFertilidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoDestino.SelectedIndex > 0)
                this.ddlMejoramientoDestino.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoDestino.BackColor = Color.Transparent;
        }

        /*
         * METODO QUE REINICIA TODOS LOS DROPDOWNLIST DE LAS CARACTERISTICAS
         */ 
        private void RefreshDropDown()
        {
            this.ddlMejoramientoTamaño.SelectedIndex = 0;
            this.ddlMejoramientoMadurez.SelectedIndex = 0;
            this.ddlMejoramientoForma.SelectedIndex = 0;            
            this.ddlMejoramientoDistribucion.SelectedIndex = 0;            
            this.ddlMejoramientoProfundidad.SelectedIndex = 0;
            this.ddlMejoramientoRegularidad.SelectedIndex = 0;            
            this.ddlMejoramientoBrotacion.SelectedIndex = 0;
            this.ddlMejoramientoEmergencia.SelectedIndex = 0;
            this.ddlMejoramientoEmergencia40.SelectedIndex = 0;
            this.ddlMejoramientoMetribuzina.SelectedIndex = 0;
            this.ddlMejoramientoTuberculosVerdes.SelectedIndex = 0;
            this.ddlMejoramientoTizonFollaje.SelectedIndex = 0;
            this.ddlMejoramientoTizonTuberculo.SelectedIndex = 0;
            this.ddlMejoramientoNumero.SelectedIndex = 0;
            this.ddlMejoramientoFertilidad.SelectedIndex = 0;
            this.ddlMejoramientoDestino.SelectedIndex = 0;
        }

        /*
         * BOTON QUE BUSCA CARACTERISTICAS EN LA MADRE
         */
        protected void btnCaracteristicaMadre_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogMadre madre = new CatalogMadre();
                List<Madre> lista = new List<Madre>();

                //PRIMERO BUSCA POR NOMBRE DE VARIEDAD, SINO POR CARACTERISTICAS
                if (this.txtMadre.Text.Equals(""))
                {                    
                    string tamaño = this.ddlMejoramientoTamaño.SelectedValue;
                    string madurez = this.ddlMejoramientoMadurez.SelectedValue;
                    string forma = this.ddlMejoramientoForma.SelectedValue;
                    string distribucion = this.ddlMejoramientoDistribucion.SelectedValue;
                    string profundidad = this.ddlMejoramientoProfundidad.SelectedValue;
                    string regularidad = this.ddlMejoramientoRegularidad.SelectedValue;
                    string brotacion = this.ddlMejoramientoBrotacion.SelectedValue;
                    string emergencia = this.ddlMejoramientoEmergencia.SelectedValue;
                    string emergencia40 = this.ddlMejoramientoEmergencia40.SelectedValue;
                    string metribuzina = this.ddlMejoramientoMetribuzina.SelectedValue;
                    string verdes = this.ddlMejoramientoTuberculosVerdes.SelectedValue;
                    string tizon_follaje = this.ddlMejoramientoTizonFollaje.SelectedValue;
                    string tizon_tuberculo = this.ddlMejoramientoTizonTuberculo.SelectedValue;
                    string numero = this.ddlMejoramientoNumero.SelectedValue;
                    string fertilidad = this.ddlMejoramientoFertilidad.SelectedValue;
                    string destino = this.ddlMejoramientoDestino.SelectedValue;
                    Madre mama = new Madre(Int32.Parse(tamaño), Int32.Parse(madurez),
                        Int32.Parse(forma), Int32.Parse(distribucion), Int32.Parse(profundidad), Int32.Parse(regularidad),
                        Int32.Parse(brotacion), Int32.Parse(emergencia), Int32.Parse(emergencia40),
                        Int32.Parse(metribuzina), Int32.Parse(verdes), Int32.Parse(tizon_follaje), Int32.Parse(tizon_tuberculo),
                        Int32.Parse(numero), Int32.Parse(fertilidad), Int32.Parse(destino));
                    lista = madre.GetMadre(mama);
                }
                else
                {
                    RefreshDropDown();                    
                    string nombre = this.txtMadre.Text;
                    lista = madre.GetMadreNombre(nombre);
                }

                this.gdvCaracteristicaMadre.DataSource = lista;
                this.gdvCaracteristicaMadre.DataBind();
            }
            catch (Exception ex)
            {
            }
        }

        /*
         * BOTON QUE BUSCA CARACTERISTICAS EN EL PADRE
         */
        protected void btnCaracteristicaPadre_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogPadre padre = new CatalogPadre();
                List<Padre> lista = new List<Padre>();

                //PRIMERO BUSCA POR NOMBRE DE VARIEDAD, SINO POR CARACTERISTICAS
                if (this.txtPadre.Text.Equals(""))
                {                    
                    string tamaño = this.ddlMejoramientoTamaño.SelectedValue;
                    string madurez = this.ddlMejoramientoMadurez.SelectedValue;
                    string forma = this.ddlMejoramientoForma.SelectedValue;
                    string distribucion = this.ddlMejoramientoDistribucion.SelectedValue;
                    string profundidad = this.ddlMejoramientoProfundidad.SelectedValue;
                    string regularidad = this.ddlMejoramientoRegularidad.SelectedValue;
                    string brotacion = this.ddlMejoramientoBrotacion.SelectedValue;
                    string emergencia = this.ddlMejoramientoEmergencia.SelectedValue;
                    string emergencia40 = this.ddlMejoramientoEmergencia40.SelectedValue;
                    string metribuzina = this.ddlMejoramientoMetribuzina.SelectedValue;
                    string verdes = this.ddlMejoramientoTuberculosVerdes.SelectedValue;
                    string tizon_follaje = this.ddlMejoramientoTizonFollaje.SelectedValue;
                    string tizon_tuberculo = this.ddlMejoramientoTizonTuberculo.SelectedValue;
                    string numero = this.ddlMejoramientoNumero.SelectedValue;
                    string fertilidad = this.ddlMejoramientoFertilidad.SelectedValue;
                    string destino = this.ddlMejoramientoDestino.SelectedValue;
                    Padre papa = new Padre(Int32.Parse(tamaño), Int32.Parse(madurez),
                        Int32.Parse(forma), Int32.Parse(distribucion), Int32.Parse(profundidad), Int32.Parse(regularidad),
                        Int32.Parse(brotacion), Int32.Parse(emergencia), Int32.Parse(emergencia40),
                        Int32.Parse(metribuzina), Int32.Parse(verdes), Int32.Parse(tizon_follaje), Int32.Parse(tizon_tuberculo),
                        Int32.Parse(numero), Int32.Parse(fertilidad), Int32.Parse(destino));
                    lista = padre.GetPadre(papa);
                }
                else
                {
                    RefreshDropDown();                    
                    string nombre = this.txtPadre.Text;
                    lista = padre.GetPadreNombre(nombre);
                }

                this.gdvCaracteristicaPadre.DataSource = lista;
                this.gdvCaracteristicaPadre.DataBind();
            }
            catch (Exception ex)
            {
            }
        }

        /*
         * BOTON QUE CREA UN NUEVO CRUZAMIENTO, OBLIGATORIAMENTE DEBE EXISTIR UNA MADRE Y UN PADRE
         */
        protected void btnMejoramientoCruzamiento_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad_seleccion_madre = 0;
                foreach (GridViewRow row in gdvCaracteristicaMadre.Rows)
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkMejoramientoSeleccionarMadre = (row.Cells[0].FindControl("chkMejoramientoSeleccionarMadre") as CheckBox);
                        if (chkMejoramientoSeleccionarMadre.Checked)
                            cantidad_seleccion_madre += 1;
                    }
                if (cantidad_seleccion_madre == 0)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Debe seleccionar una madre');</script>");
                if (cantidad_seleccion_madre > 1)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Solo se debe seleccionar una madre');</script>");

                int cantidad_seleccion_padre = 0;
                foreach (GridViewRow row in gdvCaracteristicaPadre.Rows)
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkMejoramientoSeleccionarPadre = (row.Cells[0].FindControl("chkMejoramientoSeleccionarPadre") as CheckBox);
                        if (chkMejoramientoSeleccionarPadre.Checked)
                            cantidad_seleccion_padre += 1;
                    }
                if (cantidad_seleccion_padre == 0)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Debe seleccionar un padre');</script>");
                if (cantidad_seleccion_padre > 1)
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Solo se debe seleccionar un padre');</script>");

                if (cantidad_seleccion_madre == 1 && cantidad_seleccion_padre == 1)
                {
                    string codigoMadre = "";
                    foreach (GridViewRow row in gdvCaracteristicaMadre.Rows)
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkMejoramientoSeleccionarMadre = (row.Cells[0].FindControl("chkMejoramientoSeleccionarMadre") as CheckBox);
                            if (chkMejoramientoSeleccionarMadre.Checked)
                                codigoMadre = HttpUtility.HtmlDecode((string)this.gdvCaracteristicaMadre.Rows[row.RowIndex].Cells[1].Text);
                        }
                    string codigoPadre = "";
                    foreach (GridViewRow row in gdvCaracteristicaPadre.Rows)
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkMejoramientoSeleccionarPadre = (row.Cells[0].FindControl("chkMejoramientoSeleccionarPadre") as CheckBox);
                            if (chkMejoramientoSeleccionarPadre.Checked)
                                codigoPadre = HttpUtility.HtmlDecode((string)this.gdvCaracteristicaPadre.Rows[row.RowIndex].Cells[1].Text);
                        }

                    if (!codigoMadre.Equals(""))
                        if (!codigoPadre.Equals(""))
                        {
                            CatalogCruzamiento cc = new CatalogCruzamiento();
                            cc.AddCruzamiento(codigoMadre, codigoPadre);
                            Response.Redirect("MenuGeneracion.aspx");
                        }
                        else
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Debe selecionar una variedad padre');</script>");
                    else
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Debe selecionar una variedad madre');</script>");
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*
         * BOTON CANCELAR CRUZAMIENTO
         */ 
        protected void btnMejoramientoCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");            
        }

        /*
         * BOTON QUE LIMPIA LAS CARACTERISTICAS
         */ 
        protected void btnMejoramientoRefresh_Click(object sender, EventArgs e)
        {
            RefreshDropDown();
            this.txtMadre.Text = "";
            this.txtPadre.Text = "";
            SeleccionDropDown();
        }
        
        //---------------------------------------------PAGINACIÓN TABLA MADRE-------------------------------------------
        protected void MadreGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvCaracteristicaMadre.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCaracteristicaMadre.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvCaracteristicaMadre.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCaracteristicaMadre.PageCount.ToString();
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
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdvCaracteristicaMadre.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                this.btnCaracteristicaMadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvCaracteristicaMadre.PageIndex = pageList.SelectedIndex;
                this.btnCaracteristicaMadre_Click(sender, e);
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
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdvCaracteristicaMadre.PageIndex = pageList.SelectedIndex + 1;
                this.btnCaracteristicaMadre_Click(sender, e);
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
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdvCaracteristicaMadre.PageIndex = pageList.SelectedIndex - 1;
                this.btnCaracteristicaMadre_Click(sender, e);
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
                gdvCaracteristicaMadre.PageIndex = 0;
                this.btnCaracteristicaMadre_Click(sender, e);
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
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdvCaracteristicaMadre.PageIndex = pageList.Items.Count;
                this.btnCaracteristicaMadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        protected void MadreGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaMadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvCaracteristicaMadre.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCaracteristicaMadre.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvCaracteristicaMadre.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCaracteristicaMadre.PageCount.ToString();
                }
                this.gdvCaracteristicaMadre.Controls[0].Controls[this.gdvCaracteristicaMadre.Controls[0].Controls.Count - 1].Visible = true;
                this.btnCaracteristicaMadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }

        //----------------------------------------------PAGINACIÓN TABLA PADRE-------------------------------------------------
        protected void PadreGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize2");
                if (Context.Session["PageSize2"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize2"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel2");

                if (pageList != null)
                {
                    for (int i = 0; i < gdvCaracteristicaPadre.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCaracteristicaPadre.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdvCaracteristicaPadre.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCaracteristicaPadre.PageCount.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void ddlPageSize2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize2");

                gdvCaracteristicaPadre.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize2"] = pageSizeList.SelectedValue;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");
                gdvCaracteristicaPadre.PageIndex = pageList.SelectedIndex;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        //Siguiente página
        protected void NextLB2_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");
                //Aumenta la página en 1
                gdvCaracteristicaPadre.PageIndex = pageList.SelectedIndex + 1;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        //Página anterior
        protected void PrevLB2_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");
                //Disminuye la página en 1
                gdvCaracteristicaPadre.PageIndex = pageList.SelectedIndex - 1;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        //Página inicio
        protected void FirstLB2_Click(object sender, EventArgs e)
        {
            try
            {
                gdvCaracteristicaPadre.PageIndex = 0;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        //Página final
        protected void LastLB2_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");
                gdvCaracteristicaPadre.PageIndex = pageList.Items.Count;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        protected void PadreGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdvCaracteristicaPadre.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList2");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel2");
                if (pageList != null)
                {
                    for (int i = 0; i < gdvCaracteristicaPadre.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdvCaracteristicaPadre.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdvCaracteristicaPadre.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdvCaracteristicaPadre.PageCount.ToString();
                }
                this.gdvCaracteristicaPadre.Controls[0].Controls[this.gdvCaracteristicaPadre.Controls[0].Controls.Count - 1].Visible = true;
                this.btnCaracteristicaPadre_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
    }
}