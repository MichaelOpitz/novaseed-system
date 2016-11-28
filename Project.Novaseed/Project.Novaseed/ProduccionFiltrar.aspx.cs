using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class ProduccionFiltrar : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            CatalogCiudad cc = new CatalogCiudad();
            List<Project.BusinessRules.Ciudad> ciudad = cc.GetCiudad();
            CatalogCategoriaProduccion ccp = new CatalogCategoriaProduccion();
            List<Project.BusinessRules.CategoriaProduccion> categoria = ccp.GetCategoriaProduccion();
            CatalogProductor cp = new CatalogProductor();
            List<Project.BusinessRules.Productor> productor = cp.GetProductor();

            if (!Page.IsPostBack)
            {
                this.ddlProduccionCiudad.DataValueField = "id_ciudad";
                this.ddlProduccionCiudad.DataTextField = "nombre_ciudad";
                this.ddlProduccionCiudad.DataSource = ciudad;
                this.ddlProduccionCategoriaProduccion.DataValueField = "id_categoria_produccion";
                this.ddlProduccionCategoriaProduccion.DataTextField = "nombre_categoria_produccion";
                this.ddlProduccionCategoriaProduccion.DataSource = categoria;
                this.ddlProduccionProductor.DataValueField = "id_productor";
                this.ddlProduccionProductor.DataTextField = "nombre_productor";
                this.ddlProduccionProductor.DataSource = productor;

                this.DataBind();
            }
        }

        protected void btnProduccionFiltrarPorProductorCiudadCategoria_Click(object sender, EventArgs e)
        {
            string productor = this.ddlProduccionProductor.SelectedValue;
            string ciudad = this.ddlProduccionCiudad.SelectedValue;
            string categoria = this.ddlProduccionCategoriaProduccion.SelectedValue;
            if(!productor.Equals("1") || !ciudad.Equals("1") || !categoria.Equals("1"))
                Response.Redirect("ProduccionFiltrarPorProductorCiudadCategoria.aspx?id_productor=" + productor + "&id_ciudad=" + ciudad + "&id_categoria=" + categoria);
            else
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar algún parámetro de búsqueda!')</script>");
        }

        protected void btnMenuProduccionFiltrarPorVariedad_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProduccionFiltrarVariedad.aspx?ano_produccion=" + valorAñoInt32);
        }

    }
}