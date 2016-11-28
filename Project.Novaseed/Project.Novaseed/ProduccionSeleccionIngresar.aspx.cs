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
    public partial class ProduccionSeleccionIngresar : System.Web.UI.Page
    {
        private int valorAñoInt32, contProduccion;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            contProduccion = 0;
            CatalogProduccion cp = new CatalogProduccion();

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblProduccionAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvProduccion.DataSource = cp.GetProduccion(valorAñoInt32);
                this.gdvProduccion.DataBind();
            }
        }

        /*
         * Llena la grilla de produccion con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogProduccion cp = new CatalogProduccion();
            this.gdvProduccion.DataSource = cp.GetProduccion(valorAñoInt32);
            this.gdvProduccion.DataBind();
        }

        protected void gdvProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdvProduccion.SelectedIndex;
                string codigo = HttpUtility.HtmlDecode((string)this.gdvProduccion.Rows[selected].Cells[1].Text);                

                Response.Redirect("ProduccionIngresar.aspx?codigo=" + codigo.Trim() + "&ano_produccion=" + valorAñoInt32);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW PRODUCCION
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogProduccion cp = new CatalogProduccion();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //devuelve 1 y lo pinta de verde si esta en upov, 0 y rojo en caso contrario
                int indexProduccion = cp.GetProduccionVariedad(valorAñoInt32, contProduccion);

                if (indexProduccion == 1)
                {
                    e.Row.BackColor = Color.LightGreen;
                    e.Row.Cells[2].ForeColor = Color.Green;
                    //e.Row.Cells[2].Enabled = false;
                }
                else
                {
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                    e.Row.Cells[2].ForeColor = Color.Red;
                }
                contProduccion = contProduccion + 1;                
            }
        }
    }
}