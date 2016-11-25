using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class UPOVSeleccionar : System.Web.UI.Page
    {
        private int contUPOV, valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            contUPOV = 0;

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblUPOVAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogUPOV cu = new CatalogUPOV();
                this.gdvUPOV.DataSource = cu.GetTablaUPOV(valorAñoInt32);
                this.DataBind();
            }
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW UPOV
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogUPOV cu = new CatalogUPOV();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //devuelve 1 y lo pinta de verde si esta en upov, 0 y rojo en caso contrario
                int indexUPOVgenerado = cu.GetUPOVEstaGenerado(valorAñoInt32, contUPOV);

                if (indexUPOVgenerado == 1)
                    e.Row.BackColor = Color.LightGreen;
                else
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                contUPOV = contUPOV + 1;
            }
        }

        protected void gdvUPOV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdvUPOV.SelectedIndex;

            string id_upov = HttpUtility.HtmlDecode((string)this.gdvUPOV.Rows[selected].Cells[0].Text);
            Response.Redirect("UPOV.aspx?id=" + id_upov);
        }
    }
}