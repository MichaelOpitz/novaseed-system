using System;
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

            this.lbl12papasError.Visible = false;
            this.lbl12papasError.Text = "";
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
         * Verifica si es un entero
         */
        public bool EsNumero(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
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
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //el tercer parametro es 3 por el id_temporada que es 24 papas(3 para el color, 2 para el obtener en catalog)
                    int index6papas12papas = cc.GetCosechaTemporadasAvanzadas(valorAñoInt32, cont12papas24papas, 3);
                    //Ecuentra el CheckBox en la fila
                    CheckBox chkAgregar24Papas = (e.Row.FindControl("chkAgregar24Papas") as CheckBox);
                    if (index6papas12papas == 1)
                    {
                        e.Row.BackColor = Color.LightGreen;
                        chkAgregar24Papas.Enabled = false;
                    }
                    else
                    {
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                        chkAgregar24Papas.Enabled = true;
                    }
                    cont12papas24papas = cont12papas24papas + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha12papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[e.RowIndex].Cells[2].Text);
                int valor = cc.DeleteCosecha12papas(Int32.Parse(id_cosecha));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar la variedad')</script>");

                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn12papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn12papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl12papasError.Visible = true;
                int invalido = 0;
                int selected = this.gdv12papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv12papas.Rows[selected].Cells[2].Text);
                int id_cosechaEntero = Int32.Parse(id_cosecha);
                string cantidad_papas = this.txt12papasCantidadPapas.Text;
                if ((EsNumero(cantidad_papas) == true && (Int32.Parse(cantidad_papas) < 0 || Int32.Parse(cantidad_papas) > 12)) || (EsNumero(cantidad_papas) == false))
                    invalido = 1;
                string posicion_cosecha = this.txt12papasPosicion.Text.Replace(",", ".");
                try
                {
                    double posicion_cosechaDouble = double.Parse(posicion_cosecha, System.Globalization.CultureInfo.InvariantCulture);
                    if (posicion_cosechaDouble < 0 || posicion_cosechaDouble > 99.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

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
                try
                {
                    double total_kgDouble = double.Parse(total_kg, System.Globalization.CultureInfo.InvariantCulture);
                    if (total_kgDouble < 0 || total_kgDouble > 99999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string tuberculos_planta = this.txt12papasTuberculosPlanta.Text.Replace(",", ".");
                try
                {
                    double tuberculos_plantaDouble = double.Parse(tuberculos_planta, System.Globalization.CultureInfo.InvariantCulture);
                    if (tuberculos_plantaDouble < 0 || tuberculos_plantaDouble > 999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string toneladas_hectarea = this.txt12papasToneladasHectarea.Text.Replace(",", ".");
                try
                {
                    double toneladas_hectareaDouble = double.Parse(toneladas_hectarea, System.Globalization.CultureInfo.InvariantCulture);
                    if (toneladas_hectareaDouble < 0 || toneladas_hectareaDouble > 9999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string porcentaje_relacion = this.txt12papasRelacionStandard.Text.Replace("%", "");
                if ((EsNumero(porcentaje_relacion) == true && (Int32.Parse(porcentaje_relacion) < 0 || Int32.Parse(porcentaje_relacion) > 999)) || (EsNumero(porcentaje_relacion) == false))
                    invalido = 1;
                string consumo = this.txt12papasConsumo.Text;
                if ((EsNumero(consumo) == true && (Int32.Parse(consumo) < 0 || Int32.Parse(consumo) > 99)) || (EsNumero(consumo) == false))
                    invalido = 1;
                string semillon = this.txt12papasSemillon.Text;
                if ((EsNumero(semillon) == true && (Int32.Parse(semillon) < 0 || Int32.Parse(semillon) > 99)) || (EsNumero(semillon) == false))
                    invalido = 1;
                string semilla = this.txt12papasSemilla.Text;
                if ((EsNumero(semilla) == true && (Int32.Parse(semilla) < 0 || Int32.Parse(semilla) > 99)) || (EsNumero(semilla) == false))
                    invalido = 1;
                string semillita = this.txt12papasSemillita.Text;
                if ((EsNumero(semillita) == true && (Int32.Parse(semillita) < 0 || Int32.Parse(semillita) > 99)) || (EsNumero(semillita) == false))
                    invalido = 1;
                string bajo_calibre = this.txt12papasBajoCalibre.Text;
                if ((EsNumero(bajo_calibre) == true && (Int32.Parse(bajo_calibre) < 0 || Int32.Parse(bajo_calibre) > 99)) || (EsNumero(bajo_calibre) == false))
                    invalido = 1;
                string numero_tallos = this.txt12papasNumeroTallos.Text;
                if ((EsNumero(numero_tallos) == true && (Int32.Parse(numero_tallos) < 0 || Int32.Parse(numero_tallos) > 99)) || (EsNumero(numero_tallos) == false))
                    invalido = 1;

                string id_sensibildiad_quimica = this.ddl12papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl12papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt12papasDormancia.Text;
                if ((EsNumero(dormancia) == true && (Int32.Parse(dormancia) < 0 || Int32.Parse(dormancia) > 99)) || (EsNumero(dormancia) == false))
                    invalido = 1;
                string tolerancia_sequia = this.txt12papasToleranciaSequia.Text;
                if ((EsNumero(tolerancia_sequia) == true && (Int32.Parse(tolerancia_sequia) < 0 || Int32.Parse(tolerancia_sequia) > 99)) || (EsNumero(tolerancia_sequia) == false))
                    invalido = 1;
                string tolerancia_calor = this.txt12papasToleranciaCalor.Text;
                if ((EsNumero(tolerancia_calor) == true && (Int32.Parse(tolerancia_calor) < 0 || Int32.Parse(tolerancia_calor) > 99)) || (EsNumero(tolerancia_calor) == false))
                    invalido = 1;
                string tolerancia_sal = this.txt12papasToleranciaSal.Text;
                if ((EsNumero(tolerancia_sal) == true && (Int32.Parse(tolerancia_sal) < 0 || Int32.Parse(tolerancia_sal) > 99)) || (EsNumero(tolerancia_sal) == false))
                    invalido = 1;
                string daño_cosecha = this.txt12papasDañoCosecha.Text;
                if ((EsNumero(daño_cosecha) == true && (Int32.Parse(daño_cosecha) < 0 || Int32.Parse(daño_cosecha) > 99)) || (EsNumero(daño_cosecha) == false))
                    invalido = 1;
                string tizon_hoja = this.txt12papasTizonHoja.Text;
                if ((EsNumero(tizon_hoja) == true && (Int32.Parse(tizon_hoja) < 0 || Int32.Parse(tizon_hoja) > 99)) || (EsNumero(tizon_hoja) == false))
                    invalido = 1;
                string putrefaccion_suave = this.txt12papasPutrefaccionSuave.Text;
                if ((EsNumero(putrefaccion_suave) == true && (Int32.Parse(putrefaccion_suave) < 0 || Int32.Parse(putrefaccion_suave) > 99)) || (EsNumero(putrefaccion_suave) == false))
                    invalido = 1;
                string putrefaccion_rosa = this.txt12papasPutrefaccionRosa.Text;
                if ((EsNumero(putrefaccion_rosa) == true && (Int32.Parse(putrefaccion_rosa) < 0 || Int32.Parse(putrefaccion_rosa) > 99)) || (EsNumero(putrefaccion_rosa) == false))
                    invalido = 1;
                string silver_scurf = this.txt12papasSilverScurf.Text;
                if ((EsNumero(silver_scurf) == true && (Int32.Parse(silver_scurf) < 0 || Int32.Parse(silver_scurf) > 99)) || (EsNumero(silver_scurf) == false))
                    invalido = 1;
                string blackleg = this.txt12papasBlackleg.Text;
                if ((EsNumero(blackleg) == true && (Int32.Parse(blackleg) < 0 || Int32.Parse(blackleg) > 99)) || (EsNumero(blackleg) == false))
                    invalido = 1;

                if (invalido == 0)
                {
                    CatalogCosecha cc = new CatalogCosecha();
                    Cosecha cosecha = new Cosecha(id_cosechaEntero, Int32.Parse(cantidad_papas), Double.Parse(posicion_cosecha, CultureInfo.InvariantCulture),
                        flor_cosecha, bayas_cosecha, Int32.Parse(id_fertilidad), Int32.Parse(id_emergencia40), Int32.Parse(id_metribuzina),
                        Int32.Parse(id_emergencia), Int32.Parse(id_madurez), Int32.Parse(id_desarrollo), Int32.Parse(id_tipo_hoja),
                        Int32.Parse(id_brotacion), Int32.Parse(id_tamaño), Int32.Parse(id_distribucion), Int32.Parse(id_forma),
                        Int32.Parse(id_regularidad), Int32.Parse(id_profundidad), Int32.Parse(id_calidad), Int32.Parse(id_verdes),
                        Int32.Parse(id_tizon_follaje), Int32.Parse(id_tizon_tuberculo), Int32.Parse(id_numero), Int32.Parse(id_ciudad),
                        Double.Parse(total_kg, CultureInfo.InvariantCulture), Double.Parse(tuberculos_planta, CultureInfo.InvariantCulture),
                        Double.Parse(toneladas_hectarea, CultureInfo.InvariantCulture), Int32.Parse(porcentaje_relacion),
                        Int32.Parse(consumo), Int32.Parse(semillon), Int32.Parse(semilla), Int32.Parse(semillita),
                        Int32.Parse(bajo_calibre), Int32.Parse(numero_tallos), Int32.Parse(id_sensibildiad_quimica),
                        Int32.Parse(id_facilidad_muerte), Int32.Parse(dormancia), Int32.Parse(tolerancia_sequia),
                        Int32.Parse(tolerancia_calor), Int32.Parse(tolerancia_sal), Int32.Parse(daño_cosecha),
                        Int32.Parse(tizon_hoja), Int32.Parse(putrefaccion_suave), Int32.Parse(putrefaccion_rosa),
                        Int32.Parse(silver_scurf), Int32.Parse(blackleg));

                    //Modifica Color Carne
                    List<int> selectedCarne = this.lst12papasColorCarne.GetSelectedIndices().ToList();
                    if ((selectedCarne.Count > 1 && !selectedCarne[0].Equals(0)) || (selectedCarne.Count == 1))
                    {
                        cc.DeleteCosechaColorCarne(id_cosechaEntero);
                        for (int i = 0; i < selectedCarne.Count; i++)
                        {
                            string id_color_carne = this.lst12papasColorCarne.Items[selectedCarne[i]].Value;
                            cc.UpdateCosechaColorCarne(Int32.Parse(id_color_carne), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl12papasError.Text += "No puede seleccionar sin información y colores de la carne a la vez.<br/>";

                    //Modifica Color Piel
                    List<int> selectedPiel = this.lst12papasColorPiel.GetSelectedIndices().ToList();
                    if ((selectedPiel.Count > 1 && !selectedPiel[0].Equals(0)) || (selectedPiel.Count == 1))
                    {
                        cc.DeleteCosechaColorPiel(id_cosechaEntero);
                        for (int i = 0; i < selectedPiel.Count; i++)
                        {
                            string id_color_piel = this.lst12papasColorPiel.Items[selectedPiel[i]].Value;
                            cc.UpdateCosechaColorPiel(Int32.Parse(id_color_piel), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl12papasError.Text += "No puede seleccionar sin información y colores de la piel a la vez.<br/>";

                    //Modifica Enfermedades
                    cc.DeleteCosechaEnfermedades(id_cosechaEntero);
                    foreach (GridViewRow row in gdv12papasEnfermedades.Rows)
                    {
                        string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                        string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv12papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                        int valorEnfermedad = cc.AddCosechaEnfermedades(nombre_enfermedad, id_cosechaEntero, resistencia_variedad);
                        if (valorEnfermedad == 0)
                            this.lbl12papasError.Text += "Error al ingresar enfermedad.<br/>";
                    }

                    //Modifica Cosecha 12 papas
                    int valor = cc.UpdateCosecha12papas(cosecha);
                    if (valor == 0)
                    {
                        this.lbl12papasError.Text += "Debe seleccionar una ciudad para la variedad o la posición indicada ya existe.<br/>";
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
                    }
                }
                else
                {
                    this.lbl12papasError.Text += "Error al modificar, Revise los parámetros indicados y modifiquelos.<br/>";
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Datos incorrectos! Revise los parámetros indicados y modifique su valor')</script>");
                }
            }
            catch (Exception ex)
            {
                this.lbl12papasError.Text += "ERROR CRÍTICO, NO SE HA PODIDO MODIFICAR LA VARIEDAD, ARREGLE LOS PARÁMETROS E INTENTELO NUEVAMENTE.<br/>";
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar! No se ha podido actualizar la variedad')</script>");
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
            this.lst12papasColorCarne.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorCarne = cc.GetCosechaColorCarne(id_cosecha);
            foreach (ListItem item in this.lst12papasColorCarne.Items)
                for (int i = 0; i < colorCarne.Count; i++)
                    if (item.Value == colorCarne[i].Id_color.ToString())
                        item.Selected = true;

            //Color Piel
            this.lst12papasColorPiel.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorPiel = cc.GetCosechaColorPiel(id_cosecha);
            foreach (ListItem item in this.lst12papasColorPiel.Items)
                for (int i = 0; i < colorPiel.Count; i++)
                    if (item.Value == colorPiel[i].Id_color.ToString())
                        item.Selected = true;

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
            
            //Enfermedades y resistencia en el gridview
            this.gdv12papasEnfermedades.DataSource = cc.GetCosechaEnfermedades(id_cosecha);
            this.gdv12papasEnfermedades.DataBind();
        }

        protected void btn12papasAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            try
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

                        //Agrega las enfermedades con sus resistencias al dataset para luego dejarlo en el gridview
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
            catch (Exception ex)
            {
            }
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
                    //saca la enfermedad seleccionada
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

        protected void btnAgregar24papas_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha12papasGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdv12papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv12papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdv12papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv12papas.PageCount.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdv12papas.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv12papas.PageIndex = pageList.SelectedIndex;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Siguiente página
        protected void NextLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdv12papas.PageIndex = pageList.SelectedIndex + 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página anterior
        protected void PrevLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdv12papas.PageIndex = pageList.SelectedIndex - 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página inicio
        protected void FirstLB_Click(object sender, EventArgs e)
        {
            try
            {
                gdv12papas.PageIndex = 0;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página final
        protected void LastLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv12papas.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void Cosecha12papasGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv12papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdv12papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv12papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdv12papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv12papas.PageCount.ToString();
                }
                this.gdv12papas.Controls[0].Controls[this.gdv12papas.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }        
    }
}