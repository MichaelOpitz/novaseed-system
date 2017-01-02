using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                CatalogSexo cs = new CatalogSexo();
                List<Project.BusinessRules.Sexo> sexo = cs.GetSexo();
                CatalogCargo cc = new CatalogCargo();
                List<Project.BusinessRules.Cargo> cargo = cc.GetCargo();
                CatalogPais cp = new CatalogPais();
                List<Project.BusinessRules.Pais> pais = cp.GetPais();

                List<int> listaAños = new List<int>();
                int añoActual = DateTime.Now.Year - 18;
                int añoMenor = añoActual - 65;
                for (int i = añoActual; i > añoMenor; i--)
                {
                    listaAños.Add(i);
                }

                this.lblUsuarioError.Visible = false;
                this.lblUsuarioError.Text = "";
                if (!IsPostBack)
                {
                    this.ddlUsuarioSexo.DataValueField = "id_sexo";
                    this.ddlUsuarioSexo.DataTextField = "nombre_sexo";
                    this.ddlUsuarioSexo.DataSource = sexo;
                    this.ddlUsuarioCargo.DataValueField = "id_cargo";
                    this.ddlUsuarioCargo.DataTextField = "nombre_cargo";
                    this.ddlUsuarioCargo.DataSource = cargo;

                    this.lstUsuarioNacionalidad.DataValueField = "id_pais";
                    this.lstUsuarioNacionalidad.DataTextField = "nombre_pais";
                    this.lstUsuarioNacionalidad.DataSource = pais;
                    this.lstUsuarioNacionalidad.SelectedIndex = 0;

                    this.ddlUsuarioAño.DataSource = listaAños;
                    this.clrUsuarioFechaNacimiento.SelectedDate = DateTime.Today;

                    this.gdvUsuario.DataSource = cu.GetUsuario();
                    this.DataBind();
                }
            }
            catch (Exception ex)
            {
            }
        }
        //----------------------------------------------------AGREGAR USUARIO--------------------------------------------
        /*
         * Verifica si es un entero
         */
        public bool EsNumero(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public void CambiarFechaNacimiento()
        {
            int year = Int32.Parse(this.ddlUsuarioAño.SelectedItem.ToString());
            int month = Int32.Parse(this.ddlUsuarioMes.SelectedValue);
            this.clrUsuarioFechaNacimiento.VisibleDate = new DateTime(year, month, 1);
            this.clrUsuarioFechaNacimiento.SelectedDate = new DateTime(year, month, 1);
        }

        protected void ddlUsuarioAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarFechaNacimiento();
        }

        protected void ddlUsuarioMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarFechaNacimiento();
        }

        protected void btnUsuarioCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnUsuarioGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                this.lblUsuarioError.Visible = true;
                int invalido = 0;
                string rol = this.txtUsuarioRol.Text;
                if ((EsNumero(rol) == true && (Int32.Parse(rol) < 1000000 || Int32.Parse(rol) > 99999999)) || (EsNumero(rol) == false))
                    invalido = 1;                
                string dv = this.txtUsuarioDV.Text;
                if ((EsNumero(dv) == true && (Int32.Parse(dv) < 0 || Int32.Parse(dv) > 9)) || (EsNumero(dv) == false && dv != "k" && dv != "K"))
                    invalido = 1;
                if (f.ValidarRUN(rol, Convert.ToChar(dv)) == false)
                    invalido = 2;
                string nombre = this.txtUsuarioNombre.Text;
                string apellido = this.txtUsuarioApellido.Text;
                DateTime fecha_nac = this.clrUsuarioFechaNacimiento.SelectedDate;
                string email = this.txtUsuarioCorreo.Text;
                string telefono = this.txtUsuarioTelefono.Text;
                if ((EsNumero(telefono) == true && (Int32.Parse(telefono) < 900000000 || Int32.Parse(telefono) > 999999999)) || (EsNumero(telefono) == false))
                    invalido = 1;
                string direccion = this.txtUsuarioDireccion.Text;
                bool administrador = this.chkUsuarioAdministrador.Checked;
                int id_sexo = Int32.Parse(this.ddlUsuarioSexo.SelectedValue);
                int id_cargo = Int32.Parse(this.ddlUsuarioCargo.SelectedValue);
                string usuario = this.txtUsuarioUser.Text;
                string password = this.txtUsuarioPassword.Text;
                string passwordRepetir = this.txtUsuarioPasswordRepetir.Text;

                if (invalido == 0)
                {
                    if (password == passwordRepetir && !password.Equals(""))
                    {
                        if (!nombre.Equals("") && !usuario.Equals(""))
                        {                                                        
                            List<int> selectedNacionalidad = this.lstUsuarioNacionalidad.GetSelectedIndices().ToList();
                            if ((selectedNacionalidad.Count > 1 && !selectedNacionalidad[0].Equals(0)) || (selectedNacionalidad.Count == 1))
                            {
                                CatalogUsuario cu = new CatalogUsuario();
                                Project.BusinessRules.Usuario u = new Project.BusinessRules.Usuario(Int32.Parse(rol), dv, id_cargo, id_sexo, nombre, apellido, fecha_nac, direccion,
                                    email, Int32.Parse(telefono), usuario, password, administrador);
                                //Agrega Usuario y Persona
                                cu.AddUsuario(u);
                                for (int i = 0; i < selectedNacionalidad.Count; i++)
                                {
                                    string id_nacionalidad = this.lstUsuarioNacionalidad.Items[selectedNacionalidad[i]].Value;
                                    //Agrega Nacionalidad
                                    cu.AddNacionalidad(Int32.Parse(id_nacionalidad), Int32.Parse(rol));
                                }
                            }
                            else
                                this.lblUsuarioError.Text += "No puede seleccionar sin información y países a la vez.<br/>";

                            Response.Redirect("Menu.aspx");
                        }
                        else
                            this.lblUsuarioError.Text += "Falta el nombre o usuario.<br/>";
                    }
                    else
                        this.lblUsuarioError.Text += "Error al ingresar, Las contraseñas deben ser iguales.<br/>";
                }
                else
                {
                    if (invalido == 1)
                        this.lblUsuarioError.Text += "Error al ingresar, Revise los parámetros indicados y modifiquelos.<br/>";
                    if (invalido == 2)
                        this.lblUsuarioError.Text += "El RUN ingresado no es valido.<br/>";
                }
            }
            catch (Exception ex)
            {
                this.lblUsuarioError.Text += "ERROR CRÍTICO, NO SE HA PODIDO INGRESAR EL USUARIO, ARREGLE LOS PARÁMETROS E INTENTELO NUEVAMENTE.<br/>";
            }
        }
        //----------------------------------------------------AGREGAR USUARIO--------------------------------------------

        //----------------------------------------------------ELIMINAR USUARIO--------------------------------------------
        /*
         * Llena la grilla del usuario
         */
        private void PoblarGrilla()
        {
            CatalogUsuario cu = new CatalogUsuario();
            this.gdvUsuario.DataSource = cu.GetUsuario();
            this.gdvUsuario.DataBind();
        }

        protected void UsuarioGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                string rol = HttpUtility.HtmlDecode((string)this.gdvUsuario.Rows[e.RowIndex].Cells[1].Text);
                int valor = cu.DeleteUsuario(Int32.Parse(rol));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar el usuario')</script>");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar el usuario')</script>");
            }

            PoblarGrilla();
        }
        //----------------------------------------------------ELIMINAR USUARIO--------------------------------------------
    }
}