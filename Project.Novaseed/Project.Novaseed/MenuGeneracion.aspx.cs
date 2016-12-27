using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class MenuGeneracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            List<Project.BusinessRules.Cruzamiento> cruzamiento = cc.GetAñoCruzamiento_fn();
            
            if (!Page.IsPostBack)
            {
                this.ddlGeneracionAño.DataValueField = "ano_cruzamiento";
                this.ddlGeneracionAño.DataTextField = "ano_cruzamiento";
                this.ddlGeneracionAño.DataSource = cruzamiento;
                this.DataBind();
            }
        }

        private void AñoGeneracion(string url)
        {
            try
            {
                string año = this.ddlGeneracionAño.SelectedValue;
                Response.Redirect(url + "?valor=" + año);
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnGeneracionCruzamiento_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Cruzamiento.aspx");
        }

        protected void btnGeneracionVasos_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Vasos.aspx");
        }

        protected void btnGeneracionClones_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Clones.aspx");
        }

        protected void btnGeneracionCodificacion_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Codificacion.aspx");
        }

        protected void btnGeneracion6papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Cosecha6papas.aspx");
        }

        protected void btnGeneracion12papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Cosecha12papas.aspx");
        }

        protected void btnGeneracion24papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Cosecha24papas.aspx");
        }

        protected void btnGeneracion48papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion("Cosecha48papas.aspx");
        }

        protected void btnGeneracionUpov_Click(object sender, EventArgs e)
        {
            AñoGeneracion("UPOVSeleccionar.aspx");
        }
    }
}