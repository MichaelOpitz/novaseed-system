using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Globalization;
using System.Drawing;

namespace Project.Novaseed
{
    public partial class Cosecha6papas : System.Web.UI.Page
    {
        private int valorAñoInt32, cont6papas12papas;
        private string valorAñoString;

        protected void Page_Load(object sender, EventArgs e)
        {                        
            cont6papas12papas = 0;

            CatalogFertilidad cf = new CatalogFertilidad();
            List<Project.BusinessRules.Fertilidad> fertilidad = cf.getFertilidad();

            CatalogEmergencia40Dias ce40 = new CatalogEmergencia40Dias();
            List<Project.BusinessRules.Emergencia40Dias> emergencia40 = ce40.getEmergencia40Dias();
            CatalogMetribuzina cmet = new CatalogMetribuzina();
            List<Project.BusinessRules.Metribuzina> metribuzina = cmet.getMetribuzina();
            CatalogEmergencia ce = new CatalogEmergencia();
            List<Project.BusinessRules.Emergencia> emergencia = ce.getEmergencia();

            CatalogMadurez cm = new CatalogMadurez();
            List<Project.BusinessRules.Madurez> madurez = cm.getMadurez();
            CatalogDesarrolloFollaje cdf = new CatalogDesarrolloFollaje();
            List<Project.BusinessRules.DesarrolloFollaje> desarrollo = cdf.getDesarrolloFollaje();
            CatalogTipoHoja cth = new CatalogTipoHoja();
            List<Project.BusinessRules.TipoHoja> hoja = cth.getTipoHoja();
            CatalogBrotacion cb = new CatalogBrotacion();
            List<Project.BusinessRules.Brotacion> brotacion = cb.getBrotacion();
            CatalogTamaño ct = new CatalogTamaño();
            List<Project.BusinessRules.Tamaño> tamaño = ct.getTamaño();
            CatalogDistribucionCalibre cdc = new CatalogDistribucionCalibre();
            List<Project.BusinessRules.DistribucionCalibre> distribucion = cdc.getDistribucionCalibre();
            CatalogFormaTuberculos cft = new CatalogFormaTuberculos();
            List<Project.BusinessRules.FormaTuberculos> forma = cft.getFormaTuberculos();
            CatalogRegularidad cr = new CatalogRegularidad();
            List<Project.BusinessRules.Regularidad> regularidad = cr.getRegularidad();
            CatalogProfundidadOjo cpo = new CatalogProfundidadOjo();
            List<Project.BusinessRules.ProfundidadOjo> profundidad = cpo.getProfundidadOjo();
            CatalogCalidadPiel ccpiel = new CatalogCalidadPiel();
            List<Project.BusinessRules.CalidadPiel> calidad = ccpiel.getCalidadPiel();
            
                        
            CatalogTuberculosVerdes ctv = new CatalogTuberculosVerdes();
            List<Project.BusinessRules.TuberculosVerdes> verdes = ctv.getTuberculosVerdes();
            CatalogTizonTardioFollaje cttf = new CatalogTizonTardioFollaje();
            List<Project.BusinessRules.TizonTardioFollaje> tizon_follaje = cttf.getTizonTardioFollaje();
            CatalogTizonTardioTuberculo cttt = new CatalogTizonTardioTuberculo();
            List<Project.BusinessRules.TizonTardioTuberculo> tizon_tuberculo = cttt.getTizonTardioTuberculo();
            CatalogNumeroTuberculos cnt = new CatalogNumeroTuberculos();
            List<Project.BusinessRules.NumeroTuberculos> numero = cnt.getNumeroTuberculos();
            CatalogCiudad ccity = new CatalogCiudad();
            List<Project.BusinessRules.Ciudad> city = ccity.GetCiudad();

            CatalogColorCarne ccc = new CatalogColorCarne();
            List<Project.BusinessRules.ColorCarne> carne = ccc.getColorCarne();
            CatalogColorPiel ccp = new CatalogColorPiel();
            List<Project.BusinessRules.ColorPiel> piel = ccp.getColorPiel();

            CatalogSensibilidadQuimica csq = new CatalogSensibilidadQuimica();
            List<Project.BusinessRules.SensibilidadQuimica> sensibilidad = csq.GetSensibilidadQuimica();
            CatalogFacilidadMuerte cfm = new CatalogFacilidadMuerte();
            List<Project.BusinessRules.FacilidadMuerte> facilidad = cfm.GetFacilidadMuerte();

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            if (!Page.IsPostBack)
            {
                this.ddl6papasFertilidad.DataValueField = "id_fertilidad";
                this.ddl6papasFertilidad.DataTextField = "nombre_fertilidad";
                this.ddl6papasFertilidad.DataSource = fertilidad;
                
                this.ddl6papasEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddl6papasEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddl6papasEmergencia40.DataSource = emergencia40;
                this.ddl6papasMetribuzina.DataValueField = "id_metribuzina";
                this.ddl6papasMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddl6papasMetribuzina.DataSource = metribuzina;
                this.ddl6papasEmergencia.DataValueField = "id_emergencia";
                this.ddl6papasEmergencia.DataTextField = "nombre_emergencia";
                this.ddl6papasEmergencia.DataSource = emergencia;

                this.ddl6papasMadurez.DataValueField = "id_madurez";
                this.ddl6papasMadurez.DataTextField = "nombre_madurez";
                this.ddl6papasMadurez.DataSource = madurez;
                this.ddl6papasDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddl6papasDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddl6papasDesarrollo.DataSource = desarrollo;
                this.ddl6papasTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddl6papasTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddl6papasTipoHoja.DataSource = hoja;
                this.ddl6papasBrotacion.DataValueField = "id_brotacion";
                this.ddl6papasBrotacion.DataTextField = "nombre_brotacion";
                this.ddl6papasBrotacion.DataSource = brotacion;


                this.ddl6papasTamaño.DataValueField = "id_tamaño";
                this.ddl6papasTamaño.DataTextField = "nombre_tamaño";
                this.ddl6papasTamaño.DataSource = tamaño;
                this.ddl6papasDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddl6papasDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddl6papasDistribucion.DataSource = distribucion;
                this.ddl6papasForma.DataValueField = "id_forma";
                this.ddl6papasForma.DataTextField = "nombre_forma";
                this.ddl6papasForma.DataSource = forma;
                this.ddl6papasRegularidad.DataValueField = "id_regularidad";
                this.ddl6papasRegularidad.DataTextField = "nombre_regularidad";
                this.ddl6papasRegularidad.DataSource = regularidad;
                this.ddl6papasProfundidad.DataValueField = "id_profundidad";
                this.ddl6papasProfundidad.DataTextField = "profundidad_ojo";
                this.ddl6papasProfundidad.DataSource = profundidad;
                this.ddl6papasCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddl6papasCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddl6papasCalidadPiel.DataSource = calidad;
                this.ddl6papasTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddl6papasTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddl6papasTuberculosVerdes.DataSource = verdes;
                this.ddl6papasTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddl6papasTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddl6papasTizonFollaje.DataSource = tizon_follaje;
                this.ddl6papasTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddl6papasTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddl6papasTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddl6papasNumero.DataValueField = "id_numero_tuberculos";
                this.ddl6papasNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddl6papasNumero.DataSource = numero;
                this.ddl6papasCiudadPlantacion.DataValueField = "id_ciudad";
                this.ddl6papasCiudadPlantacion.DataTextField = "nombre_ciudad";
                this.ddl6papasCiudadPlantacion.DataSource = city;

                this.lst6papasColorCarne.DataValueField = "id_color_carne";
                this.lst6papasColorCarne.DataTextField = "nombre_color_carne";
                this.lst6papasColorCarne.DataSource = carne;
                this.lst6papasColorPiel.DataValueField = "id_color_piel";
                this.lst6papasColorPiel.DataTextField = "nombre_color_piel";
                this.lst6papasColorPiel.DataSource = piel;

                this.ddl6papasSensibilidadQuimica.DataValueField = "id_sensibilidad_quimica";
                this.ddl6papasSensibilidadQuimica.DataTextField = "nombre_sensibilidad_quimica";
                this.ddl6papasSensibilidadQuimica.DataSource = sensibilidad;
                this.ddl6papasFacilidadMuerte.DataValueField = "id_facilidad_muerte";
                this.ddl6papasFacilidadMuerte.DataTextField = "nombre_facilidad_muerte";
                this.ddl6papasFacilidadMuerte.DataSource = facilidad;

                this.lbl6papasAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogCosecha cc6p = new CatalogCosecha();
                //Le pasa un 1 porque es la temporada 6Papas
                this.gdv6papas.DataSource = cc6p.GetTablaCosecha(valorAñoInt32, 1);                
                this.DataBind();
            }
        }

