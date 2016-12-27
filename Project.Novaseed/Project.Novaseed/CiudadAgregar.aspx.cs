using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class CiudadAgregar : System.Web.UI.Page
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
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnCiudadCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnCiudadGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblCiudadError.Visible = true;
                int id_provincia = Int32.Parse(this.ddlCiudadProvincia.SelectedValue);
                string nombre_ciudad = this.txtCiudad.Text;
                if (nombre_ciudad.Length > 1 && nombre_ciudad.Length < 100)
                {
                    CatalogCiudad cc = new CatalogCiudad();
                    cc.AddCiudad(nombre_ciudad, id_provincia);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al ingresar una ciudad, la longitud debe ser la especificada";
            }
            catch(Exception ex)
            {

            }
        }
        //---------------------------------------------CIUDAD---------------------------------------------------------

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
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnProvinciaCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnProvinciaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblCiudadError.Visible = true;
                int id_region = Int32.Parse(this.ddlProvinciaRegion.SelectedValue);
                string nombre_provincia = this.txtProvincia.Text;
                if (nombre_provincia.Length > 1 && nombre_provincia.Length < 100)
                {
                    CatalogProvincia cp = new CatalogProvincia();
                    cp.AddProvincia(nombre_provincia, id_region);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al ingresar una provincia, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }
        //-------------------------------------------------PROVINCIA-------------------------------------------------------

        //-------------------------------------------------REGION-------------------------------------------------------
        protected void btnRegionCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnRegionGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblCiudadError.Visible = true;
                int id_pais = Int32.Parse(this.ddlRegionPais.SelectedValue);
                string nombre_region = this.txtRegion.Text;
                if (nombre_region.Length > 1 && nombre_region.Length < 100)
                {
                    CatalogRegion cr = new CatalogRegion();
                    cr.AddRegion(nombre_region, id_pais);
                    Response.Redirect("Menu.aspx");
                }
                else
                    this.lblCiudadError.Text += "Error al ingresar una región, la longitud debe ser la especificada";
            }
            catch (Exception ex)
            {

            }
        }
        //-------------------------------------------------REGION-------------------------------------------------------
    }
}