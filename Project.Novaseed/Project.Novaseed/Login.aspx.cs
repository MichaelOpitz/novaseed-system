using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                string user = this.txtLoginUsuario.Text;
                string password = this.txtLoginContraseña.Text;
                if (!user.Equals(""))
                    if (!password.Equals(""))
                    {
                        CatalogUsuario cu = new CatalogUsuario();
                        int valor = cu.GetLogin(user, password);
                        if (valor == 1)
                        {
                            this.Session["user"] = user;
                            Response.Redirect("Menu.aspx");
                        }
                        else
                            error += "Usuario o contraseña incorrecta. ";
                    }
                    else
                        error += "Usuario no puede estar vacio. ";
                else
                    error += "Contraseña no puede estar vacio. ";
            }
            catch (Exception ex)
            {
                error += "Error Crítico. ";
            }
            Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + error + "')</script>");
        }
    }
}