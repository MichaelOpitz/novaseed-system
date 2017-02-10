using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.IO;
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
            string user = "";
            try
            {                
                user = this.Session["user"].ToString();
                if (user.Equals(""))
                {
                    Response.Redirect("Login.aspx");
                }                
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }

            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                //Obtiene si el usuario es administrador(1) o no(0) para mostrar la administracion de usuario en el menú lateral
                bool administrador = cu.GetUsuarioAdministrador(user);
                if (administrador == false)
                    this.btnMenuLateralUsuario.Visible = false;
                //Obtiene el nombre, cargo y la imagen del perfil del usuario
                List<Project.BusinessRules.Usuario> lstUsuario = cu.GetNombreCargoImagenUsuario(user);
                if (lstUsuario.Count > 0)
                {
                    this.lblMenuNombre.Text = lstUsuario[0].Nombre;
                    this.lblMenuCargo.Text = lstUsuario[0].Nombre_cargo;

                    string imagenString = lstUsuario[0].Imagen;
                    if (!imagenString.Equals(""))
                        this.imgMenuAvatar.ImageUrl = "data:image;base64," + imagenString;
                    else
                        this.imgMenuAvatar.ImageUrl = "images/default-avatar.jpg";
                }
            }
            catch (Exception ex)
            {
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