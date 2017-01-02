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
            if (!Page.IsPostBack)
            {
                if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                {
                    this.txtLoginUsuario.Text = Request.Cookies["UserName"].Value;
                    this.txtLoginContraseña.Attributes["value"] = Request.Cookies["Password"].Value;
                    this.chkLoginRecordar.Checked = true;
                    this.Session["user"] = this.txtLoginUsuario.Text;
                    Response.Redirect("Menu.aspx");
                }
            }
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
                            if (this.chkLoginRecordar.Checked)
                            {
                                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
                            }
                            else
                            {
                                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                            }
                            Response.Cookies["UserName"].Value = this.txtLoginUsuario.Text.Trim();
                            Response.Cookies["Password"].Value = this.txtLoginContraseña.Text.Trim();

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

        protected void btnLoginExisteCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = this.txtLoginRecuperarContraseña.Text;
                CatalogUsuario cu = new CatalogUsuario();
                int valor = cu.ExistCorreo(correo);
                if (valor == 0 || correo.Equals(""))
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('El correo ingresado no existe')</script>");
                else
                {
                    this.txtLoginRecuperarContraseña.Text = "";
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Se ha enviado la contraseña al correo señalado')</script>");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error Crítico')</script>");
            }            
        }
    }
}