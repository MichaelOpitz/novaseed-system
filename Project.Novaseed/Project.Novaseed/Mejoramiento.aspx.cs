using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class Mejoramiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogColorCarne ccc = new CatalogColorCarne();
            List<Project.BusinessRules.ColorCarne> carne = ccc.getColorCarne();
            CatalogColorPiel ccp = new CatalogColorPiel();
            List<Project.BusinessRules.ColorPiel> piel = ccp.getColorPiel();
            CatalogTamaño ct = new CatalogTamaño();
            List<Project.BusinessRules.Tamaño> tamaño = ct.getTamaño();
            CatalogMadurez cm = new CatalogMadurez();
            List<Project.BusinessRules.Madurez> madurez = cm.getMadurez();
            CatalogTipoHoja cth = new CatalogTipoHoja();
            List<Project.BusinessRules.TipoHoja> hoja = cth.getTipoHoja();
            CatalogCalidadPiel ccpiel = new CatalogCalidadPiel();
            List<Project.BusinessRules.CalidadPiel> calidad = ccpiel.getCalidadPiel();
            CatalogFormaTuberculos cft = new CatalogFormaTuberculos();
            List<Project.BusinessRules.FormaTuberculos> forma = cft.getFormaTuberculos();
            CatalogDistribucionCalibre cdc = new CatalogDistribucionCalibre();
            List<Project.BusinessRules.DistribucionCalibre> distribucion = cdc.getDistribucionCalibre();
            CatalogProfundidadOjo cpo = new CatalogProfundidadOjo();
            List<Project.BusinessRules.ProfundidadOjo> profundidad = cpo.getProfundidadOjo();
            CatalogRegularidad cr = new CatalogRegularidad();
            List<Project.BusinessRules.Regularidad> regularidad = cr.getRegularidad();
            CatalogDesarrolloFollaje cdf = new CatalogDesarrolloFollaje();
            List<Project.BusinessRules.DesarrolloFollaje> desarrollo = cdf.getDesarrolloFollaje();
            CatalogBrotacion cb = new CatalogBrotacion();
            List<Project.BusinessRules.Brotacion> brotacion = cb.getBrotacion();
            CatalogEmergencia ce = new CatalogEmergencia();
            List<Project.BusinessRules.Emergencia> emergencia = ce.getEmergencia();

            CatalogEmergencia40Dias ce40 = new CatalogEmergencia40Dias();
            List<Project.BusinessRules.Emergencia40Dias> emergencia40 = ce40.getEmergencia40Dias();
            CatalogMetribuzina cmet = new CatalogMetribuzina();
            List<Project.BusinessRules.Metribuzina> metribuzina = cmet.getMetribuzina();
            CatalogTuberculosVerdes ctv = new CatalogTuberculosVerdes();
            List<Project.BusinessRules.TuberculosVerdes> verdes = ctv.getTuberculosVerdes();
            CatalogTizonTardioFollaje cttf = new CatalogTizonTardioFollaje();
            List<Project.BusinessRules.TizonTardioFollaje> tizon_follaje = cttf.getTizonTardioFollaje();
            CatalogTizonTardioTuberculo cttt = new CatalogTizonTardioTuberculo();
            List<Project.BusinessRules.TizonTardioTuberculo> tizon_tuberculo = cttt.getTizonTardioTuberculo();
            CatalogNumeroTuberculos cnt = new CatalogNumeroTuberculos();
            List<Project.BusinessRules.NumeroTuberculos> numero = cnt.getNumeroTuberculos();
            CatalogFertilidad cf = new CatalogFertilidad();
            List<Project.BusinessRules.Fertilidad> fertilidad = cf.getFertilidad();
            CatalogDestino cd = new CatalogDestino();
            List<Project.BusinessRules.Destino> destino = cd.getDestino();

            this.gdvCaracteristicaMadre.Visible = true;
            this.gdvCaracteristicaPadre.Visible = true;            

            if (!Page.IsPostBack)
            {
                this.ddlMejoramientoColorCarne.DataValueField = "id_color_carne";
                this.ddlMejoramientoColorCarne.DataTextField = "nombre_color_carne";
                this.ddlMejoramientoColorCarne.DataSource = carne;
                this.ddlMejoramientoColorPiel.DataValueField = "id_color_piel";
                this.ddlMejoramientoColorPiel.DataTextField = "nombre_color_piel";
                this.ddlMejoramientoColorPiel.DataSource = piel;
                this.ddlMejoramientoTamaño.DataValueField = "id_tamaño";
                this.ddlMejoramientoTamaño.DataTextField = "nombre_tamaño";
                this.ddlMejoramientoTamaño.DataSource = tamaño;
                this.ddlMejoramientoMadurez.DataValueField = "id_madurez";
                this.ddlMejoramientoMadurez.DataTextField = "nombre_madurez";
                this.ddlMejoramientoMadurez.DataSource = madurez;
                this.ddlMejoramientoTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddlMejoramientoTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddlMejoramientoTipoHoja.DataSource = hoja;
                this.ddlMejoramientoCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddlMejoramientoCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddlMejoramientoCalidadPiel.DataSource = calidad;
                this.ddlMejoramientoForma.DataValueField = "id_forma";
                this.ddlMejoramientoForma.DataTextField = "nombre_forma";
                this.ddlMejoramientoForma.DataSource = forma;
                this.ddlMejoramientoDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddlMejoramientoDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddlMejoramientoDistribucion.DataSource = distribucion;
                this.ddlMejoramientoProfundidad.DataValueField = "id_profundidad";
                this.ddlMejoramientoProfundidad.DataTextField = "profundidad_ojo";
                this.ddlMejoramientoProfundidad.DataSource = profundidad;
                this.ddlMejoramientoRegularidad.DataValueField = "id_regularidad";
                this.ddlMejoramientoRegularidad.DataTextField = "nombre_regularidad";
                this.ddlMejoramientoRegularidad.DataSource = regularidad;
                this.ddlMejoramientoDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddlMejoramientoDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddlMejoramientoDesarrollo.DataSource = desarrollo;
                this.ddlMejoramientoBrotacion.DataValueField = "id_brotacion";
                this.ddlMejoramientoBrotacion.DataTextField = "nombre_brotacion";
                this.ddlMejoramientoBrotacion.DataSource = brotacion;
                this.ddlMejoramientoEmergencia.DataValueField = "id_emergencia";
                this.ddlMejoramientoEmergencia.DataTextField = "nombre_emergencia";
                this.ddlMejoramientoEmergencia.DataSource = emergencia;

                this.ddlMejoramientoEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddlMejoramientoEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddlMejoramientoEmergencia40.DataSource = emergencia40;
                this.ddlMejoramientoMetribuzina.DataValueField = "id_metribuzina";
                this.ddlMejoramientoMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddlMejoramientoMetribuzina.DataSource = metribuzina;
                this.ddlMejoramientoTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddlMejoramientoTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddlMejoramientoTuberculosVerdes.DataSource = verdes;
                this.ddlMejoramientoTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddlMejoramientoTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddlMejoramientoTizonFollaje.DataSource = tizon_follaje;
                this.ddlMejoramientoTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddlMejoramientoTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddlMejoramientoTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddlMejoramientoNumero.DataValueField = "id_numero_tuberculos";
                this.ddlMejoramientoNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddlMejoramientoNumero.DataSource = numero;
                this.ddlMejoramientoFertilidad.DataValueField = "id_fertilidad";
                this.ddlMejoramientoFertilidad.DataTextField = "nombre_fertilidad";
                this.ddlMejoramientoFertilidad.DataSource = fertilidad;
                this.ddlMejoramientoDestino.DataValueField = "id_destino";
                this.ddlMejoramientoDestino.DataTextField = "nombre_destino";
                this.ddlMejoramientoDestino.DataSource = destino;
                this.DataBind();
            }
        }

        private void SeleccionDropDown()
        {
            if (this.ddlMejoramientoColorCarne.SelectedIndex > 0)
                this.ddlMejoramientoColorCarne.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoColorCarne.BackColor = Color.Transparent;
            if (this.ddlMejoramientoColorPiel.SelectedIndex > 0)
                this.ddlMejoramientoColorPiel.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoColorPiel.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTamaño.SelectedIndex > 0)
                this.ddlMejoramientoTamaño.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTamaño.BackColor = Color.Transparent;
            if (this.ddlMejoramientoMadurez.SelectedIndex > 0)
                this.ddlMejoramientoMadurez.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoMadurez.BackColor = Color.Transparent;
            if (this.ddlMejoramientoForma.SelectedIndex > 0)
                this.ddlMejoramientoForma.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoForma.BackColor = Color.Transparent;
            if (this.ddlMejoramientoCalidadPiel.SelectedIndex > 0)
                this.ddlMejoramientoCalidadPiel.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoCalidadPiel.BackColor = Color.Transparent;
            if (this.ddlMejoramientoDistribucion.SelectedIndex > 0)
                this.ddlMejoramientoDistribucion.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoDistribucion.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTipoHoja.SelectedIndex > 0)
                this.ddlMejoramientoTipoHoja.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTipoHoja.BackColor = Color.Transparent;
            if (this.ddlMejoramientoProfundidad.SelectedIndex > 0)
                this.ddlMejoramientoProfundidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoProfundidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoRegularidad.SelectedIndex > 0)
                this.ddlMejoramientoRegularidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoRegularidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoDesarrollo.SelectedIndex > 0)
                this.ddlMejoramientoDesarrollo.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoDesarrollo.BackColor = Color.Transparent;
            if (this.ddlMejoramientoBrotacion.SelectedIndex > 0)
                this.ddlMejoramientoBrotacion.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoBrotacion.BackColor = Color.Transparent;
            if (this.ddlMejoramientoEmergencia.SelectedIndex > 0)
                this.ddlMejoramientoEmergencia.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoEmergencia.BackColor = Color.Transparent;
            if (this.ddlMejoramientoEmergencia40.SelectedIndex > 0)
                this.ddlMejoramientoEmergencia40.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoEmergencia40.BackColor = Color.Transparent;
            if (this.ddlMejoramientoMetribuzina.SelectedIndex > 0)
                this.ddlMejoramientoMetribuzina.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoMetribuzina.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTuberculosVerdes.SelectedIndex > 0)
                this.ddlMejoramientoTuberculosVerdes.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTuberculosVerdes.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTizonFollaje.SelectedIndex > 0)
                this.ddlMejoramientoTizonFollaje.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTizonFollaje.BackColor = Color.Transparent;
            if (this.ddlMejoramientoTizonTuberculo.SelectedIndex > 0)
                this.ddlMejoramientoTizonTuberculo.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoTizonTuberculo.BackColor = Color.Transparent;
            if (this.ddlMejoramientoNumero.SelectedIndex > 0)
                this.ddlMejoramientoNumero.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoNumero.BackColor = Color.Transparent;
            if (this.ddlMejoramientoFertilidad.SelectedIndex > 0)
                this.ddlMejoramientoFertilidad.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoFertilidad.BackColor = Color.Transparent;
            if (this.ddlMejoramientoDestino.SelectedIndex > 0)
                this.ddlMejoramientoDestino.BackColor = Color.LightBlue;
            else
                this.ddlMejoramientoDestino.BackColor = Color.Transparent;
        }

        private void RefreshDropDown()
        {
            this.ddlMejoramientoColorCarne.SelectedIndex = 0;
            this.ddlMejoramientoColorPiel.SelectedIndex = 0;
            this.ddlMejoramientoTamaño.SelectedIndex = 0;
            this.ddlMejoramientoMadurez.SelectedIndex = 0;
            this.ddlMejoramientoForma.SelectedIndex = 0;
            this.ddlMejoramientoCalidadPiel.SelectedIndex = 0;
            this.ddlMejoramientoDistribucion.SelectedIndex = 0;
            this.ddlMejoramientoTipoHoja.SelectedIndex = 0;
            this.ddlMejoramientoProfundidad.SelectedIndex = 0;
            this.ddlMejoramientoRegularidad.SelectedIndex = 0;
            this.ddlMejoramientoDesarrollo.SelectedIndex = 0;
            this.ddlMejoramientoBrotacion.SelectedIndex = 0;
            this.ddlMejoramientoEmergencia.SelectedIndex = 0;
            this.ddlMejoramientoEmergencia40.SelectedIndex = 0;
            this.ddlMejoramientoMetribuzina.SelectedIndex = 0;
            this.ddlMejoramientoTuberculosVerdes.SelectedIndex = 0;
            this.ddlMejoramientoTizonFollaje.SelectedIndex = 0;
            this.ddlMejoramientoTizonTuberculo.SelectedIndex = 0;
            this.ddlMejoramientoNumero.SelectedIndex = 0;
            this.ddlMejoramientoFertilidad.SelectedIndex = 0;
            this.ddlMejoramientoDestino.SelectedIndex = 0;
        }

        protected void btnCaracteristicaMadre_Click(object sender, EventArgs e)
        {            
            CatalogMadre madre = new CatalogMadre();            
            List<Madre> lista = new List<Madre>();

            if (this.txtMadre.Text.Equals(""))
            {
                SeleccionDropDown();
                string tamaño = this.ddlMejoramientoTamaño.SelectedValue;
                string madurez = this.ddlMejoramientoMadurez.SelectedValue;
                string tipo_hoja = this.ddlMejoramientoTipoHoja.SelectedValue;
                string calidad_piel = this.ddlMejoramientoCalidadPiel.SelectedValue;
                string forma = this.ddlMejoramientoForma.SelectedValue;
                string distribucion = this.ddlMejoramientoDistribucion.SelectedValue;
                string profundidad = this.ddlMejoramientoProfundidad.SelectedValue;
                string regularidad = this.ddlMejoramientoRegularidad.SelectedValue;
                string desarrollo_follaje = this.ddlMejoramientoDesarrollo.SelectedValue;
                string brotacion = this.ddlMejoramientoBrotacion.SelectedValue;
                string emergencia = this.ddlMejoramientoEmergencia.SelectedValue;
                string emergencia40 = this.ddlMejoramientoEmergencia40.SelectedValue;
                string metribuzina = this.ddlMejoramientoMetribuzina.SelectedValue;
                string verdes = this.ddlMejoramientoTuberculosVerdes.SelectedValue;
                string tizon_follaje = this.ddlMejoramientoTizonFollaje.SelectedValue;
                string tizon_tuberculo = this.ddlMejoramientoTizonTuberculo.SelectedValue;
                string numero = this.ddlMejoramientoNumero.SelectedValue;
                string fertilidad = this.ddlMejoramientoFertilidad.SelectedValue;
                string destino = this.ddlMejoramientoDestino.SelectedValue;
                Madre mama = new Madre(Int32.Parse(tamaño), Int32.Parse(madurez), Int32.Parse(tipo_hoja), Int32.Parse(calidad_piel),
                    Int32.Parse(forma), Int32.Parse(distribucion), Int32.Parse(profundidad), Int32.Parse(regularidad),
                    Int32.Parse(desarrollo_follaje), Int32.Parse(brotacion), Int32.Parse(emergencia), Int32.Parse(emergencia40),
                    Int32.Parse(metribuzina), Int32.Parse(verdes), Int32.Parse(tizon_follaje), Int32.Parse(tizon_tuberculo),
                    Int32.Parse(numero), Int32.Parse(fertilidad), Int32.Parse(destino));                
                lista = madre.getMadre(mama);                
            }
            else
            {
                RefreshDropDown();
                SeleccionDropDown();
                string nombre = this.txtMadre.Text;
                lista = madre.getMadreNombre(nombre); 
            }
            
            this.gdvCaracteristicaMadre.DataSource = lista;
            this.gdvCaracteristicaMadre.DataBind();
        }

        protected void btnCaracteristicaPadre_Click(object sender, EventArgs e)
        {            
            CatalogPadre padre = new CatalogPadre();
            List<Padre> lista = new List<Padre>();

            if (this.txtPadre.Text.Equals(""))
            {
                SeleccionDropDown();
                string tamaño = this.ddlMejoramientoTamaño.SelectedValue;
                string madurez = this.ddlMejoramientoMadurez.SelectedValue;
                string tipo_hoja = this.ddlMejoramientoTipoHoja.SelectedValue;
                string calidad_piel = this.ddlMejoramientoCalidadPiel.SelectedValue;
                string forma = this.ddlMejoramientoForma.SelectedValue;
                string distribucion = this.ddlMejoramientoDistribucion.SelectedValue;
                string profundidad = this.ddlMejoramientoProfundidad.SelectedValue;
                string regularidad = this.ddlMejoramientoRegularidad.SelectedValue;
                string desarrollo_follaje = this.ddlMejoramientoDesarrollo.SelectedValue;
                string brotacion = this.ddlMejoramientoBrotacion.SelectedValue;
                string emergencia = this.ddlMejoramientoEmergencia.SelectedValue;
                string emergencia40 = this.ddlMejoramientoEmergencia40.SelectedValue;
                string metribuzina = this.ddlMejoramientoMetribuzina.SelectedValue;
                string verdes = this.ddlMejoramientoTuberculosVerdes.SelectedValue;
                string tizon_follaje = this.ddlMejoramientoTizonFollaje.SelectedValue;
                string tizon_tuberculo = this.ddlMejoramientoTizonTuberculo.SelectedValue;
                string numero = this.ddlMejoramientoNumero.SelectedValue;
                string fertilidad = this.ddlMejoramientoFertilidad.SelectedValue;
                string destino = this.ddlMejoramientoDestino.SelectedValue;
                Padre papa = new Padre(Int32.Parse(tamaño), Int32.Parse(madurez), Int32.Parse(tipo_hoja), Int32.Parse(calidad_piel),
                    Int32.Parse(forma), Int32.Parse(distribucion), Int32.Parse(profundidad), Int32.Parse(regularidad),
                    Int32.Parse(desarrollo_follaje), Int32.Parse(brotacion), Int32.Parse(emergencia), Int32.Parse(emergencia40),
                    Int32.Parse(metribuzina), Int32.Parse(verdes), Int32.Parse(tizon_follaje), Int32.Parse(tizon_tuberculo),
                    Int32.Parse(numero), Int32.Parse(fertilidad), Int32.Parse(destino));
                lista = padre.getPadre(papa);
            }
            else
            {
                RefreshDropDown();
                SeleccionDropDown();
                string nombre = this.txtPadre.Text;
                lista = padre.getPadreNombre(nombre);
            }

            this.gdvCaracteristicaPadre.DataSource = lista;
            this.gdvCaracteristicaPadre.DataBind();
        }        

        protected void btnMejoramientoCruzamiento_Click(object sender, EventArgs e)
        {
            int selectedMadre = this.gdvCaracteristicaMadre.SelectedIndex;
            string codigoMadre = HttpUtility.HtmlDecode((string)this.gdvCaracteristicaMadre.Rows[selectedMadre].Cells[1].Text);

            int selectedPadre = this.gdvCaracteristicaPadre.SelectedIndex;
            string codigoPadre = HttpUtility.HtmlDecode((string)this.gdvCaracteristicaPadre.Rows[selectedPadre].Cells[1].Text);

            Session.Add("CodigoMadre", codigoMadre);            
            Session.Add("CodigoPadre", codigoPadre);
            //Server.Transfer("Cruzamiento.aspx");
            // Segunda Parte : las variables provenientes de la primera pagina. en page load de form cruzamiento
            //string codigoMadre = (string)(Session["CodigoMadre"]);
            //string codigoPadre = (string)(Session["CodigoPadre"]);
        }

        protected void btnMejoramientoCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mejoramiento.aspx");            
        }

        protected void btnMejoramientoRefresh_Click(object sender, EventArgs e)
        {
            RefreshDropDown();
            this.txtMadre.Text = "";
            this.txtPadre.Text = "";
            this.gdvCaracteristicaMadre.DataBind();
            this.gdvCaracteristicaPadre.DataBind();
            SeleccionDropDown();
        }        
    }
}