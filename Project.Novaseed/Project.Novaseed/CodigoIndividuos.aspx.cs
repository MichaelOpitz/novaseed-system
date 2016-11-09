using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class CodigoIndividuos : System.Web.UI.Page
    {
        private int valorAñoInt32;
        private string valorAñoString, codigo_variedad, pad_codigo_variedad;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCodificacion cc = new CatalogCodificacion();

            if (Request.QueryString["valorMadre"] != null && Request.QueryString["valorPadre"] != null && Request.QueryString["ano_codificacion"] != null)
            {
                codigo_variedad = Request.QueryString["valorMadre"];
                pad_codigo_variedad = Request.QueryString["valorPadre"];
                valorAñoString = Request.QueryString["ano_codificacion"];
                this.txtCodificacionMadre.Text = codigo_variedad;
                this.txtCodificacionPadre.Text = pad_codigo_variedad;
                this.txtCodificacionAño.Text = valorAñoString;
            }
            else
            {
                codigo_variedad = "0";
                pad_codigo_variedad = "0";
                valorAñoString = "0";
            }
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.gdvCodigoIndividuos.DataSource = cc.GetCodificacion(codigo_variedad, pad_codigo_variedad, valorAñoInt32);
                this.gdvCodigoIndividuos.DataBind();
            }
        }

        /*
        * Llena la grilla de los individuos codificados en el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            this.gdvCodigoIndividuos.DataSource = cc.GetCodificacion(codigo_variedad, pad_codigo_variedad, valorAñoInt32);
            this.gdvCodigoIndividuos.DataBind();
        }

        protected void CodigoIndividuosGridView_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            try
            {
                string id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[e.RowIndex].Cells[1].Text);
                string codigo_individuo = e.NewValues[0].ToString();

                Project.BusinessRules.Codificacion cod = new Project.BusinessRules.Codificacion(Int32.Parse(id_codificacion), codigo_individuo);
                int valor = cc.UpdateCodificacion(cod);

                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡No se pudo modificar debido a que el código escrito ya existe en el año!')</script>");

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }

            this.gdvCodigoIndividuos.EditIndex = -1;
            PoblarGrilla();
        }

        protected void CodigoIndividuosGridView_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            gdvCodigoIndividuos.EditIndex = -1;
            PoblarGrilla();
        }

        protected void CodigoIndividuosGridView_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            gdvCodigoIndividuos.EditIndex = e.NewEditIndex;
            PoblarGrilla();   
        }

        protected void CodigoIndividuosGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogCodificacion cc = new CatalogCodificacion();
            string id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[e.RowIndex].Cells[1].Text);
            int valor = cc.DeleteCodificacion(Int32.Parse(id_codificacion));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el código!')</script>");

            PoblarGrilla();
        }

        protected void btnAgregar6papas_Click(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdvCodigoIndividuos.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAgregar6Papas = (row.Cells[3].FindControl("chkAgregar6Papas") as CheckBox);

                    if (chkAgregar6Papas != null)
                    {
                        if (chkAgregar6Papas.Checked)
                        {
                            string id_codificacion = HttpUtility.HtmlDecode((string)this.gdvCodigoIndividuos.Rows[row.RowIndex].Cells[1].Text);

                            CatalogCosecha cc = new CatalogCosecha();
                            int existe_6papas = cc.AddCosecha6papas(Int32.Parse(id_codificacion));
                            if (existe_6papas == 1)
                                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La codificacion con ID: " + id_codificacion + " seleccionado ya está en temporada de 6 papas')</script>");
                            else
                                agrego = 1;
                        }
                    }
                }
            //1 para agregar, 0 cuando no se agrega
            if (agrego == 1)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Agregado Correctamente!')</script>");
                Response.Redirect("MenuGeneracion.aspx");
            }
        }
    }
}