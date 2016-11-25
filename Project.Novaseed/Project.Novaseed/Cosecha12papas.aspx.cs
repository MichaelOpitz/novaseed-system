﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Data;
using System.Drawing;
using System.Globalization;

namespace Project.Novaseed
{
    public partial class Cosecha12papas : System.Web.UI.Page
    {
        private int cont12papas24papas, valorAñoInt32;
        private string valorAñoString;
        private DataTable table;
        private List<string> listEnfermedad, listResistencia;

        protected void Page_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("nombre_enfermedad", typeof(string));
            table.Columns.Add("resistencia_variedad", typeof(string));            

            cont12papas24papas = 0;

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
                this.ddl12papasFertilidad.DataValueField = "id_fertilidad";
                this.ddl12papasFertilidad.DataTextField = "nombre_fertilidad";
                this.ddl12papasFertilidad.DataSource = fertilidad;

                this.ddl12papasEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddl12papasEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddl12papasEmergencia40.DataSource = emergencia40;
                this.ddl12papasMetribuzina.DataValueField = "id_metribuzina";
                this.ddl12papasMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddl12papasMetribuzina.DataSource = metribuzina;
                this.ddl12papasEmergencia.DataValueField = "id_emergencia";
                this.ddl12papasEmergencia.DataTextField = "nombre_emergencia";
                this.ddl12papasEmergencia.DataSource = emergencia;

                this.ddl12papasMadurez.DataValueField = "id_madurez";
                this.ddl12papasMadurez.DataTextField = "nombre_madurez";
                this.ddl12papasMadurez.DataSource = madurez;
                this.ddl12papasDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddl12papasDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddl12papasDesarrollo.DataSource = desarrollo;
                this.ddl12papasTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddl12papasTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddl12papasTipoHoja.DataSource = hoja;
                this.ddl12papasBrotacion.DataValueField = "id_brotacion";
                this.ddl12papasBrotacion.DataTextField = "nombre_brotacion";
                this.ddl12papasBrotacion.DataSource = brotacion;

                this.ddl12papasTamaño.DataValueField = "id_tamaño";
                this.ddl12papasTamaño.DataTextField = "nombre_tamaño";
                this.ddl12papasTamaño.DataSource = tamaño;
                this.ddl12papasDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddl12papasDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddl12papasDistribucion.DataSource = distribucion;
                this.ddl12papasForma.DataValueField = "id_forma";
                this.ddl12papasForma.DataTextField = "nombre_forma";
                this.ddl12papasForma.DataSource = forma;
                this.ddl12papasRegularidad.DataValueField = "id_regularidad";
                this.ddl12papasRegularidad.DataTextField = "nombre_regularidad";
                this.ddl12papasRegularidad.DataSource = regularidad;
                this.ddl12papasProfundidad.DataValueField = "id_profundidad";
                this.ddl12papasProfundidad.DataTextField = "profundidad_ojo";
                this.ddl12papasProfundidad.DataSource = profundidad;
                this.ddl12papasCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddl12papasCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddl12papasCalidadPiel.DataSource = calidad;
                this.ddl12papasTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddl12papasTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddl12papasTuberculosVerdes.DataSource = verdes;
                this.ddl12papasTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddl12papasTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddl12papasTizonFollaje.DataSource = tizon_follaje;
                this.ddl12papasTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddl12papasTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddl12papasTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddl12papasNumero.DataValueField = "id_numero_tuberculos";
                this.ddl12papasNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddl12papasNumero.DataSource = numero;
                this.ddl12papasCiudadPlantacion.DataValueField = "id_ciudad";
                this.ddl12papasCiudadPlantacion.DataTextField = "nombre_ciudad";
                this.ddl12papasCiudadPlantacion.DataSource = city;

                this.lst12papasColorCarne.DataValueField = "id_color_carne";
                this.lst12papasColorCarne.DataTextField = "nombre_color_carne";
                this.lst12papasColorCarne.DataSource = carne;
                this.lst12papasColorPiel.DataValueField = "id_color_piel";
                this.lst12papasColorPiel.DataTextField = "nombre_color_piel";
                this.lst12papasColorPiel.DataSource = piel;

