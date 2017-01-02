using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            try
            {
                // El código siguiente ayuda a proteger frente a ataques XSRF
                var requestCookie = Request.Cookies[AntiXsrfTokenKey];
                Guid requestCookieGuidValue;
                if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
                {
                    // Utilizar el token Anti-XSRF de la cookie
                    _antiXsrfTokenValue = requestCookie.Value;
                    Page.ViewStateUserKey = _antiXsrfTokenValue;
                }
                else
                {
                    // Generar un nuevo token Anti-XSRF y guardarlo en la cookie
                    _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                    Page.ViewStateUserKey = _antiXsrfTokenValue;

                    var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                    {
                        HttpOnly = true,
                        Value = _antiXsrfTokenValue
                    };
                    if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                    {
                        responseCookie.Secure = true;
                    }
                    Response.Cookies.Set(responseCookie);
                }

                Page.PreLoad += master_Page_PreLoad;
            }
            catch (Exception ex)
            {
            }
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    // Establecer token Anti-XSRF
                    ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                    ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
                }
                else
                {
                    // Validar el token Anti-XSRF
                    if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                        || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                    {
                        throw new InvalidOperationException("Error de validación del token Anti-XSRF.");
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                string user = this.Session["user"].ToString();
                List<Project.BusinessRules.Usuario> lstUsuario = cu.GetNombreCargoUsuario(user);
                this.lblUsuario.Text = lstUsuario[0].Nombre.ToString();
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            try
            {
                Context.GetOwinContext().Authentication.SignOut();
            }
            catch (Exception ex)
            {
            }
        }

        /*
         * Boton que cierra la sesion
         */ 
        protected void btnCerrarSession_Click(object sender, EventArgs e)
        {
            this.Session.Remove("user");
            if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Login.aspx");
        }
    }

}