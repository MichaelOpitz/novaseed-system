using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;
using System.Globalization;

namespace Project.Novaseed
{
    public partial class Cosecha48papas : System.Web.UI.Page
    {
        private int cont48papasUPOV, valorAñoInt32;
        private string valorAñoString;
        private DataTable table;
        private List<string> listEnfermedad, listResistencia;

        protected void Page_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("nombre_enfermedad", typeof(string));
            table.Columns.Add("resistencia_variedad", typeof(string));

            cont48papasUPOV = 0;

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

            CatalogEnfermedades cenf = new CatalogEnfermedades();
            List<Project.BusinessRules.Enfermedades> enfermedad = cenf.GetEnfermedades();
            CatalogResistenciaVariedad crv = new CatalogResistenciaVariedad();
            List<Project.BusinessRules.ResistenciaVariedad> resistencia = crv.GetResistenciaVariedad();

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
                this.ddl48papasFertilidad.DataValueField = "id_fertilidad";
                this.ddl48papasFertilidad.DataTextField = "nombre_fertilidad";
                this.ddl48papasFertilidad.DataSource = fertilidad;

                this.ddl48papasEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddl48papasEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddl48papasEmergencia40.DataSource = emergencia40;
                this.ddl48papasMetribuzina.DataValueField = "id_metribuzina";
                this.ddl48papasMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddl48papasMetribuzina.DataSource = metribuzina;
                this.ddl48papasEmergencia.DataValueField = "id_emergencia";
                this.ddl48papasEmergencia.DataTextField = "nombre_emergencia";
                this.ddl48papasEmergencia.DataSource = emergencia;

                this.ddl48papasMadurez.DataValueField = "id_madurez";
                this.ddl48papasMadurez.DataTextField = "nombre_madurez";
                this.ddl48papasMadurez.DataSource = madurez;
                this.ddl48papasDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddl48papasDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddl48papasDesarrollo.DataSource = desarrollo;
                this.ddl48papasTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddl48papasTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddl48papasTipoHoja.DataSource = hoja;
                this.ddl48papasBrotacion.DataValueField = "id_brotacion";
                this.ddl48papasBrotacion.DataTextField = "nombre_brotacion";
                this.ddl48papasBrotacion.DataSource = brotacion;

                this.ddl48papasTamaño.DataValueField = "id_tamaño";
                this.ddl48papasTamaño.DataTextField = "nombre_tamaño";
                this.ddl48papasTamaño.DataSource = tamaño;
                this.ddl48papasDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddl48papasDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddl48papasDistribucion.DataSource = distribucion;
                this.ddl48papasForma.DataValueField = "id_forma";
                this.ddl48papasForma.DataTextField = "nombre_forma";
                this.ddl48papasForma.DataSource = forma;
                this.ddl48papasRegularidad.DataValueField = "id_regularidad";
                this.ddl48papasRegularidad.DataTextField = "nombre_regularidad";
                this.ddl48papasRegularidad.DataSource = regularidad;
                this.ddl48papasProfundidad.DataValueField = "id_profundidad";
                this.ddl48papasProfundidad.DataTextField = "profundidad_ojo";
                this.ddl48papasProfundidad.DataSource = profundidad;
                this.ddl48papasCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddl48papasCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddl48papasCalidadPiel.DataSource = calidad;
                this.ddl48papasTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddl48papasTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddl48papasTuberculosVerdes.DataSource = verdes;
                this.ddl48papasTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddl48papasTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddl48papasTizonFollaje.DataSource = tizon_follaje;
                this.ddl48papasTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddl48papasTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddl48papasTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddl48papasNumero.DataValueField = "id_numero_tuberculos";
                this.ddl48papasNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddl48papasNumero.DataSource = numero;
                this.ddl48papasCiudadPlantacion.DataValueField = "id_ciudad";
                this.ddl48papasCiudadPlantacion.DataTextField = "nombre_ciudad";
                this.ddl48papasCiudadPlantacion.DataSource = city;

                this.lst48papasColorCarne.DataValueField = "id_color_carne";
                this.lst48papasColorCarne.DataTextField = "nombre_color_carne";
                this.lst48papasColorCarne.DataSource = carne;
                this.lst48papasColorPiel.DataValueField = "id_color_piel";
                this.lst48papasColorPiel.DataTextField = "nombre_color_piel";
                this.lst48papasColorPiel.DataSource = piel;

