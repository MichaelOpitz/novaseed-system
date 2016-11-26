using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMenuMejoramiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mejoramiento.aspx");
        }

        protected void btnMenuGeneracion_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btnMenuProduccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuProduccion.aspx");
        }

        protected void btnMenuLicencia_Click(object sender, EventArgs e)
        {
            Response.Redirect("Licencia.aspx");
        }
    }
}