using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class Licencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();
            List<Project.BusinessRules.Produccion> produccion = cp.GetAñoLicencia_fn();

            if (!Page.IsPostBack)
            {
                this.ddlLicenciaAño.DataValueField = "ano_licencia";
                this.ddlLicenciaAño.DataTextField = "ano_licencia";
                this.ddlLicenciaAño.DataSource = produccion;
                this.DataBind();
            }
        }

        protected void btnLicencia_Click(object sender, EventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();
            string año_licencia = this.ddlLicenciaAño.SelectedValue;
            this.gdvLicencia.DataSource = cp.GetLicencia(Int32.Parse(año_licencia));
            this.gdvLicencia.DataBind();
        }
    }
}