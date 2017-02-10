using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.Novaseed
{
    public partial class Login : System.Web.UI.Page
    {
        private int suma, numeroUno, numeroDos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //suma el día actual mas 1
                numeroUno = DateTime.Today.Day;
                numeroDos = 1;
                this.lblLoginCaptcha.Text = numeroUno.ToString() + " + " + numeroDos.ToString();

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
                        Funciones f = new Funciones();
                        password = f.Encriptar(password);
                        CatalogUsuario cu = new CatalogUsuario();
                        int valor = cu.GetLogin(user, password);
                        if (valor == 1)
                        {
                            if (this.chkLoginRecordar.Checked)
                            {
                                //Agrega 30 días al usuario en el cache
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
                        error += "Contraseña no puede estar vacio. ";
                else
                    error += "Usuario no puede estar vacio. ";
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
                    numeroUno = DateTime.Today.Day;
                    numeroDos = 1;
                    suma = numeroUno + numeroDos;
                    int sumaCaptcha = Int32.Parse(this.txtLoginSumaCaptcha.Text);
                    if (sumaCaptcha == suma)
                    {
                        GenerarNuevaContrasena(this.txtLoginRecuperarContraseña.Text);
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Correo Enviado, revise su bandeja de entrada')</script>");
                        this.txtLoginRecuperarContraseña.Text = "";
                        this.txtLoginSumaCaptcha.Text = "";
                    }
                    else
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Suma incorrecta!')</script>");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error Crítico')</script>");
            }            
        }

        private void GenerarNuevaContrasena(string email)
        {
            try
            {
                Random rd = new Random(DateTime.Now.Millisecond);
                int nuevaContrasena = rd.Next(100000, 999999);
                EnviarCorreoContrasena(nuevaContrasena, email);
            }
            catch (Exception ex)
            {
            }
        }

        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = "root2017";
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "equipo.novaseed@gmail.com";
            string asunto = "Recuperación de contraseña usuario Novaseed";
            string cuerpoDelMesaje = "Su nueva contraseña es " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);
            ms.Priority = System.Net.Mail.MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;            
            smtp.Credentials = new NetworkCredential("equipo.novaseed@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                }
                );

                CatalogUsuario cu = new CatalogUsuario();
                Funciones f = new Funciones();
                string password = f.Encriptar(Convert.ToString(contrasenaNueva));
                cu.RecuperarContraseña(correo, password);
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error al enviar correo electronico')</script>");
            }
        }

    }
}