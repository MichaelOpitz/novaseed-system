using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Globalization;

namespace Project.Novaseed
{
    public partial class ProduccionIngresar : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString, codigo_variedad;

        protected void Page_Load(object sender, EventArgs e)
        {
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["ano_produccion"] != null)
                valorAñoString = Request.QueryString["ano_produccion"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA CODIGO ASIGNADO
            if (Request.QueryString["codigo"] != null)
                codigo_variedad = Request.QueryString["codigo"];
            else
                codigo_variedad = "0";

            CatalogCiudad cc = new CatalogCiudad();
            List<Project.BusinessRules.Ciudad> ciudad = cc.GetCiudad();
            CatalogCategoriaProduccion ccp = new CatalogCategoriaProduccion();
            List<Project.BusinessRules.CategoriaProduccion> categoria = ccp.GetCategoriaProduccion();
            CatalogProductor cp = new CatalogProductor();
            List<Project.BusinessRules.Productor> productor = cp.GetProductor();

            CatalogProduccion cprod = new CatalogProduccion();
            List<Project.BusinessRules.Produccion> produccion = cprod.GetProduccionPorVariedad(codigo_variedad);

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

                this.ddlProduccionCiudad.SelectedValue = produccion[0].Id_ciudad.ToString();
                this.ddlProduccionCategoriaProduccion.SelectedValue = produccion[0].Id_categoria_produccion.ToString();
                this.ddlProduccionProductor.SelectedValue = produccion[0].Id_productor.ToString();
                this.txtProduccionCantidadTotal.Text = produccion[0].Prod_cantidad_total.ToString();
                this.txtProduccionCantidadProductor.Text = produccion[0].Cantidad_productor.ToString();
                this.txtProduccionSuperficie.Text = produccion[0].Superficie_produccion.ToString();
                this.txtProduccionCosecha.Text = produccion[0].Cosecha_produccion.ToString();
                this.chkProduccionLicencia.Checked = produccion[0].Licencia_produccion;

                this.lblProduccionVariedad.Text += "'" + codigo_variedad.ToString() + "'";
                this.lblProduccionAño.Text += "'" + valorAñoInt32.ToString() + "'";
                this.DataBind();
            }
        }

        protected void btnProduccionCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuProduccion.aspx");
        }

        protected void btnProduccionGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ciudad = this.ddlProduccionCiudad.SelectedValue;                
                string id_categoria = this.ddlProduccionCategoriaProduccion.SelectedValue;                
                string id_productor = this.ddlProduccionProductor.SelectedValue;                
                string prod_cantidad_total = this.txtProduccionCantidadTotal.Text.Replace(",", ".");
                string cantidad_productor = this.txtProduccionCantidadProductor.Text.Replace(",", ".");
                string superficie = this.txtProduccionSuperficie.Text.Replace(",", ".");
                string cosecha = this.txtProduccionCosecha.Text.Replace(",", ".");
                bool licencia = this.chkProduccionLicencia.Checked;

                CatalogProduccion cp = new CatalogProduccion();
                Produccion produccion = new Produccion(Int32.Parse(id_productor),Int32.Parse(id_ciudad),codigo_variedad,
                    Int32.Parse(id_categoria),Double.Parse(prod_cantidad_total, CultureInfo.InvariantCulture),
                    Double.Parse(cantidad_productor, CultureInfo.InvariantCulture),Double.Parse(superficie, CultureInfo.InvariantCulture),
                    Double.Parse(cosecha, CultureInfo.InvariantCulture),licencia);
                int valor = cp.UpdateProduccion(produccion);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar la producción!')</script>");
                else
                    Response.Redirect("MenuProduccion.aspx");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
        }
    }
}