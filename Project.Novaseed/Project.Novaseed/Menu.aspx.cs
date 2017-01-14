using Project.BusinessRules;
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
            try
            {                
                string user = this.Session["user"].ToString();
                if (user.Equals(""))
                {
                    Response.Redirect("Login.aspx");
                }
                CatalogUsuario cu = new CatalogUsuario();
                bool administrador = cu.GetUsuarioAdministrador(user);
                if (administrador == false)
                    this.btnMenuLateralUsuario.Visible = false;
                List<Project.BusinessRules.Usuario> lstUsuario = cu.GetNombreCargoUsuario(user);
                if (lstUsuario.Count > 0)
                {
                    this.lblMenuNombre.Text = lstUsuario[0].Nombre;
                    this.lblMenuCargo.Text = lstUsuario[0].Nombre_cargo;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }
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