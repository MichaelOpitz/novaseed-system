﻿using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class CiudadActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogPais cp = new CatalogPais();
            List<Project.BusinessRules.Pais> pais = cp.GetPais();

            this.lblCiudadError.Visible = false;
            this.lblCiudadError.Text = "";
            if (!Page.IsPostBack)
            {
                this.ddlCiudadPais.DataValueField = "id_pais";
                this.ddlCiudadPais.DataTextField = "nombre_pais";
                this.ddlCiudadPais.DataSource = pais;
                this.ddlProvinciaPais.DataValueField = "id_pais";
                this.ddlProvinciaPais.DataTextField = "nombre_pais";
                this.ddlProvinciaPais.DataSource = pais;
                this.ddlRegionPais.DataValueField = "id_pais";
                this.ddlRegionPais.DataTextField = "nombre_pais";
                this.ddlRegionPais.DataSource = pais;

                this.DataBind();
            }
        }

        //-------------------------------------------------CIUDAD-------------------------------------------------------
        protected void ddlCiudadPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlCiudadRegion.Items.Clear();
                this.ddlCiudadProvincia.Items.Clear();
                CatalogRegion cr = new CatalogRegion();
                List<Project.BusinessRules.Region> region = cr.GetRegion(Int32.Parse(this.ddlCiudadPais.SelectedValue));
                this.ddlCiudadRegion.DataValueField = "id_region";
                this.ddlCiudadRegion.DataTextField = "nombre_region";
                this.ddlCiudadRegion.DataSource = region;
                this.ddlCiudadRegion.DataBind();

                if (this.ddlCiudadRegion.Items.Count > 0)
                {
                    this.ddlCiudadProvincia.Items.Clear();
                    CatalogProvincia cp = new CatalogProvincia();
                    List<Project.BusinessRules.Provincia> provincia = cp.GetProvincia(Int32.Parse(this.ddlCiudadRegion.SelectedValue));
                    this.ddlCiudadProvincia.DataValueField = "id_provincia";
                    this.ddlCiudadProvincia.DataTextField = "nombre_provincia";
                    this.ddlCiudadProvincia.DataSource = provincia;
                    this.ddlCiudadProvincia.DataBind();

                    if (this.ddlCiudadProvincia.Items.Count > 0)
                    {
                        this.ddlCiudad.Items.Clear();
                        CatalogCiudad cc = new CatalogCiudad();
                        List<Project.BusinessRules.Ciudad> ciudad = cc.GetCiudadPorProvincia(Int32.Parse(this.ddlCiudadProvincia.SelectedValue));
                        this.ddlCiudad.DataValueField = "id_ciudad";
                        this.ddlCiudad.DataTextField = "nombre_ciudad";
                        this.ddlCiudad.DataSource = ciudad;
                        this.ddlCiudad.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void ddlCiudadRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlCiudadProvincia.Items.Clear();
                CatalogProvincia cp = new CatalogProvincia();
                List<Project.BusinessRules.Provincia> provincia = cp.GetProvincia(Int32.Parse(this.ddlCiudadRegion.SelectedValue));
                this.ddlCiudadProvincia.DataValueField = "id_provincia";
                this.ddlCiudadProvincia.DataTextField = "nombre_provincia";
                this.ddlCiudadProvincia.DataSource = provincia;
                this.ddlCiudadProvincia.DataBind();

                if (this.ddlCiudadProvincia.Items.Count > 0)
                {
                    this.ddlCiudad.Items.Clear();
                    CatalogCiudad cc = new CatalogCiudad();
                    List<Project.BusinessRules.Ciudad> ciudad = cc.GetCiudadPorProvincia(Int32.Parse(this.ddlCiudadProvincia.SelectedValue));
                    this.ddlCiudad.DataValueField = "id_ciudad";
                    this.ddlCiudad.DataTextField = "nombre_ciudad";
                    this.ddlCiudad.DataSource = ciudad;
                    this.ddlCiudad.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void ddlCiudadProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlCiudad.Items.Clear();
                CatalogCiudad cc = new CatalogCiudad();
                List<Project.BusinessRules.Ciudad> ciudad = cc.GetCiudadPorProvincia(Int32.Parse(this.ddlCiudadProvincia.SelectedValue));
                this.ddlCiudad.DataValueField = "id_ciudad";
                this.ddlCiudad.DataTextField = "nombre_ciudad";
                this.ddlCiudad.DataSource = ciudad;
                this.ddlCiudad.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnCiudadGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogCiudad cc = new CatalogCiudad();
                int id_ciudad = Int32.Parse(this.ddlCiudad.SelectedValue);
                string nombre_ciudad = this.txtCiudad.Text;
                if (nombre_ciudad.Length > 1 && nombre_ciudad.Length < 100)
                {
                    cc.UpdateCiudad(id_ciudad, nombre_ciudad);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al modificar una ciudad, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnCiudadCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
        //-------------------------------------------------CIUDAD-------------------------------------------------------

        //-------------------------------------------------PROVINCIA-------------------------------------------------------
        protected void ddlProvinciaPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlProvinciaRegion.Items.Clear();
                CatalogRegion cr = new CatalogRegion();
                List<Project.BusinessRules.Region> region = cr.GetRegion(Int32.Parse(this.ddlProvinciaPais.SelectedValue));
                this.ddlProvinciaRegion.DataValueField = "id_region";
                this.ddlProvinciaRegion.DataTextField = "nombre_region";
                this.ddlProvinciaRegion.DataSource = region;
                this.ddlProvinciaRegion.DataBind();

                if (this.ddlProvinciaRegion.Items.Count > 0)
                {
                    this.ddlProvincia.Items.Clear();
                    CatalogProvincia cp = new CatalogProvincia();
                    List<Project.BusinessRules.Provincia> provincia = cp.GetProvincia(Int32.Parse(this.ddlProvinciaRegion.SelectedValue));
                    this.ddlProvincia.DataValueField = "id_provincia";
                    this.ddlProvincia.DataTextField = "nombre_provincia";
                    this.ddlProvincia.DataSource = provincia;
                    this.ddlProvincia.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void ddlProvinciaRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlProvincia.Items.Clear();
                CatalogProvincia cp = new CatalogProvincia();
                List<Project.BusinessRules.Provincia> provincia = cp.GetProvincia(Int32.Parse(this.ddlProvinciaRegion.SelectedValue));
                this.ddlProvincia.DataValueField = "id_provincia";
                this.ddlProvincia.DataTextField = "nombre_provincia";
                this.ddlProvincia.DataSource = provincia;
                this.ddlProvincia.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnProvinciaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogProvincia cp = new CatalogProvincia();
                int id_provincia = Int32.Parse(this.ddlProvincia.SelectedValue);
                string nombre_provincia = this.txtProvincia.Text;
                if (nombre_provincia.Length > 1 && nombre_provincia.Length < 100)
                {
                    cp.UpdateProvincia(id_provincia, nombre_provincia);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al modificar una provincia, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnProvinciaCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
        //-------------------------------------------------PROVINCIA------------------------------------------------------- 

        //-------------------------------------------------REGION-------------------------------------------------------
        protected void ddlRegionPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.ddlRegion.Items.Clear();
                CatalogRegion cr = new CatalogRegion();
                List<Project.BusinessRules.Region> region = cr.GetRegion(Int32.Parse(this.ddlRegionPais.SelectedValue));
                this.ddlRegion.DataValueField = "id_region";
                this.ddlRegion.DataTextField = "nombre_region";
                this.ddlRegion.DataSource = region;
                this.ddlRegion.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnRegionGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogRegion cr = new CatalogRegion();
                int id_region = Int32.Parse(this.ddlRegion.SelectedValue);
                string nombre_region = this.txtRegion.Text;
                if (nombre_region.Length > 1 && nombre_region.Length < 100)
                {
                    cr.UpdateRegion(id_region, nombre_region);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al modificar una región, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnRegionCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
        //-------------------------------------------------REGION-------------------------------------------------------   
    }
}