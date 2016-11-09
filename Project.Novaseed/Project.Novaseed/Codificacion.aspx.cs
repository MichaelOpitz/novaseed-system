using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class Codificacion : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCodificacion cc = new CatalogCodificacion();

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.lblCodificacionAño.Text += "(" + valorAñoInt32.ToString() + ")";
                this.gdvCodificacion.DataSource = cc.GetCodificacionPadres(valorAñoInt32);
                this.gdvCodificacion.DataBind();
            }
        }

        /*
         * Llena la grilla de los clones con el año seleccionado
         */
        private void PoblarGrilla()
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            gdvCodificacion.DataSource = cc.GetCodificacionPadres(valorAñoInt32);
            gdvCodificacion.DataBind();
        }

        protected void gdvCodificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdvCodificacion.SelectedIndex;

                string madre = HttpUtility.HtmlDecode((string)this.gdvCodificacion.Rows[selected].Cells[0].Text);
                string padre = HttpUtility.HtmlDecode((string)this.gdvCodificacion.Rows[selected].Cells[2].Text);

                Response.Redirect("CodigoIndividuos.aspx?valorMadre=" + madre.Trim() + "&valorPadre=" + padre.Trim() + "&ano_codificacion=" + valorAñoInt32);
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            
        }  
    }
}