                this.ddl12papasEnfermedad.DataValueField = "id_enfermedad";
                this.ddl12papasEnfermedad.DataTextField = "nombre_enfermedad";
                this.ddl12papasEnfermedad.DataSource = enfermedad;
                this.ddl12papasResistencia.DataValueField = "id_resistencia_variedad";
                this.ddl12papasResistencia.DataTextField = "nombre_resistencia_variedad";
                this.ddl12papasResistencia.DataSource = resistencia;

                this.ddl12papasSensibilidadQuimica.DataValueField = "id_sensibilidad_quimica";
                this.ddl12papasSensibilidadQuimica.DataTextField = "nombre_sensibilidad_quimica";
                this.ddl12papasSensibilidadQuimica.DataSource = sensibilidad;
                this.ddl12papasFacilidadMuerte.DataValueField = "id_facilidad_muerte";
                this.ddl12papasFacilidadMuerte.DataTextField = "nombre_facilidad_muerte";
                this.ddl12papasFacilidadMuerte.DataSource = facilidad;

                this.lbl12papasAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogCosecha cc12p = new CatalogCosecha();
                this.gdv12papas.DataSource = cc12p.GetTablaCosecha(valorAñoInt32, 2);
                this.DataBind();
            }
        }

        /*
        * Llena la grilla de la temporada 12papas con el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCosecha cc12p = new CatalogCosecha();
            this.gdv12papas.DataSource = cc12p.GetTablaCosecha(valorAñoInt32, 2);
            this.gdv12papas.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW 12PAPAS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //el tercer parametro es 3 por el id_temporada que es 24 papas(3 para el color, 2 para el obtener en catalog)
                int index6papas12papas = cc.GetCosechaTemporadasAvanzadas(valorAñoInt32, cont12papas24papas, 3);

                if (index6papas12papas == 1)
                    e.Row.BackColor = Color.LightGreen;
                else
                    e.Row.BackColor = Color.FromArgb(255, 204, 203);
                cont12papas24papas = cont12papas24papas + 1;
            }
        }

        protected void Cosecha12papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[e.RowIndex].Cells[2].Text);
            int valor = cc.DeleteCosecha12papas(Int32.Parse(id_cosecha));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la variedad!')</script>");

            PoblarGrilla();
        }        

        protected void btnAgregar24papas_Click(object sender, EventArgs e)
        {

        }

        protected void btn12papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn12papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdv12papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[selected].Cells[2].Text);
                string cantidad_papas = this.txt12papasCantidadPapas.Text;
                string posicion_cosecha = this.txt12papasPosicion.Text.Replace(",", ".");
                bool flor_cosecha = false;
                if (this.chk12papasFlor.Checked == true)
                    flor_cosecha = true;
                else
                    flor_cosecha = false;
                bool bayas_cosecha = false;
                if (this.chk12papasBayas.Checked == true)
                    bayas_cosecha = true;
                else
                    bayas_cosecha = false;
                string id_fertilidad = this.ddl12papasFertilidad.SelectedValue;
                string id_emergencia40 = this.ddl12papasEmergencia40.SelectedValue;
                string id_metribuzina = this.ddl12papasMetribuzina.SelectedValue;
                string id_emergencia = this.ddl12papasEmergencia.SelectedValue;

                string id_madurez = this.ddl12papasMadurez.SelectedValue;
                string id_desarrollo = this.ddl12papasDesarrollo.SelectedValue;
                string id_tipo_hoja = this.ddl12papasTipoHoja.SelectedValue;
                string id_brotacion = this.ddl12papasBrotacion.SelectedValue;
                string id_tamaño = this.ddl12papasTamaño.SelectedValue;
                string id_distribucion = this.ddl12papasDistribucion.SelectedValue;
                string id_forma = this.ddl12papasForma.SelectedValue;
                string id_regularidad = this.ddl12papasRegularidad.SelectedValue;
                string id_profundidad = this.ddl12papasProfundidad.SelectedValue;

                string id_calidad = this.ddl12papasCalidadPiel.SelectedValue;
                string id_verdes = this.ddl12papasTuberculosVerdes.SelectedValue;
                string id_tizon_follaje = this.ddl12papasTizonFollaje.SelectedValue;
                string id_tizon_tuberculo = this.ddl12papasTizonTuberculo.SelectedValue;
                string id_numero = this.ddl12papasNumero.SelectedValue;
                string id_ciudad = this.ddl12papasCiudadPlantacion.SelectedValue;

                string total_kg = this.txt12papasTotalKg.Text.Replace(",", ".");
                string tuberculos_planta = this.txt12papasTuberculosPlanta.Text.Replace(",", ".");
                string consumo = this.txt12papasConsumo.Text;
                string semillon = this.txt12papasSemillon.Text;
                string semilla = this.txt12papasSemilla.Text;
                string semillita = this.txt12papasSemillita.Text;
                string bajo_calibre = this.txt12papasBajoCalibre.Text;
                string numero_tallos = this.txt12papasNumeroTallos.Text;

                string id_sensibildiad_quimica = this.ddl12papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl12papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt12papasDormancia.Text;
                string tolerancia_sequia = this.txt12papasToleranciaSequia.Text;
                string tolerancia_calor = this.txt12papasToleranciaCalor.Text;
                string tolerancia_sal = this.txt12papasToleranciaSal.Text;
                string daño_cosecha = this.txt12papasDañoCosecha.Text;
                string tizon_hoja = this.txt12papasTizonHoja.Text;
                string putrefaccion_suave = this.txt12papasPutrefaccionSuave.Text;
                string putrefaccion_rosa = this.txt12papasPutrefaccionRosa.Text;
                string silver_scurf = this.txt12papasSilverScurf.Text;
                string blackleg = this.txt12papasBlackleg.Text;

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

                int valor = cc.UpdateCosecha12papas(cosecha);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
            PoblarGrilla();
        }

        protected void gdv12papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdv12papas.SelectedIndex;
            CatalogCosecha cc = new CatalogCosecha();
            //id_cosecha
            string id_cosechaString = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[selected].Cells[2].Text);
            int id_cosecha = Int32.Parse(id_cosechaString);

            //Código Seleccionado
            string codigo = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[selected].Cells[8].Text);
            this.txt12papasCodigoSeleccionado.Text = codigo;

            //Flor
            bool flor = cc.GetCosechaValoresBooleanos(id_cosecha, 0);
            this.chk12papasFlor.Checked = flor;

            //Cantidad Papas
            int cantidad_papas = cc.GetCosechaValoresEnteros(id_cosecha, 1);
            this.txt12papasCantidadPapas.Text = cantidad_papas.ToString();

            //Bayas
            bool bayas = cc.GetCosechaValoresBooleanos(id_cosecha, 2);
            this.chk12papasBayas.Checked = bayas;

            //Posicion 6papas
            string posicion = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[selected].Cells[7].Text);
            this.txt12papasPosicion.Text = posicion;

            //Fertilidad
            int fertilidad = cc.GetCosechaValoresEnteros(id_cosecha, 3);
            this.ddl12papasFertilidad.SelectedValue = fertilidad.ToString();

            //Emergencia 40 días
            int emergencia_40 = cc.GetCosechaValoresEnteros(id_cosecha, 4);
            this.ddl12papasEmergencia40.SelectedValue = emergencia_40.ToString();

            //Metribuzina
            int metribuzina = cc.GetCosechaValoresEnteros(id_cosecha, 5);
            this.ddl12papasMetribuzina.SelectedValue = metribuzina.ToString();

            //Emergencia
            int emergencia = cc.GetCosechaValoresEnteros(id_cosecha, 6);
            this.ddl12papasEmergencia.SelectedValue = emergencia.ToString();

            //Madurez
            int madurez = cc.GetCosechaValoresEnteros(id_cosecha, 7);
            this.ddl12papasMadurez.SelectedValue = madurez.ToString();

            //Desarrollo Follaje
            int desarrollo_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 8);
            this.ddl12papasDesarrollo.SelectedValue = desarrollo_follaje.ToString();

            //Tipo Hoja
            int tipo_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 9);
            this.ddl12papasTipoHoja.SelectedValue = tipo_hoja.ToString();

            //Brotacion
            int brotacion = cc.GetCosechaValoresEnteros(id_cosecha, 10);
            this.ddl12papasBrotacion.SelectedValue = brotacion.ToString();

            //Tamaño
            int tamaño = cc.GetCosechaValoresEnteros(id_cosecha, 11);
            this.ddl12papasTamaño.SelectedValue = tamaño.ToString();

            //Distribucion calibre
            int distribucion = cc.GetCosechaValoresEnteros(id_cosecha, 12);
            this.ddl12papasDistribucion.SelectedValue = distribucion.ToString();

            //Forma
            int forma = cc.GetCosechaValoresEnteros(id_cosecha, 13);
            this.ddl12papasForma.SelectedValue = forma.ToString();

            //Regularidad
            int regularidad = cc.GetCosechaValoresEnteros(id_cosecha, 14);
            this.ddl12papasRegularidad.SelectedValue = regularidad.ToString();

            //Profundidad Ojo
            int profundidad = cc.GetCosechaValoresEnteros(id_cosecha, 15);
            this.ddl12papasProfundidad.SelectedValue = profundidad.ToString();

            //Calidad Piel
            int calidad = cc.GetCosechaValoresEnteros(id_cosecha, 16);
            this.ddl12papasCalidadPiel.SelectedValue = calidad.ToString();

            //Tuberculos Verdes
            int verdes = cc.GetCosechaValoresEnteros(id_cosecha, 17);
            this.ddl12papasTuberculosVerdes.SelectedValue = verdes.ToString();

            //Tizon Tardio Follaje
            int tizon_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 18);
            this.ddl12papasTizonFollaje.SelectedValue = tizon_follaje.ToString();

            //Tizon Tardio Tuberculo
            int tizon_tuberculo = cc.GetCosechaValoresEnteros(id_cosecha, 19);
            this.ddl12papasTizonTuberculo.SelectedValue = tizon_tuberculo.ToString();

            //Numero Tuberculos
            int numero = cc.GetCosechaValoresEnteros(id_cosecha, 20);
            this.ddl12papasNumero.SelectedValue = numero.ToString();

            //Ciudad
            int ciudad = cc.GetCosechaValoresEnteros(id_cosecha, 21);
            this.ddl12papasCiudadPlantacion.SelectedValue = ciudad.ToString();

            //Color Carne
            int carne = cc.GetCosechaValoresEnteros(id_cosecha, 22);
            this.lst12papasColorCarne.SelectedValue = carne.ToString();

            //Color Piel
            int piel = cc.GetCosechaValoresEnteros(id_cosecha, 23);
            this.lst12papasColorPiel.SelectedValue = piel.ToString();

            //Total Kilogramos
            double total_kg = cc.GetCosechaValoresDouble(id_cosecha, 24);
            this.txt12papasTotalKg.Text = total_kg.ToString();

            //Tuberculos/planta
            double tuberculos_planta = cc.GetCosechaValoresDouble(id_cosecha, 25);
            this.txt12papasTuberculosPlanta.Text = tuberculos_planta.ToString();

            //Toneladas/hectarea
            double toneladas_hectarea = cc.GetCosechaValoresDouble(id_cosecha, 26);
            this.txt12papasToneladasHectarea.Text = toneladas_hectarea.ToString();

            // % Relacion Standard
            int porcentaje_relacion = cc.GetCosechaValoresEnteros(id_cosecha, 27);
            this.txt12papasRelacionStandard.Text = porcentaje_relacion.ToString() + "%";

            //Consumo
            int consumo = cc.GetCosechaValoresEnteros(id_cosecha, 28);
            this.txt12papasConsumo.Text = consumo.ToString();

            //Semillon
            int semillon = cc.GetCosechaValoresEnteros(id_cosecha, 29);
            this.txt12papasSemillon.Text = semillon.ToString();

            //Semilla
            int semilla = cc.GetCosechaValoresEnteros(id_cosecha, 30);
            this.txt12papasSemilla.Text = semilla.ToString();

            //Semillita
            int semillita = cc.GetCosechaValoresEnteros(id_cosecha, 31);
            this.txt12papasSemillita.Text = semillita.ToString();

            //Bajo Calibre
            int bajo_calibre = cc.GetCosechaValoresEnteros(id_cosecha, 32);
            this.txt12papasBajoCalibre.Text = bajo_calibre.ToString();

            //Numero Tallos
            int numero_tallos = cc.GetCosechaValoresEnteros(id_cosecha, 33);
            this.txt12papasNumeroTallos.Text = numero_tallos.ToString();

            //Sensibilidad Quimica
            int sensibilidad_quimica = cc.GetCosechaValoresEnteros(id_cosecha, 34);
            this.ddl12papasSensibilidadQuimica.SelectedValue = sensibilidad_quimica.ToString();

            //Facilidad Muerte
            int facilidad_muerte = cc.GetCosechaValoresEnteros(id_cosecha, 35);
            this.ddl12papasFacilidadMuerte.SelectedValue = facilidad_muerte.ToString();

            //Dormancia
            int dormancia = cc.GetCosechaValoresEnteros(id_cosecha, 36);
            this.txt12papasDormancia.Text = dormancia.ToString();

            //Tolerancia Sequia
            int tolerancia_sequia = cc.GetCosechaValoresEnteros(id_cosecha, 37);
            this.txt12papasToleranciaSequia.Text = tolerancia_sequia.ToString();

            //Tolerancia Calor
            int tolerancia_calor = cc.GetCosechaValoresEnteros(id_cosecha, 38);
            this.txt12papasToleranciaCalor.Text = tolerancia_calor.ToString();

            //Tolerancia Sal
            int tolerancia_sal = cc.GetCosechaValoresEnteros(id_cosecha, 39);
            this.txt12papasToleranciaSal.Text = tolerancia_sal.ToString();

            //Daño Cosecha
            int daño_cosecha = cc.GetCosechaValoresEnteros(id_cosecha, 40);
            this.txt12papasDañoCosecha.Text = daño_cosecha.ToString();

            //Hematomas
            double hematomas = cc.GetCosechaValoresDouble(id_cosecha, 41);
            this.txt12papasHematomas.Text = hematomas.ToString();

            //Tizon Hoja
            int tizon_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 42);
            this.txt12papasTizonHoja.Text = tizon_hoja.ToString();

            //Putrefaccion Suave
            int putrefaccion_suave = cc.GetCosechaValoresEnteros(id_cosecha, 43);
            this.txt12papasPutrefaccionSuave.Text = putrefaccion_suave.ToString();

            //Putrefaccion Rosa
            int putrefaccion_rosa = cc.GetCosechaValoresEnteros(id_cosecha, 44);
            this.txt12papasPutrefaccionRosa.Text = putrefaccion_rosa.ToString();

            //Silver Scurf
            int silver_scurf = cc.GetCosechaValoresEnteros(id_cosecha, 45);
            this.txt12papasSilverScurf.Text = silver_scurf.ToString();

            //Blackleg
            int blackleg = cc.GetCosechaValoresEnteros(id_cosecha, 46);
            this.txt12papasBlackleg.Text = blackleg.ToString();
        }        

        protected void btn12papasAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            string id_enfermedad = this.ddl12papasEnfermedad.SelectedValue;
            if (!id_enfermedad.Equals("1"))
            {
                if (this.gdv12papasEnfermedades.Rows.Count == 0)
                {
                    table.Rows.Add(this.ddl12papasEnfermedad.SelectedItem, this.ddl12papasResistencia.SelectedItem);
                    this.gdv12papasEnfermedades.DataSource = table;
                }
                else
                {
                    listEnfermedad = new List<string>();
                    listResistencia = new List<string>();
                    foreach (GridViewRow row in gdv12papasEnfermedades.Rows)
                    {
                        string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                        listEnfermedad.Add(nombre_enfermedad);
                        string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                        listResistencia.Add(resistencia_variedad);
                    }
                    listEnfermedad.Add(this.ddl12papasEnfermedad.SelectedItem.ToString());
                    listResistencia.Add(this.ddl12papasResistencia.SelectedItem.ToString());

                    for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                    {
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                    }
                    this.gdv12papasEnfermedades.DataSource = table;
                }
                this.gdv12papasEnfermedades.DataBind();
            }
            else
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una enfermedad!')</script>");
        }

        protected void Cosecha12papasEnfermedadesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                listEnfermedad = new List<string>();
                listResistencia = new List<string>();
                foreach (GridViewRow row in gdv12papasEnfermedades.Rows)
                {
                    string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                    listEnfermedad.Add(nombre_enfermedad);
                    string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                    listResistencia.Add(resistencia_variedad);
                }

                for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                {
                    if (i != e.RowIndex)
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                }
                this.gdv12papasEnfermedades.DataSource = table;
                this.gdv12papasEnfermedades.DataBind();
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error!\n'" + ex.ToString() + "'')</script>");
            }
        }

        protected void btnAgregar24papas_Click1(object sender, EventArgs e)
        {
            int agrego = 0;
            foreach (GridViewRow row in gdv12papas.Rows)
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAgregar24Papas = (row.Cells[0].FindControl("chkAgregar24Papas") as CheckBox);
                    if (chkAgregar24Papas != null)
                        if (chkAgregar24Papas.Checked)
                        {
                            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[row.RowIndex].Cells[2].Text);
                            CatalogCosecha cc = new CatalogCosecha();
                            int existe_24papas = cc.AddCosecha24papas(Int32.Parse(id_cosecha));
                            if (existe_24papas == 1)
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