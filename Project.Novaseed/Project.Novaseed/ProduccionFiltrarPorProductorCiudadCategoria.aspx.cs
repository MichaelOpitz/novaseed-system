using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ProduccionFiltrarPorProductorCiudadCategoria : System.Web.UI.Page
    {
        private string id_productor, id_ciudad, id_categoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["id_productor"] != null)
                id_productor = Request.QueryString["id_productor"];
            else
                id_productor = "0";

            if (Request.QueryString["id_ciudad"] != null)
                id_ciudad = Request.QueryString["id_ciudad"];
            else
                id_ciudad = "0";

            if (Request.QueryString["id_categoria"] != null)
                id_categoria = Request.QueryString["id_categoria"];
            else
                id_categoria = "0";

            if (!Page.IsPostBack)
            {
                this.gdvProduccion.DataSource = cp.GetFiltrarProduccionPorProductorCiudadCategoria(Int32.Parse(id_productor), 
                    Int32.Parse(id_ciudad), Int32.Parse(id_categoria));
                this.gdvProduccion.DataBind();
            }
        }

        //pregunta si la licencia es true para cambiarlo a "si" o false para cambiarlo a "no"
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[9].Text == "True")
                    e.Row.Cells[9].Text = "Si";
                else
                    e.Row.Cells[9].Text = "No";
            }
        }
    }
}