                this.ddl48papasEnfermedad.DataValueField = "id_enfermedad";
                this.ddl48papasEnfermedad.DataTextField = "nombre_enfermedad";
                this.ddl48papasEnfermedad.DataSource = enfermedad;
                this.ddl48papasResistencia.DataValueField = "id_resistencia_variedad";
                this.ddl48papasResistencia.DataTextField = "nombre_resistencia_variedad";
                this.ddl48papasResistencia.DataSource = resistencia;

                this.ddl48papasSensibilidadQuimica.DataValueField = "id_sensibilidad_quimica";
                this.ddl48papasSensibilidadQuimica.DataTextField = "nombre_sensibilidad_quimica";
                this.ddl48papasSensibilidadQuimica.DataSource = sensibilidad;
                this.ddl48papasFacilidadMuerte.DataValueField = "id_facilidad_muerte";
                this.ddl48papasFacilidadMuerte.DataTextField = "nombre_facilidad_muerte";
                this.ddl48papasFacilidadMuerte.DataSource = facilidad;

                this.lbl48papasAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogCosecha cc48p = new CatalogCosecha();
                this.gdv48papas.DataSource = cc48p.GetTablaCosecha(valorAñoInt32, 4);
                this.DataBind();
            }
        }

        /*
        * Llena la grilla de la temporada 48papas con el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCosecha cc48p = new CatalogCosecha();
            this.gdv48papas.DataSource = cc48p.GetTablaCosecha(valorAñoInt32, 4);
            this.gdv48papas.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW 48PAPAS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //devuelve 1 y lo pinta de verde si esta en upov, 0 y rojo en caso contrario
                int index48papasUPOV = cc.GetCosechaEstaEnUPOV(valorAñoInt32, cont48papasUPOV);

                if (index48papasUPOV == 1)
                    e.Row.BackColor = Color.LightGreen;
                else
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                cont48papasUPOV = cont48papasUPOV + 1;
            }
        }

        protected void Cosecha48papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            //CatalogCosecha cc = new CatalogCosecha();
            //string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[e.RowIndex].Cells[2].Text);
            //int valor = cc.DeleteCosecha24papas(Int32.Parse(id_cosecha));
            //if (valor == 0)
            //    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la variedad!')</script>");

            //PoblarGrilla();
        }

        protected void btn48papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn48papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdv48papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[2].Text);
                string cantidad_papas = this.txt48papasCantidadPapas.Text;
                string posicion_cosecha = this.txt48papasPosicion.Text.Replace(",", ".");
                bool flor_cosecha = false;
                if (this.chk48papasFlor.Checked == true)
                    flor_cosecha = true;
                else
                    flor_cosecha = false;
                bool bayas_cosecha = false;
                if (this.chk48papasBayas.Checked == true)
                    bayas_cosecha = true;
                else
                    bayas_cosecha = false;
                string id_fertilidad = this.ddl48papasFertilidad.SelectedValue;
                string id_emergencia40 = this.ddl48papasEmergencia40.SelectedValue;
                string id_metribuzina = this.ddl48papasMetribuzina.SelectedValue;
                string id_emergencia = this.ddl48papasEmergencia.SelectedValue;

                string id_madurez = this.ddl48papasMadurez.SelectedValue;
                string id_desarrollo = this.ddl48papasDesarrollo.SelectedValue;
                string id_tipo_hoja = this.ddl48papasTipoHoja.SelectedValue;
                string id_brotacion = this.ddl48papasBrotacion.SelectedValue;
                string id_tamaño = this.ddl48papasTamaño.SelectedValue;
                string id_distribucion = this.ddl48papasDistribucion.SelectedValue;
                string id_forma = this.ddl48papasForma.SelectedValue;
                string id_regularidad = this.ddl48papasRegularidad.SelectedValue;
                string id_profundidad = this.ddl48papasProfundidad.SelectedValue;

                string id_calidad = this.ddl48papasCalidadPiel.SelectedValue;
                string id_verdes = this.ddl48papasTuberculosVerdes.SelectedValue;
                string id_tizon_follaje = this.ddl48papasTizonFollaje.SelectedValue;
                string id_tizon_tuberculo = this.ddl48papasTizonTuberculo.SelectedValue;
                string id_numero = this.ddl48papasNumero.SelectedValue;
                string id_ciudad = this.ddl48papasCiudadPlantacion.SelectedValue;

                string total_kg = this.txt48papasTotalKg.Text.Replace(",", ".");
                string tuberculos_planta = this.txt48papasTuberculosPlanta.Text.Replace(",", ".");                
                string consumo = this.txt48papasConsumo.Text;
                string semillon = this.txt48papasSemillon.Text;
                string semilla = this.txt48papasSemilla.Text;
                string semillita = this.txt48papasSemillita.Text;
                string bajo_calibre = this.txt48papasBajoCalibre.Text;
                string numero_tallos = this.txt48papasNumeroTallos.Text;

                string id_sensibildiad_quimica = this.ddl48papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl48papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt48papasDormancia.Text;
                string tolerancia_sequia = this.txt48papasToleranciaSequia.Text;
                string tolerancia_calor = this.txt48papasToleranciaCalor.Text;
                string tolerancia_sal = this.txt48papasToleranciaSal.Text;
                string daño_cosecha = this.txt48papasDañoCosecha.Text;
                string tizon_hoja = this.txt48papasTizonHoja.Text;
                string putrefaccion_suave = this.txt48papasPutrefaccionSuave.Text;
                string putrefaccion_rosa = this.txt48papasPutrefaccionRosa.Text;
                string silver_scurf = this.txt48papasSilverScurf.Text;
                string blackleg = this.txt48papasBlackleg.Text;

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

                int valor = cc.UpdateCosecha48papas(cosecha);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            PoblarGrilla();
        }

        protected void gdv48papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdv48papas.SelectedIndex;
            CatalogCosecha cc = new CatalogCosecha();
            //id_cosecha
            string id_cosechaString = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[2].Text);
            int id_cosecha = Int32.Parse(id_cosechaString);

            //Código Seleccionado
            string codigo = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[8].Text);
            this.txt48papasCodigoSeleccionado.Text = codigo;

            //Flor
            bool flor = cc.GetCosechaValoresBooleanos(id_cosecha, 0);
            this.chk48papasFlor.Checked = flor;

            //Cantidad Papas
            int cantidad_papas = cc.GetCosechaValoresEnteros(id_cosecha, 1);
            this.txt48papasCantidadPapas.Text = cantidad_papas.ToString();

            //Bayas
            bool bayas = cc.GetCosechaValoresBooleanos(id_cosecha, 2);
            this.chk48papasBayas.Checked = bayas;

            //Posicion 6papas
            string posicion = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[7].Text);
            this.txt48papasPosicion.Text = posicion;

            //Fertilidad
            int fertilidad = cc.GetCosechaValoresEnteros(id_cosecha, 3);
            this.ddl48papasFertilidad.SelectedValue = fertilidad.ToString();

            //Emergencia 40 días
            int emergencia_40 = cc.GetCosechaValoresEnteros(id_cosecha, 4);
            this.ddl48papasEmergencia40.SelectedValue = emergencia_40.ToString();

            //Metribuzina
            int metribuzina = cc.GetCosechaValoresEnteros(id_cosecha, 5);
            this.ddl48papasMetribuzina.SelectedValue = metribuzina.ToString();

            //Emergencia
            int emergencia = cc.GetCosechaValoresEnteros(id_cosecha, 6);
            this.ddl48papasEmergencia.SelectedValue = emergencia.ToString();

            //Madurez
            int madurez = cc.GetCosechaValoresEnteros(id_cosecha, 7);
            this.ddl48papasMadurez.SelectedValue = madurez.ToString();

            //Desarrollo Follaje
            int desarrollo_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 8);
            this.ddl48papasDesarrollo.SelectedValue = desarrollo_follaje.ToString();

            //Tipo Hoja
            int tipo_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 9);
            this.ddl48papasTipoHoja.SelectedValue = tipo_hoja.ToString();

            //Brotacion
            int brotacion = cc.GetCosechaValoresEnteros(id_cosecha, 10);
            this.ddl48papasBrotacion.SelectedValue = brotacion.ToString();

            //Tamaño
            int tamaño = cc.GetCosechaValoresEnteros(id_cosecha, 11);
            this.ddl48papasTamaño.SelectedValue = tamaño.ToString();

            //Distribucion calibre
            int distribucion = cc.GetCosechaValoresEnteros(id_cosecha, 12);
            this.ddl48papasDistribucion.SelectedValue = distribucion.ToString();

            //Forma
            int forma = cc.GetCosechaValoresEnteros(id_cosecha, 13);
            this.ddl48papasForma.SelectedValue = forma.ToString();

            //Regularidad
            int regularidad = cc.GetCosechaValoresEnteros(id_cosecha, 14);
            this.ddl48papasRegularidad.SelectedValue = regularidad.ToString();

            //Profundidad Ojo
            int profundidad = cc.GetCosechaValoresEnteros(id_cosecha, 15);
            this.ddl48papasProfundidad.SelectedValue = profundidad.ToString();

            //Calidad Piel
            int calidad = cc.GetCosechaValoresEnteros(id_cosecha, 16);
            this.ddl48papasCalidadPiel.SelectedValue = calidad.ToString();

            //Tuberculos Verdes
            int verdes = cc.GetCosechaValoresEnteros(id_cosecha, 17);
            this.ddl48papasTuberculosVerdes.SelectedValue = verdes.ToString();

            //Tizon Tardio Follaje
            int tizon_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 18);
            this.ddl48papasTizonFollaje.SelectedValue = tizon_follaje.ToString();

            //Tizon Tardio Tuberculo
            int tizon_tuberculo = cc.GetCosechaValoresEnteros(id_cosecha, 19);
            this.ddl48papasTizonTuberculo.SelectedValue = tizon_tuberculo.ToString();

            //Numero Tuberculos
            int numero = cc.GetCosechaValoresEnteros(id_cosecha, 20);
            this.ddl48papasNumero.SelectedValue = numero.ToString();

            //Ciudad
            int ciudad = cc.GetCosechaValoresEnteros(id_cosecha, 21);
            this.ddl48papasCiudadPlantacion.SelectedValue = ciudad.ToString();

            //Color Carne
            int carne = cc.GetCosechaValoresEnteros(id_cosecha, 22);
            this.lst48papasColorCarne.SelectedValue = carne.ToString();

            //Color Piel
            int piel = cc.GetCosechaValoresEnteros(id_cosecha, 23);
            this.lst48papasColorPiel.SelectedValue = piel.ToString();

            //Total Kilogramos
            double total_kg = cc.GetCosechaValoresDouble(id_cosecha, 24);
            this.txt48papasTotalKg.Text = total_kg.ToString();

            //Tuberculos/planta
            double tuberculos_planta = cc.GetCosechaValoresDouble(id_cosecha, 25);
            this.txt48papasTuberculosPlanta.Text = tuberculos_planta.ToString();

            //Consumo
            int consumo = cc.GetCosechaValoresEnteros(id_cosecha, 28);
            this.txt48papasConsumo.Text = consumo.ToString();

            //Semillon
            int semillon = cc.GetCosechaValoresEnteros(id_cosecha, 29);
            this.txt48papasSemillon.Text = semillon.ToString();

            //Semilla
            int semilla = cc.GetCosechaValoresEnteros(id_cosecha, 30);
            this.txt48papasSemilla.Text = semilla.ToString();

            //Semillita
            int semillita = cc.GetCosechaValoresEnteros(id_cosecha, 31);
            this.txt48papasSemillita.Text = semillita.ToString();

            //Bajo Calibre
            int bajo_calibre = cc.GetCosechaValoresEnteros(id_cosecha, 32);
            this.txt48papasBajoCalibre.Text = bajo_calibre.ToString();

            //Numero Tallos
            int numero_tallos = cc.GetCosechaValoresEnteros(id_cosecha, 33);
            this.txt48papasNumeroTallos.Text = numero_tallos.ToString();

            //Sensibilidad Quimica
            int sensibilidad_quimica = cc.GetCosechaValoresEnteros(id_cosecha, 34);
            this.ddl48papasSensibilidadQuimica.SelectedValue = sensibilidad_quimica.ToString();

            //Facilidad Muerte
            int facilidad_muerte = cc.GetCosechaValoresEnteros(id_cosecha, 35);
            this.ddl48papasFacilidadMuerte.SelectedValue = facilidad_muerte.ToString();

            //Dormancia
            int dormancia = cc.GetCosechaValoresEnteros(id_cosecha, 36);
            this.txt48papasDormancia.Text = dormancia.ToString();

            //Tolerancia Sequia
            int tolerancia_sequia = cc.GetCosechaValoresEnteros(id_cosecha, 37);
            this.txt48papasToleranciaSequia.Text = tolerancia_sequia.ToString();

            //Tolerancia Calor
            int tolerancia_calor = cc.GetCosechaValoresEnteros(id_cosecha, 38);
            this.txt48papasToleranciaCalor.Text = tolerancia_calor.ToString();

            //Tolerancia Sal
            int tolerancia_sal = cc.GetCosechaValoresEnteros(id_cosecha, 39);
            this.txt48papasToleranciaSal.Text = tolerancia_sal.ToString();

            //Daño Cosecha
            int daño_cosecha = cc.GetCosechaValoresEnteros(id_cosecha, 40);
            this.txt48papasDañoCosecha.Text = daño_cosecha.ToString();

            //Hematomas
            double hematomas = cc.GetCosechaValoresDouble(id_cosecha, 41);
            this.txt48papasHematomas.Text = hematomas.ToString();

            //Tizon Hoja
            int tizon_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 42);
            this.txt48papasTizonHoja.Text = tizon_hoja.ToString();

            //Putrefaccion Suave
            int putrefaccion_suave = cc.GetCosechaValoresEnteros(id_cosecha, 43);
            this.txt48papasPutrefaccionSuave.Text = putrefaccion_suave.ToString();

            //Putrefaccion Rosa
            int putrefaccion_rosa = cc.GetCosechaValoresEnteros(id_cosecha, 44);
            this.txt48papasPutrefaccionRosa.Text = putrefaccion_rosa.ToString();

            //Silver Scurf
            int silver_scurf = cc.GetCosechaValoresEnteros(id_cosecha, 45);
            this.txt48papasSilverScurf.Text = silver_scurf.ToString();

            //Blackleg
            int blackleg = cc.GetCosechaValoresEnteros(id_cosecha, 46);
            this.txt48papasBlackleg.Text = blackleg.ToString();

            List<Cosecha> tablaRendimiento = new List<Cosecha>();
            tablaRendimiento = cc.GetTablaRendimiento48papas(id_cosecha);
            this.gdv48papasRendimiento.DataSource = tablaRendimiento;
            this.gdv48papasRendimiento.DataBind();
        }

        protected void btn48papasAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            string id_enfermedad = this.ddl48papasEnfermedad.SelectedValue;
            if (!id_enfermedad.Equals("1"))
            {
                if (this.gdv48papasEnfermedades.Rows.Count == 0)
                {
                    table.Rows.Add(this.ddl48papasEnfermedad.SelectedItem, this.ddl48papasResistencia.SelectedItem);
                    this.gdv48papasEnfermedades.DataSource = table;
                }
                else
                {
                    listEnfermedad = new List<string>();
                    listResistencia = new List<string>();
                    foreach (GridViewRow row in gdv48papasEnfermedades.Rows)
                    {
                        string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                        listEnfermedad.Add(nombre_enfermedad);
                        string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                        listResistencia.Add(resistencia_variedad);
                    }
                    listEnfermedad.Add(this.ddl48papasEnfermedad.SelectedItem.ToString());
                    listResistencia.Add(this.ddl48papasResistencia.SelectedItem.ToString());

                    for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                    {
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                    }
                    this.gdv48papasEnfermedades.DataSource = table;
                }
                this.gdv48papasEnfermedades.DataBind();
            }
            else
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una enfermedad!')</script>");
        }

        protected void Cosecha48papasEnfermedadesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                listEnfermedad = new List<string>();
                listResistencia = new List<string>();
                foreach (GridViewRow row in gdv48papasEnfermedades.Rows)
                {
                    string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                    listEnfermedad.Add(nombre_enfermedad);
                    string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                    listResistencia.Add(resistencia_variedad);
                }

                for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                {
                    if (i != e.RowIndex)
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                }
                this.gdv48papasEnfermedades.DataSource = table;
                this.gdv48papasEnfermedades.DataBind();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error!\n'" + ex.ToString() + "'')</script>");
            }
        }

        protected void btnAgregarUPOV_Click(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdv48papas.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAgregarUPOV = (row.Cells[0].FindControl("chkAgregarUPOV") as CheckBox);
                    if (chkAgregarUPOV != null)
                        if (chkAgregarUPOV.Checked)
                        {
                            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[row.RowIndex].Cells[2].Text);
                            CatalogUPOV cu = new CatalogUPOV();
                            int existe_upov = cu.AddUPOV(Int32.Parse(id_cosecha));
                            if (existe_upov == 1)
                                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La varieadd con ID: " + id_cosecha + " seleccionada ya generó el informe UPOV o no tiene una ciudad asignada')</script>");
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