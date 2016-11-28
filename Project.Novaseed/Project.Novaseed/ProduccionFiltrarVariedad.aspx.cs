using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ProduccionFiltrarVariedad : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["ano_produccion"] != null)
                valorAñoString = Request.QueryString["ano_produccion"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblProduccionAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvProduccion.DataSource = cp.GetFiltrarProduccionPorVariedad(valorAñoInt32);
                this.gdvProduccion.DataBind();
            }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[8].Text == "True")
                    e.Row.Cells[8].Text = "Si";                
                else
                    e.Row.Cells[8].Text = "No";
            }
        }
    }
}