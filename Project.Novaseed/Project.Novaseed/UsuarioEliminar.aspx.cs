using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class UsuarioEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PoblarGrilla();
            }
        }

        /*
         * Llena la grilla del usuario
         */
        private void PoblarGrilla()
        {
            CatalogUsuario cu = new CatalogUsuario();
            gdvUsuario.DataSource = cu.GetUsuario();
            gdvUsuario.DataBind();
        }

        protected void UsuarioGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                string rol = HttpUtility.HtmlDecode((string)this.gdvUsuario.Rows[e.RowIndex].Cells[1].Text);
                int valor = cu.DeleteUsuario(Int32.Parse(rol));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el usuario!')</script>");
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar el usuario!')</script>");
            }

            PoblarGrilla();
        }
    }
}