        /*
        * Llena la grilla de la temporada 6papas con el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCosecha cc6p = new CatalogCosecha();
            //Le pasa un 1 porque es la temporada 6Papas
            this.gdv6papas.DataSource = cc6p.GetTablaCosecha(valorAñoInt32, 1);
            this.gdv6papas.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW 6PAPAS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //el tercer parametro es 2 por el id_temporada que es 12 papas(2 para el color, 1 para el obtener en catalog)
                int index6papas12papas = cc.GetCosechaTemporadasAvanzadas(valorAñoInt32, cont6papas12papas, 2);

                if (index6papas12papas == 1)
                    e.Row.BackColor = Color.LightGreen;
                else
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                cont6papas12papas = cont6papas12papas + 1;
            }
        }

        protected void Cosecha6papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[e.RowIndex].Cells[2].Text);
            int valor = cc.DeleteCosecha6papas(Int32.Parse(id_cosecha));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la variedad!')</script>");

            PoblarGrilla();
        }

        protected void gdv6papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdv6papas.SelectedIndex;
            CatalogCosecha cc = new CatalogCosecha();
            //id_cosecha
            string id_cosechaString = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[selected].Cells[2].Text);
            int id_cosecha = Int32.Parse(id_cosechaString);

            //Código Seleccionado
            string codigo = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[selected].Cells[8].Text);
            this.txt6papasCodigoSeleccionado.Text = codigo;

            //Flor
            bool flor = cc.GetCosechaValoresBooleanos(id_cosecha, 0);
            this.chk6papasFlor.Checked = flor;

            //Cantidad Papas
            int cantidad_papas = cc.GetCosechaValoresEnteros(id_cosecha, 1);
            this.txt6papasCantidadPapas.Text = cantidad_papas.ToString();

            //Bayas
            bool bayas = cc.GetCosechaValoresBooleanos(id_cosecha, 2);
            this.chk6papasBayas.Checked = bayas;

            //Posicion 6papas
            string posicion = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[selected].Cells[7].Text);
            this.txt6papasPosicion.Text = posicion;

            //Fertilidad
            int fertilidad = cc.GetCosechaValoresEnteros(id_cosecha, 3);
            this.ddl6papasFertilidad.SelectedValue = fertilidad.ToString();

            //Emergencia 40 días
            int emergencia_40 = cc.GetCosechaValoresEnteros(id_cosecha, 4);
            this.ddl6papasEmergencia40.SelectedValue = emergencia_40.ToString();

            //Metribuzina
            int metribuzina = cc.GetCosechaValoresEnteros(id_cosecha, 5);
            this.ddl6papasMetribuzina.SelectedValue = metribuzina.ToString();

            //Emergencia
            int emergencia = cc.GetCosechaValoresEnteros(id_cosecha, 6);
            this.ddl6papasEmergencia.SelectedValue = emergencia.ToString();

            //Madurez
            int madurez = cc.GetCosechaValoresEnteros(id_cosecha, 7);
            this.ddl6papasMadurez.SelectedValue = madurez.ToString();

            //Desarrollo Follaje
            int desarrollo_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 8);
            this.ddl6papasDesarrollo.SelectedValue = desarrollo_follaje.ToString();

            //Tipo Hoja
            int tipo_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 9);
            this.ddl6papasTipoHoja.SelectedValue = tipo_hoja.ToString();

            //Brotacion
            int brotacion = cc.GetCosechaValoresEnteros(id_cosecha, 10);
            this.ddl6papasBrotacion.SelectedValue = brotacion.ToString();

            //Tamaño
            int tamaño = cc.GetCosechaValoresEnteros(id_cosecha, 11);
            this.ddl6papasTamaño.SelectedValue = tamaño.ToString();

            //Distribucion calibre
            int distribucion = cc.GetCosechaValoresEnteros(id_cosecha, 12);
            this.ddl6papasDistribucion.SelectedValue = distribucion.ToString();

            //Forma
            int forma = cc.GetCosechaValoresEnteros(id_cosecha, 13);
            this.ddl6papasForma.SelectedValue = forma.ToString();

            //Regularidad
            int regularidad = cc.GetCosechaValoresEnteros(id_cosecha, 14);
            this.ddl6papasRegularidad.SelectedValue = regularidad.ToString();

            //Profundidad Ojo
            int profundidad = cc.GetCosechaValoresEnteros(id_cosecha, 15);
            this.ddl6papasProfundidad.SelectedValue = profundidad.ToString();

            //Calidad Piel
            int calidad = cc.GetCosechaValoresEnteros(id_cosecha, 16);
            this.ddl6papasCalidadPiel.SelectedValue = calidad.ToString();

            //Tuberculos Verdes
            int verdes = cc.GetCosechaValoresEnteros(id_cosecha, 17);
            this.ddl6papasTuberculosVerdes.SelectedValue = verdes.ToString();

            //Tizon Tardio Follaje
            int tizon_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 18);
            this.ddl6papasTizonFollaje.SelectedValue = tizon_follaje.ToString();

            //Tizon Tardio Tuberculo
            int tizon_tuberculo = cc.GetCosechaValoresEnteros(id_cosecha, 19);
            this.ddl6papasTizonTuberculo.SelectedValue = tizon_tuberculo.ToString();

            //Numero Tuberculos
            int numero = cc.GetCosechaValoresEnteros(id_cosecha, 20);
            this.ddl6papasNumero.SelectedValue = numero.ToString();

            //Ciudad
            int ciudad = cc.GetCosechaValoresEnteros(id_cosecha, 21);
            this.ddl6papasCiudadPlantacion.SelectedValue = ciudad.ToString();

            //Color Carne
            int carne = cc.GetCosechaValoresEnteros(id_cosecha, 22);
            this.lst6papasColorCarne.SelectedValue = carne.ToString();

            //Color Piel
            int piel = cc.GetCosechaValoresEnteros(id_cosecha, 23);
            this.lst6papasColorPiel.SelectedValue = piel.ToString();

            //Total Kilogramos
            double total_kg = cc.GetCosechaValoresDouble(id_cosecha, 24);
            this.txt6papasTotalKg.Text = total_kg.ToString();

            //Tuberculos/planta
            double tuberculos_planta = cc.GetCosechaValoresDouble(id_cosecha, 25);
            this.txt6papasTuberculosPlanta.Text = tuberculos_planta.ToString();

            //Toneladas/hectarea
            double toneladas_hectarea = cc.GetCosechaValoresDouble(id_cosecha, 26);
            this.txt6papasToneladasHectarea.Text = toneladas_hectarea.ToString();

            // % Relacion Standard
            int porcentaje_relacion = cc.GetCosechaValoresEnteros(id_cosecha, 27);
            this.txt6papasRelacionStandard.Text = porcentaje_relacion.ToString() + "%";

            //Consumo
            int consumo = cc.GetCosechaValoresEnteros(id_cosecha, 28);
            this.txt6papasConsumo.Text = consumo.ToString();

            //Semillon
            int semillon = cc.GetCosechaValoresEnteros(id_cosecha, 29);
            this.txt6papasSemillon.Text = semillon.ToString();

            //Semilla
            int semilla = cc.GetCosechaValoresEnteros(id_cosecha, 30);
            this.txt6papasSemilla.Text = semilla.ToString();

            //Semillita
            int semillita = cc.GetCosechaValoresEnteros(id_cosecha, 31);
            this.txt6papasSemillita.Text = semillita.ToString();

            //Bajo Calibre
            int bajo_calibre = cc.GetCosechaValoresEnteros(id_cosecha, 32);
            this.txt6papasBajoCalibre.Text = bajo_calibre.ToString();

            //Numero Tallos
            int numero_tallos = cc.GetCosechaValoresEnteros(id_cosecha, 33);
            this.txt6papasNumeroTallos.Text = numero_tallos.ToString();

            //Sensibilidad Quimica
            int sensibilidad_quimica = cc.GetCosechaValoresEnteros(id_cosecha, 34);
            this.ddl6papasSensibilidadQuimica.SelectedValue = sensibilidad_quimica.ToString();

            //Facilidad Muerte
            int facilidad_muerte = cc.GetCosechaValoresEnteros(id_cosecha, 35);
            this.ddl6papasFacilidadMuerte.SelectedValue = facilidad_muerte.ToString();

            //Dormancia
            int dormancia = cc.GetCosechaValoresEnteros(id_cosecha, 36);
            this.txt6papasDormancia.Text = dormancia.ToString();

            //Tolerancia Sequia
            int tolerancia_sequia = cc.GetCosechaValoresEnteros(id_cosecha, 37);
            this.txt6papasToleranciaSequia.Text = tolerancia_sequia.ToString();

            //Tolerancia Calor
            int tolerancia_calor = cc.GetCosechaValoresEnteros(id_cosecha, 38);
            this.txt6papasToleranciaCalor.Text = tolerancia_calor.ToString();

            //Tolerancia Sal
            int tolerancia_sal = cc.GetCosechaValoresEnteros(id_cosecha, 39);
            this.txt6papasToleranciaSal.Text = tolerancia_sal.ToString();

            //Daño Cosecha
            int daño_cosecha = cc.GetCosechaValoresEnteros(id_cosecha, 40);
            this.txt6papasDañoCosecha.Text = daño_cosecha.ToString();

            //Hematomas
            double hematomas = cc.GetCosechaValoresDouble(id_cosecha, 41);
            this.txt6papasHematomas.Text = hematomas.ToString();

            //Tizon Hoja
            int tizon_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 42);
            this.txt6papasTizonHoja.Text = tizon_hoja.ToString();

            //Putrefaccion Suave
            int putrefaccion_suave = cc.GetCosechaValoresEnteros(id_cosecha, 43);
            this.txt6papasPutrefaccionSuave.Text = putrefaccion_suave.ToString();

            //Putrefaccion Rosa
            int putrefaccion_rosa = cc.GetCosechaValoresEnteros(id_cosecha, 44);
            this.txt6papasPutrefaccionRosa.Text = putrefaccion_rosa.ToString();

            //Silver Scurf
            int silver_scurf = cc.GetCosechaValoresEnteros(id_cosecha, 45);
            this.txt6papasSilverScurf.Text = silver_scurf.ToString();

            //Blackleg
            int blackleg = cc.GetCosechaValoresEnteros(id_cosecha, 46);
            this.txt6papasBlackleg.Text = blackleg.ToString();
        }

        protected void btn6papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdv6papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[selected].Cells[2].Text);
                string cantidad_papas = this.txt6papasCantidadPapas.Text;
                //Reemplaza las comas por los puntos para agregar el valor tipo double en la base de datos                
                string posicion_cosecha = this.txt6papasPosicion.Text.Replace(",", ".");
                bool flor_cosecha = false;
                if (this.chk6papasFlor.Checked == true)
                    flor_cosecha = true;
                else
                    flor_cosecha = false;
                bool bayas_cosecha = false;
                if (this.chk6papasBayas.Checked == true)
                    bayas_cosecha = true;
                else
                    bayas_cosecha = false;
                string id_fertilidad = this.ddl6papasFertilidad.SelectedValue;
                string id_emergencia40 = this.ddl6papasEmergencia40.SelectedValue;
                string id_metribuzina = this.ddl6papasMetribuzina.SelectedValue;
                string id_emergencia = this.ddl6papasEmergencia.SelectedValue;

                string id_madurez = this.ddl6papasMadurez.SelectedValue;
                string id_desarrollo = this.ddl6papasDesarrollo.SelectedValue;
                string id_tipo_hoja = this.ddl6papasTipoHoja.SelectedValue;
                string id_brotacion = this.ddl6papasBrotacion.SelectedValue;
                string id_tamaño = this.ddl6papasTamaño.SelectedValue;
                string id_distribucion = this.ddl6papasDistribucion.SelectedValue;
                string id_forma = this.ddl6papasForma.SelectedValue;
                string id_regularidad = this.ddl6papasRegularidad.SelectedValue;
                string id_profundidad = this.ddl6papasProfundidad.SelectedValue;

                string id_calidad = this.ddl6papasCalidadPiel.SelectedValue;
                string id_verdes = this.ddl6papasTuberculosVerdes.SelectedValue;
                string id_tizon_follaje = this.ddl6papasTizonFollaje.SelectedValue;
                string id_tizon_tuberculo = this.ddl6papasTizonTuberculo.SelectedValue;
                string id_numero = this.ddl6papasNumero.SelectedValue;
                string id_ciudad = this.ddl6papasCiudadPlantacion.SelectedValue;

                string total_kg = this.txt6papasTotalKg.Text.Replace(",", ".");
                string tuberculos_planta = this.txt6papasTuberculosPlanta.Text.Replace(",", ".");
                string consumo = this.txt6papasConsumo.Text;
                string semillon = this.txt6papasSemillon.Text;
                string semilla = this.txt6papasSemilla.Text;
                string semillita = this.txt6papasSemillita.Text;
                string bajo_calibre = this.txt6papasBajoCalibre.Text;
                string numero_tallos = this.txt6papasNumeroTallos.Text;

                string id_sensibildiad_quimica = this.ddl6papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl6papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt6papasDormancia.Text;
                string tolerancia_sequia = this.txt6papasToleranciaSequia.Text;
                string tolerancia_calor = this.txt6papasToleranciaCalor.Text;
                string tolerancia_sal = this.txt6papasToleranciaSal.Text;
                string daño_cosecha = this.txt6papasDañoCosecha.Text;
                string tizon_hoja = this.txt6papasTizonHoja.Text;
                string putrefaccion_suave = this.txt6papasPutrefaccionSuave.Text;
                string putrefaccion_rosa = this.txt6papasPutrefaccionRosa.Text;
                string silver_scurf = this.txt6papasSilverScurf.Text;
                string blackleg = this.txt6papasBlackleg.Text;

                CatalogCosecha cc = new CatalogCosecha();
                Cosecha cosecha = new Cosecha(Int32.Parse(id_cosecha), Int32.Parse(cantidad_papas), Double.Parse(posicion_cosecha, CultureInfo.InvariantCulture),
                    flor_cosecha, bayas_cosecha, Int32.Parse(id_fertilidad), Int32.Parse(id_emergencia40), Int32.Parse(id_metribuzina),
                    Int32.Parse(id_emergencia), Int32.Parse(id_madurez), Int32.Parse(id_desarrollo), Int32.Parse(id_tipo_hoja),
                    Int32.Parse(id_brotacion), Int32.Parse(id_tamaño), Int32.Parse(id_distribucion), Int32.Parse(id_forma),
                    Int32.Parse(id_regularidad), Int32.Parse(id_profundidad), Int32.Parse(id_calidad), Int32.Parse(id_verdes),
                    Int32.Parse(id_tizon_follaje), Int32.Parse(id_tizon_tuberculo), Int32.Parse(id_numero), Int32.Parse(id_ciudad),
                    Double.Parse(total_kg, CultureInfo.InvariantCulture), Double.Parse(tuberculos_planta, CultureInfo.InvariantCulture), 
                    Int32.Parse(consumo), Int32.Parse(semillon), Int32.Parse(semilla), Int32.Parse(semillita), 
                    Int32.Parse(bajo_calibre), Int32.Parse(numero_tallos), Int32.Parse(id_sensibildiad_quimica), 
                    Int32.Parse(id_facilidad_muerte), Int32.Parse(dormancia), Int32.Parse(tolerancia_sequia), 
                    Int32.Parse(tolerancia_calor), Int32.Parse(tolerancia_sal), Int32.Parse(daño_cosecha),
                    Int32.Parse(tizon_hoja), Int32.Parse(putrefaccion_suave), Int32.Parse(putrefaccion_rosa),
                    Int32.Parse(silver_scurf), Int32.Parse(blackleg));

                int valor = cc.UpdateCosecha6papas(cosecha);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            PoblarGrilla();
        }

        protected void btn6papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btnAgregar12papas_Click(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdv6papas.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAgregar12Papas = (row.Cells[0].FindControl("chkAgregar12Papas") as CheckBox);
                    if (chkAgregar12Papas != null)
                        if (chkAgregar12Papas.Checked)
                        {
                            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv6papas.Rows[row.RowIndex].Cells[2].Text);
                            CatalogCosecha cc = new CatalogCosecha();
                            int existe_12papas = cc.AddCosecha12papas(Int32.Parse(id_cosecha));
                            if (existe_12papas == 1)
                                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La varieadd con ID: " + id_cosecha + " seleccionada ya está en temporadas avanzadas o no tiene una ciudad asignada')</script>");
                            else
                                agrego = 1;
                        }
                }

            if (agrego == 1)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Agregado Correctamente!')</script>");
                Response.Redirect("MenuGeneracion.aspx");
            }                                    
        }
    }
}